using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace MatlabGUI_CS
{
    public partial class Main : Form
    {
        // 全局变量，matlab 引擎变量
        public static MLApp.MLApp matlab;

        // 全局变量，存储着当前的仿真数据
        public double[,] CurrentResultArr;


        public Main() {
            InitializeComponent();

            // 进行 matlab 引擎的初始化
            matlab = initMatlabEp();

            // 在程序运行的一开始就设置默认值
            getDefault();

            // 奇巧淫技：修正窗体的宽度
            this.Width = chart3.Location.X + chart3.Size.Width + 45;
        }

        #region REGION - 关于直接操作 matlab 引擎的辅助函数

        // 初始化 matlab 引擎
        private MLApp.MLApp initMatlabEp() {
            MLApp.MLApp matlab = null;
            Type matlabAppType = System.Type.GetTypeFromProgID("Matlab.Application");
            matlab = System.Activator.CreateInstance(matlabAppType) as MLApp.MLApp;
            return matlab;
        }

        // 辅助函数：清空 matlab 引擎中的变量
        public static void clearMatlab() {
            matlab.Execute("clear;");
        }

        // 辅助函数：从当前的 matlab 引擎中根据所传入的字符串获取其 double 的值
        public static double getDoubleFromMatlab(string varName) {
            var tempOut = matlab.GetVariable(varName, "base");
            double tempOutDouble = Convert.ToDouble(tempOut);
            return tempOutDouble;
        }

        #endregion


        // 关键辅助函数：读取需要设定的参数，并返回一个合适的结构体
        public struct ParaItems {

            public double Source_LorC;      // LC源_初始电容电压(V) 或 LC源_初始电感电流(A)
            public double VCB_C;            // VCB过零_初始电容电压(V)
            public double Discharge_R;      // 移能电阻_阻值(Ω)
            public double ThyristorTime;    // 晶闸管开断时间

            public double ZeroCrossing_C;   // 过零回路 电容
            public double ZeroCrossing_L;   // 过零回路 电感

            // 所获取的数据是否合法
            public bool isValid;
        }
        private ParaItems getItemsFromTextBox() {

            ParaItems tempResult;

            // 先设置初始值
            tempResult.Source_LorC = 0;
            tempResult.VCB_C = 0;
            tempResult.Discharge_R = 0;
            tempResult.ZeroCrossing_C = 0;
            tempResult.ZeroCrossing_L = 0;
            tempResult.ThyristorTime = 0;

            double? Source_LorC, VCB_C, Discharge_R, ZeroCrossing_C, ZeroCrossing_L, ZeroCrossing_F, ThyristorTime;

            // 获取所输入的数据
            Source_LorC = checkTextbox(Source_LorC_TB, Source_LorC_Label);
            VCB_C = checkTextbox(VCB_C_TB, VCB_C_Label);
            Discharge_R = checkTextbox(Discharge_R_TB, Discharge_R_Label);
            ZeroCrossing_C = checkTextbox(ZeroCrossing_C_TB, ZeroCrossing_C_Label, false);
            ZeroCrossing_L = checkTextbox(ZeroCrossing_L_TB, ZeroCrossing_L_Label, false);
            ZeroCrossing_F = checkTextbox(ZeroCrossing_F_TB, ZeroCrossing_F_Label, false);
            ThyristorTime = checkTextbox(ThyristorTime_TB, ThyristorTime_Label, false);

            // 判断合法性
            if (Source_LorC == null || VCB_C == null || Discharge_R == null || ThyristorTime == null) {
                tempResult.isValid = false;
                return tempResult;
            }

            // 对于过零回路相关参数的设置，三选二即可
            if ((ZeroCrossing_C == null && ZeroCrossing_L == null) ||
                (ZeroCrossing_C == null && ZeroCrossing_F == null) ||
                (ZeroCrossing_L == null && ZeroCrossing_F == null)) {
                    MessageBox.Show("过零回路相关参数中，请至少填入两个有效值", " 输入参数错误！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tempResult.isValid = false;
                    return tempResult;
            }

            // 处理相关参数
            // 相关公式： f=1/(2π*√(LC))
            if (ZeroCrossing_C != null && ZeroCrossing_L != null) {
                double C = Convert.ToDouble(ZeroCrossing_C) / 1e3;
                double L = Convert.ToDouble(ZeroCrossing_L) / 1e6;

                ZeroCrossing_F = 1 / (2 * Math.PI * Math.Sqrt(C * L));
                ZeroCrossing_F_TB.Text = ZeroCrossing_F.ToString();
            }
            if (ZeroCrossing_C != null && ZeroCrossing_F != null) {
                double C = Convert.ToDouble(ZeroCrossing_C) / 1e3;
                ZeroCrossing_L = Math.Pow((1 / (2 * Math.PI * Convert.ToDouble(ZeroCrossing_F))), 2) / C * 1e6;
                ZeroCrossing_L_TB.Text = ZeroCrossing_L.ToString();
            }
            if (ZeroCrossing_L != null && ZeroCrossing_F != null) {
                double L = Convert.ToDouble(ZeroCrossing_L) / 1e6;
                ZeroCrossing_C = Math.Pow((1 / (2 * Math.PI * Convert.ToDouble(ZeroCrossing_F))), 2) / L * 1e3;
                ZeroCrossing_C_TB.Text = ZeroCrossing_C.ToString();
            }

            tempResult.Source_LorC = Convert.ToDouble(Source_LorC);
            tempResult.VCB_C = Convert.ToDouble(VCB_C);
            tempResult.Discharge_R = Convert.ToDouble(Discharge_R);
            tempResult.ThyristorTime = Convert.ToDouble(ThyristorTime);

            tempResult.ZeroCrossing_C = Convert.ToDouble(ZeroCrossing_C) / 1e3;
            tempResult.ZeroCrossing_L = Convert.ToDouble(ZeroCrossing_L) / 1e6;

            tempResult.isValid = true;

            return tempResult;
        }

        // 辅助函数：判断指定文本框的内容是否为合法的 double 值，若是，则返回值, 若不是， 则返回 null, 并进行错误提示
        public static double? checkTextbox(TextBox TextboxName, Label LabelName, bool messageFlag = true) {
            double temp;
            try {
                temp = Convert.ToDouble(TextboxName.Text);
            }
            catch (Exception) {
                if (messageFlag) {
                    MessageBox.Show("请检查输入的数据：" + LabelName.Text, " 输入参数错误！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return null;
            }      
            return temp;
        }


        #region REGION - 所有与操作图表参数有关的辅助函数

        // 辅助函数：使给定 chart 控件清空 Series, 并更换 ChartArea
        public static void ClearSeriesAndResetChartArea(Chart chart) {
            chart.Series.Clear();

            // 每次绘图都来更换新的 ChartArea
            chart.ChartAreas.Clear();
            ChartArea tempArea = new ChartArea();
            chart.ChartAreas.Add(tempArea);
        }

        // 辅助函数：设置给定 chart 控件的X轴和Y轴的坐标的最大最小值，同时清空 Series, 并更换 ChartArea
        public static void setChartMinAndMax_ClearSeriesAndResetChartArea(Chart chart, double Xmax, double Xmin) {
            chart.Series.Clear();

            // 每次绘图都来更换新的 ChartArea
            chart.ChartAreas.Clear();
            ChartArea tempArea = new ChartArea();
            tempArea.AxisX.Maximum = Xmax;
            tempArea.AxisX.Minimum = Xmin;
            chart.ChartAreas.Add(tempArea);
        }


        #endregion

        /**
         * 关键辅助函数：获取matlab引擎中给定数组名称的数组，并返回所读取到的数组
         */
        public static double[,] getArrayData(string arrayName) {
            var sourceArr = matlab.GetVariable(arrayName, "base");
            double[,] tempDoubleArr = new double[10000000, 10];
            tempDoubleArr = (double[,])sourceArr;
            return tempDoubleArr;
        }

        /**
         * 关键辅助函数：传入double[,]数据，将其绘制到指定图表中
         * 
         * @param double[,] sourceArr       —— 数据来源
         * @param int index                 —— 所需要的数据在数组中的维数(第0维默认是时间)
         * @param Chart chartName           —— 所需要传入数据的图表
         * @param string seriesName = ""    —— 绘制出的 series 的名称
         * @param double offset             —— 时间的 offset
         * @param double gain               —— 数据的增益，会在绘制的时候与 sourceArr 中的数相乘然后绘制
         * 
         * @return double[,]                —— 从 matlab 引擎中读取到的数组
         */
        public static double[,] drawToChart (double[,] sourceArr, int index, Chart chartName, string seriesName = "", double offset = 0, double gain = 1) {

            Series currentSeries = new Series(seriesName);
            currentSeries.ChartType = SeriesChartType.Spline;
            currentSeries.BorderWidth = 2;  // 曲线宽度

            // 仿真得到的数组的长度
            int length = sourceArr.GetLength(0);

            int step = Main.calculateStep(length);

            for (int i = 1; i < length; i += step) {
                currentSeries.Points.AddXY(sourceArr[i, 0] + offset, sourceArr[i, index] * gain);
            }
            chartName.Series.Add(currentSeries);

            return sourceArr;
        }

        // 辅助函数：确定循环步长
        // 确定方法：步长为  (点数 / 2500) 的向上取整
        // 如有 4800 个点，则会绘制 4800 次（步长为 1 ）；如有 5100 点，则会绘制 2550 次（步长为 2 ）
        private static int calculateStep(int length, int num = 2500) {
            int step = 1;   // 循环的步长
            // 对于点的数量大于 一定数据 的数组进行优化
            if (length > num) {
                step = length / num;
            }
            return step;
        }

        // 辅助函数：将电流绘制到图表上，电流所对应的 chart 名称为 chart1 和 chart2
        private void drawToChart_Current(double[,] sourceArr, int index, string seriesName = "") {
            drawToChart(sourceArr, index, chart1, seriesName);
            drawToChart(sourceArr, index, chart2, seriesName);
        }

        // 辅助函数：将电压绘制到图表上，电压所对应的 chart 名称为 chart3 和 chart4
        private void drawToChart_Voltage(double[,] sourceArr, int index, string seriesName = "") {
            drawToChart(sourceArr, index, chart3, seriesName);
            drawToChart(sourceArr, index, chart4, seriesName);
        }




        /* 以下，图形界面外观设置 */
        private void TypeSelect_LC_CheckedChanged(object sender, EventArgs e) {
            Source_LorC_Label.Text = "LC源_初始电容电压(V)";
        }
        private void TypeSelect_L_CheckedChanged(object sender, EventArgs e) {
            Source_LorC_Label.Text = "失超电感_初始电流(A)";
        }



        /* 以下，根据现有图形界面进行参数的判断并仿真, 其中 DataSendedToMatlab 是所有要发送给 Matlab 引擎的数据 */
        struct DataSendedToMatlab {

            // 是否开启 实验装置LC源
            public int isLCSource;

            // 是否开启 实际情况L源
            public int isLSource;

            // 实验装置LC源 的初始电容电压
            public double initSourceC;

            // 实际情况L源 的初始电感电流
            public double initSourceL;

            // 提供过零电流的LC振荡回路 的初始电容电压
            public double initVCB_C;

            // 提供过零电流的LC振荡回路 电容值
            public double ZeroCrossing_C;

            // 提供过零电流的LC振荡回路 电感值
            public double ZeroCrossing_L;

            // 移能电阻 阻值
            public double Discharge_R;

            // 晶闸管开断时间
            public double ThyristorTime;
        }
        private void StartSimulink_btn_Click(object sender, EventArgs e) {

            ParaItems dataFromTextBox = getItemsFromTextBox();

            if( !dataFromTextBox.isValid ) {
                return;
            }

            // 整理参数, 做好发送给 Matlab 引擎的准备
            DataSendedToMatlab dataSendedToMatlab;
            if (TypeSelect_LC.Checked) {
                dataSendedToMatlab.isLCSource = 1;
                dataSendedToMatlab.isLSource = 0;
                dataSendedToMatlab.initSourceC = dataFromTextBox.Source_LorC;
                dataSendedToMatlab.initSourceL = 0.01;
            }
            else {
                dataSendedToMatlab.isLCSource = 0;
                dataSendedToMatlab.isLSource = 1;
                dataSendedToMatlab.initSourceC = 0;
                dataSendedToMatlab.initSourceL = dataFromTextBox.Source_LorC;
            }
            dataSendedToMatlab.initVCB_C = dataFromTextBox.VCB_C;
            dataSendedToMatlab.ZeroCrossing_C = dataFromTextBox.ZeroCrossing_C;
            dataSendedToMatlab.ZeroCrossing_L = dataFromTextBox.ZeroCrossing_L;
            dataSendedToMatlab.Discharge_R = dataFromTextBox.Discharge_R;
            dataSendedToMatlab.ThyristorTime = dataFromTextBox.ThyristorTime;


            // 仿真开始前禁用按钮
            SeriesView_Checkbox_Disabled();
            SeriesView_Checkbox_Checked();
            StartSimulink_btn.Text = "正在仿真中......请稍候";
            StartSimulink_btn.Enabled = false;
            toggleView_btn.Enabled = false;
            saveToFile_btn.Enabled = false;

            // 开始仿真
            SendDataAndStartSimulink(dataSendedToMatlab, "LC_QPS_2.mdl");

            // 仿真结束后启用按钮
            SeriesView_Checkbox_Enabled();
            StartSimulink_btn.Text = "开始仿真";
            StartSimulink_btn.Enabled = true;
            toggleView_btn.Enabled = true;
            saveToFile_btn.Enabled = true;
        }

        private void SendDataAndStartSimulink(DataSendedToMatlab data, string modelName) {

            // 清空 matlab 里面的变量
            clearMatlab();

            // 将所有数据传递到 Matlab 引擎
            matlab.Execute("isLCSource = " + data.isLCSource + ";");
            matlab.Execute("isLSource = " + data.isLSource + ";");
            matlab.Execute("initSourceC = " + data.initSourceC + ";");
            matlab.Execute("initSourceL = " + data.initSourceL + ";");
            matlab.Execute("initVCB_C = " + data.initVCB_C + ";");
            matlab.Execute("ZeroCrossing_C = " + data.ZeroCrossing_C + ";");
            matlab.Execute("ZeroCrossing_L = " + data.ZeroCrossing_L + ";");
            matlab.Execute("Discharge_R = " + data.Discharge_R + ";");
            matlab.Execute("ThyristorTime = " + data.ThyristorTime + ";");

            // 进行仿真
            matlab.Execute("sim('" + modelName + "');");

            // 设置坐标轴
            setChartMinAndMax_ClearSeriesAndResetChartArea(chart1, 0.012, 0);
            setChartMinAndMax_ClearSeriesAndResetChartArea(chart2, data.ThyristorTime + 0.00015, data.ThyristorTime - 0.00005);
            setChartMinAndMax_ClearSeriesAndResetChartArea(chart3, 0.012, 0);
            setChartMinAndMax_ClearSeriesAndResetChartArea(chart4, data.ThyristorTime + 0.00015, data.ThyristorTime - 0.00005);

            // 读取仿真之后的数据
            CurrentResultArr = getArrayData("Results");
            drawToChart_Current(CurrentResultArr, 1, "过零电流提供回路_电流");
            drawToChart_Voltage(CurrentResultArr, 2, "过零电流提供回路_电容电压");
            drawToChart_Voltage(CurrentResultArr, 3, "过零电流提供回路_电感电压");
            drawToChart_Voltage(CurrentResultArr, 4, "过零电流提供回路_晶闸管电压");
            drawToChart_Voltage(CurrentResultArr, 5, "失超源_电压");
            drawToChart_Current(CurrentResultArr, 6, "失超源_电流");
            drawToChart_Voltage(CurrentResultArr, 7, "模拟失超LC源_电容电压");
            drawToChart_Voltage(CurrentResultArr, 8, "模拟失超LC源_电感电压");
            drawToChart_Voltage(CurrentResultArr, 9, "VCB/移能电阻_电压");
            drawToChart_Current(CurrentResultArr, 10, "VCB_电流");
            drawToChart_Current(CurrentResultArr, 11, "移能电阻_电流");

        }

        // 按钮[toggleView_btn] 作用: 切换视图
        private void toggleView_btn_Click(object sender, EventArgs e) {
            chart1.Visible = !chart1.Visible;
            chart3.Visible = !chart3.Visible;
            toggleView_btn.Text = toggleView_btn.Text == "显示换流附近波形" ? "显示整体波形" : "显示换流附近波形";
        }


        // 按钮[OpenRLC_btn] 作用: 开启RLC计算的窗口
        private void OpenRLC_btn_Click(object sender, EventArgs e) {
            RLC_Compute form = new RLC_Compute();
            form.Show();
        }


        // 按钮[OpenCmp_btn] 作用: 开启波形比较的窗口
        private void OpenCmp_btn_Click(object sender, EventArgs e) {
            WaveCompare form = new WaveCompare();
            form.Show();
        }


        #region REGION - 构造函数参数设置默认值相关

        // 默认参数辅助函数：读取文本框参数，设置默认值
        private int setDefault() {
            ParaItems tempResult = getItemsFromTextBox();

            if( !tempResult.isValid ) {
                return -1;
            }

            ConfigAppSettings.SetValue("Source_LorC", tempResult.Source_LorC.ToString());
            ConfigAppSettings.SetValue("VCB_C", tempResult.VCB_C.ToString());
            ConfigAppSettings.SetValue("Discharge_R", tempResult.Discharge_R.ToString());
            ConfigAppSettings.SetValue("ThyristorTime", tempResult.ThyristorTime.ToString());

            ConfigAppSettings.SetValue("ZeroCrossing_C", (tempResult.ZeroCrossing_C * 1e3).ToString());
            ConfigAppSettings.SetValue("ZeroCrossing_L", (tempResult.ZeroCrossing_L * 1e6).ToString());

            return 0;
        }

        // 默认参数辅助函数：恢复默认值
        private void getDefault() {
            Source_LorC_TB.Text = ConfigAppSettings.GetValue("Source_LorC");
            VCB_C_TB.Text = ConfigAppSettings.GetValue("VCB_C");
            Discharge_R_TB.Text = ConfigAppSettings.GetValue("Discharge_R");
            ZeroCrossing_C_TB.Text = ConfigAppSettings.GetValue("ZeroCrossing_C");
            ZeroCrossing_L_TB.Text = ConfigAppSettings.GetValue("ZeroCrossing_L");
            ThyristorTime_TB.Text = ConfigAppSettings.GetValue("ThyristorTime");

        }

        // 默认参数按钮[applyDefault_btn]函数：应用当前的默认值
        private void applyDefault_btn_Click(object sender, EventArgs e) {

            getDefault();
            MessageBox.Show("应用默认值成功！");
        }

        // 默认参数按钮[setDefault_btn]函数：按照当前文本框中的数据，设置默认值
        private void setDefault_btn_Click(object sender, EventArgs e) {
            if(setDefault() == 0) {
                MessageBox.Show("设置默认值成功！");
            } else {
                MessageBox.Show("设置默认值失败！");
            }
        }



        #endregion


        #region REGION - 波形显示与否的控制相关

        /**
         * checkBox1 —— 电流0
         * checkBox2 —— 电压0
         * checkBox3 —— 电压1
         * checkBox4 —— 电压2
         * checkBox5 —— 电压3
         * checkBox6 —— 电流1
         * checkBox7 —— 电压4
         * checkBox8 —— 电压5
         * checkBox9 —— 电压6
         * checkBox10 —— 电流2
         * checkBox11 —— 电流3
         * 
         */

        // 多选框 [checkbox] 选择态被改变的时候的函数：更改对应 series 的 Enabled 的状态
        private void checkBox_CheckedChanged(object sender, EventArgs e) {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Name == "checkBox1") changeSeriesEnabled("Current", 0, checkBox.Checked);
            if (checkBox.Name == "checkBox2") changeSeriesEnabled("Voltage", 0, checkBox.Checked);
            if (checkBox.Name == "checkBox3") changeSeriesEnabled("Voltage", 1, checkBox.Checked);
            if (checkBox.Name == "checkBox4") changeSeriesEnabled("Voltage", 2, checkBox.Checked);
            if (checkBox.Name == "checkBox5") changeSeriesEnabled("Voltage", 3, checkBox.Checked);
            if (checkBox.Name == "checkBox6") changeSeriesEnabled("Current", 1, checkBox.Checked);
            if (checkBox.Name == "checkBox7") changeSeriesEnabled("Voltage", 4, checkBox.Checked);
            if (checkBox.Name == "checkBox8") changeSeriesEnabled("Voltage", 5, checkBox.Checked);
            if (checkBox.Name == "checkBox9") changeSeriesEnabled("Voltage", 6, checkBox.Checked);
            if (checkBox.Name == "checkBox10") changeSeriesEnabled("Current", 2, checkBox.Checked);
            if (checkBox.Name == "checkBox11") changeSeriesEnabled("Current", 3, checkBox.Checked);

        }

        // 辅助函数：更改对应图表的 Series 的 enabled 值
        private void changeSeriesEnabled(string type, int index, bool state) {
            if (type == "Current") {
                chart1.Series[index].Enabled = state;
                chart2.Series[index].Enabled = state;
            }
            else if (type == "Voltage") {
                chart3.Series[index].Enabled = state;
                chart4.Series[index].Enabled = state;
            }
            else MessageBox.Show("参数错误！");
        }


        // 辅助函数：启用用所有多选框和相关按钮
        private void SeriesView_Checkbox_Enabled() {
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
            checkBox4.Enabled = true;
            checkBox5.Enabled = true;
            checkBox6.Enabled = true;
            checkBox7.Enabled = true;
            checkBox8.Enabled = true;
            checkBox9.Enabled = true;
            checkBox10.Enabled = true;
            checkBox11.Enabled = true;
            viewAll_btn.Enabled = true;
            viewNone_btn.Enabled = true;
        }

        // 辅助函数：禁用所有多选框和相关按钮
        private void SeriesView_Checkbox_Disabled() {
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            checkBox5.Enabled = false;
            checkBox6.Enabled = false;
            checkBox7.Enabled = false;
            checkBox8.Enabled = false;
            checkBox9.Enabled = false;
            checkBox10.Enabled = false;
            checkBox11.Enabled = false;
            viewAll_btn.Enabled = false;
            viewNone_btn.Enabled = false;
        }

        // 辅助函数：选中所有多选框
        private void SeriesView_Checkbox_Checked() {
            checkBox1.Checked = true;
            checkBox2.Checked = true;
            checkBox3.Checked = true;
            checkBox4.Checked = true;
            checkBox5.Checked = true;
            checkBox6.Checked = true;
            checkBox7.Checked = true;
            checkBox8.Checked = true;
            checkBox9.Checked = true;
            checkBox10.Checked = true;
            checkBox11.Checked = true;
        }

        // 辅助函数：反选所有多选框
        private void SeriesView_Checkbox_Unchecked() {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
        }


        // 按钮[viewAll_btn] 作用: 在选择可见波形的部位，选中所有多选框
        private void viewAll_btn_Click(object sender, EventArgs e) {
            SeriesView_Checkbox_Checked();
        }

        // 按钮[viewNone_btn] 作用: 在选择可见波形的部位，不选所有多选框
        private void viewNone_btn_Click(object sender, EventArgs e) {
            SeriesView_Checkbox_Unchecked();
        }

        #endregion


        // 按钮[saveToFile_btn] 作用: 将目前的仿真结果保存到文件
        private void saveToFile_btn_Click(object sender, EventArgs e) {

            // 创建保存文件的对话框对象，并将其打开
            SaveFileDialog sfd = new SaveFileDialog {
                Title = "",
                InitialDirectory = @"C:\",
                Filter = "数据文件| *.csv"
            };
            sfd.ShowDialog();

            string path = sfd.FileName;
            if (path == "") { return; }


            using (FileStream fsWrite = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write)) {

                int row = CurrentResultArr.GetLength(0), col = CurrentResultArr.GetLength(1);
                int step = calculateStep(row);
                string rowStr;

                for (int i = 0; i < row; i += step) {
                    rowStr = "";
                    for (int j = 0; j < col; j++) {
                        rowStr += CurrentResultArr[i, j].ToString();
                        if (j != col - 1) rowStr += ",";
                    }
                    rowStr += "\n";

                    byte[] buffer = Encoding.Default.GetBytes(rowStr);
                    fsWrite.Write(buffer, 0, buffer.Length);
                }

                MessageBox.Show("保存成功");

            }

        }
    }
}
