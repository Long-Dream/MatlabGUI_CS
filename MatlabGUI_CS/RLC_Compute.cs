using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MatlabGUI_CS {
    public partial class RLC_Compute : Form {
        public RLC_Compute() {
            InitializeComponent();
        }

        struct DataSendedToMatlab {

            // 电阻大小
            public double R;

            // 电感大小
            public double L;

            // 电感初始值
            public double L_init;

            // 电容大小
            public double C;

            // 电容初始值
            public double C_init;

            // 仿真时间
            public double simTime;

            // 示波器采样间隔
            public double simInterval;
        }
        private void StartCompute_btn_Click(object sender, EventArgs e) {

            // 先禁用按钮
            StartCompute_btn.Text = "正在计算";
            StartCompute_btn.Enabled = false;

            double? R, L, C, L_init, C_init;
            double period, interval;

            // 获取所输入的数据
            R = Main.checkTextbox(RLC_R_TB, RLC_R);
            L = Main.checkTextbox(RLC_L_TB, RLC_L);
            C = Main.checkTextbox(RLC_C_TB, RLC_C);
            L_init = Main.checkTextbox(RLC_L_init_TB, RLC_L_init);
            C_init = Main.checkTextbox(RLC_C_init_TB, RLC_C_init);

            // 判断合法性
            if (R == null || L == null || C == null) {
                // 出现错误时启用按钮
                StartCompute_btn.Text = "开始计算";
                StartCompute_btn.Enabled = true;
                return;
            }

            // 对于 RLC 的特殊要求：不能小于等于0
            if (R < 0 || L <= 0 || C <= 0) {
                MessageBox.Show("RLC仿真要求 L、C 均大于0，R 不小于0，请检查参数。");
                // 出现错误时启用按钮
                StartCompute_btn.Text = "开始计算";
                StartCompute_btn.Enabled = true;
                return;
            }

            // 计算周期 和 采样间隔时间
            period = 2 * Math.PI * Math.Sqrt(Convert.ToDouble(L) * Convert.ToDouble(C));
            interval = (3 * period) / 2500;

            // 整理参数, 做好发送给 Matlab 引擎的准备
            DataSendedToMatlab dataSendedToMatlab;

            dataSendedToMatlab.L = Convert.ToDouble(L);
            dataSendedToMatlab.C = Convert.ToDouble(C);

            dataSendedToMatlab.L_init = Convert.ToDouble(L_init);
            dataSendedToMatlab.C_init = Convert.ToDouble(C_init);

            // 对 R = 0 的情况进行特别处理
            if(Convert.ToDouble(R) == 0) {
                dataSendedToMatlab.R = Double.Epsilon;  // 这是一个极小的数
            } else {
                dataSendedToMatlab.R = Convert.ToDouble(R);
            }

            dataSendedToMatlab.simTime = 3 * period;         // 对前三个周波进行仿真
            dataSendedToMatlab.simInterval = interval;       // 读取其中的 2400 个点，则每 400 个点为一个半波

            SendDataAndStartSimulink(dataSendedToMatlab, "RLC_Compute.mdl");

            // 仿真结束后启用按钮
            StartCompute_btn.Text = "开始计算";
            StartCompute_btn.Enabled = true;

        }

        private void SendDataAndStartSimulink(DataSendedToMatlab data, string modelName) {

            // 清空 matlab 里面的变量
            Main.clearMatlab();

            // 将所有数据传递到 Matlab 引擎
            Main.matlab.Execute("R = " + data.R + ";");
            Main.matlab.Execute("L = " + data.L + ";");
            Main.matlab.Execute("C = " + data.C + ";");
            Main.matlab.Execute("L_init = " + data.L_init + ";");
            Main.matlab.Execute("C_init = " + data.C_init + ";");
            Main.matlab.Execute("simTime = " + data.simTime + ";");
            Main.matlab.Execute("simInterval = " + data.simInterval + ";");

            // 进行仿真
            Main.matlab.Execute("sim('" + modelName + "');");

            // 读取数据，并绘制图表
            Main.ClearSeriesAndResetChartArea(RLC_Chart);
            double[,] result = Main.getArrayData("RLC_Result");
            Main.drawToChart(result, 1, RLC_Chart, "振荡波形");

            // 进行参数的显示
            RLC_Result_TB.Text = "";
            RLC_Result_TB.Text += "振荡频率 f(Hz) :  "+ (1 / (2 * Math.PI * Math.Sqrt(data.L * data.C))).ToString("F4") + "\r\n";
            RLC_Result_TB.Text += "振荡周期 T(ms) :  " + (1 / (1 / (2 * Math.PI * Math.Sqrt(data.L * data.C))) * 1000).ToString("F4") + "\r\n";
            RLC_Result_TB.Text += "振荡类型  :  " + ((data.C > 4 * data.L / (data.R * data.R)) ? "过阻尼" :
                data.C == 4 * data.L / (data.R * data.R) ? "临界阻尼" : "欠阻尼") + "\r\n";
            double A = 0;       // 半波幅值
            int maxIndex = 0;   // 半波幅值对应的时间
            // 下面的这个循环用于计算各个半波的幅值
            for(int i = 0; i < 2400; i++) {
                if (A < Math.Abs(result[i, 1])) { A = Math.Abs(result[i, 1]); maxIndex = i;  }
                if((i + 1) % 400 == 0) {
                    RLC_Result_TB.Text += "第" + ((i + 1) / 400) + "个半波的幅值: " + A.ToString("F4") + "\r\n";
                    RLC_Result_TB.Text += "    于 " + (data.simTime / 2400 * maxIndex).ToString("F4") + " 秒处取得\r\n";
                    A = 0;
                    maxIndex = 0;
                }
            }

        }


        // 进行未知LC的情况下，计算电容C和电感L
        // 由于并不需要调用 matlab 引擎，故无需禁用按钮
        private void StartCompute2_btn_Click(object sender, EventArgs e) {

            double? f, Im, C_init;

            // 获取所输入的数据
            f = Main.checkTextbox(RLC_F_TB, RLC_F);
            Im = Main.checkTextbox(RLC_Im_TB, RLC_Im);
            C_init = Main.checkTextbox(RLC_C_init2_TB, RLC_C_init2);


            // 判断合法性
            if (f == null || Im == null || C_init == null) {
                return;
            }

            // 对于 RLC 的特殊要求：不能为0
            if (f <= 0 || Im <= 0 || C_init <= 0) {
                MessageBox.Show("在计算参数时，要求所给参数均大于0，请重新输入");
                return;
            }

            double d_f = Convert.ToDouble(f), d_Im = Convert.ToDouble(Im), d_C_init = Convert.ToDouble(C_init);


            // 开始计算 L 和 C 
            // 由 频率公式 f = 1 / 2π√(LC) 和 能量守恒公式 CU² = LI²    
            // 可计算得 L = U / 2πIf    C = 1 / 4π²f²L
            double L = Convert.ToDouble(C_init) / (2 * Math.PI * d_Im * d_f);
            double C = 1 / (4 * Math.PI * Math.PI * d_f * d_f * L);

            // 输出结果
            RLC_Result2_TB.Text = "计算出的电感 L 的取值为：\r\n" + L.ToString("F8") + " H\r\n";
            RLC_Result2_TB.Text += "计算出的电容 C 的取值为：\r\n" + C.ToString("F8") + " F\r\n";

        }


        // 进行未知RLC的情况下，计算电容C 电感L 电阻R
        // 由于并不需要调用 matlab 引擎，故无需禁用按钮
        private void StartCompute3_btn_Click(object sender, EventArgs e) {

            double? C, Im1, Im2, T;

            // 获取所输入的数据
            C = Main.checkTextbox(RLC2_C_TB, RLC2_C);
            T = Main.checkTextbox(RLC2_T_TB, RLC2_T);
            Im1 = Main.checkTextbox(RLC2_Im1_TB, RLC2_Im1);
            Im2 = Main.checkTextbox(RLC2_Im2_TB, RLC2_Im2);

            // 判断合法性
            if (C == null || Im1 == null || Im2 == null || T == null) {
                return;
            }

            // 对于 RLC 的特殊要求：不能为0
            if (C <= 0 || T <= 0) {
                MessageBox.Show("在计算参数时，要求所给参数均大于0，请重新输入");
                return;
            }

            double d_C = Convert.ToDouble(C) / 1000;    // 毫法 转换成 法
            double d_Im1 = Convert.ToDouble(Im1);
            double d_Im2 = Convert.ToDouble(Im2);
            double d_T = Convert.ToDouble(T) / 1000;    // 毫秒 转换成 秒

            //  X = r/2L = 2/T * ln(abs(I1/I2))       w = 2π / T = √(w0^2 - x^2)

            // 开始计算参数
            double X, w0, R, L;
            X = 2 / d_T * Math.Log(Math.Abs(d_Im1/d_Im2), Math.E);
            w0 = Math.Sqrt((2 * Math.PI / d_T) * (2 * Math.PI / d_T) + X * X);
            L = 1 / (d_C * w0 * w0);
            R = 2 * L * X;

            // 输出结果
            RLC_Result3_TB.Text = "计算出的电感 L 的取值为：\r\n" + (L * 1e6).ToString("F8") + " μH\r\n";
            RLC_Result3_TB.Text += "计算出的电阻 R 的取值为：\r\n" + (R * 1e3).ToString("F8") + " mΩ\r\n";

        }
    }
}
