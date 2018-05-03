using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MatlabGUI_CS {
    public partial class WaveCompare : Form {

        // 读取到的波形的详细信息
        struct WaveDetail {
            public string fileName;     // 文件名 
            public int row;             // 行数
            public int col;             // 列数
            public double startTime;    // 起始时间
            public double endTime;      // 终止时间
        }

        // 参与比较的设置信息
        struct CmpConfig {

            // 波形1 的起始时间
            public double cmpStartTime1;

            // 波形2 的起始时间
            public double cmpStartTime2;

            // 进行比较的波形所持续的时间
            public double cmpPeriod;

            // 进行比较的波形的序号队列
            // 该数组为 [length, 2] 的一个二维数组
            // 其中每一行均有两个元素，
            // 0 号元素代表第一个 csv 文件中要比较的数据列的序号，1 号元素代表第二个 csv 文件中要比较的数据列的序号
            // 该数组的行数则为要进行比较的波形的组数
            public int[,] cmpColArr;

            // 每一组要参与比较的波形的描述的字符串数组
            // 其长度与 cmpColArr 的行数一致
            public string[] cmpColDescription;
        }

        public double[,] CurrentArr1;
        public double[,] CurrentArr2;
        WaveDetail CurrentDetail1;
        WaveDetail CurrentDetail2;
        CmpConfig CurrentConfig;
        Chart[] charts = new Chart[20];

        public WaveCompare() {
            InitializeComponent();
        }

        private void SelectCSVFile_btn_Click(object sender, EventArgs e) {
            string csvPathName = GetCSVFilePathName();
            if (csvPathName == "") return;

            Button button = (Button)sender;

            TextBox detailTB;
            WaveDetail detailData;

            if (button.Name == "SelectCSVFile1_btn") {
                CurrentArr1 = ReadCSV(csvPathName);
                getDetailFromCSV(CurrentArr1, csvPathName, ref CurrentDetail1);
                detailTB = Wave1_tb;
                detailData = CurrentDetail1;
            }
            else if (button.Name == "SelectCSVFile2_btn") {
                CurrentArr2 = ReadCSV(csvPathName);
                getDetailFromCSV(CurrentArr2, csvPathName, ref CurrentDetail2);
                detailTB = Wave2_tb;
                detailData = CurrentDetail2;
            } else {
                detailTB = null;
                MessageBox.Show("发生未知错误！");
                return;
            }



            detailTB.Text = "文件名：" + detailData.fileName + "\r\n";
            detailTB.Text += "行数：" + detailData.row + "\r\n";
            detailTB.Text += "列数：" + detailData.col + "\r\n";
            detailTB.Text += " 其中数据列 " + (detailData.col - 1) + " 列\r\n";
            detailTB.Text += "起始时间：" + detailData.startTime + "\r\n";
            detailTB.Text += "终止时间：" + detailData.endTime + "\r\n";

        }

        // 辅助函数：根据输入的 csv 文件，读取其中的详细信息
        private void getDetailFromCSV(double[,] csv, string pathName, ref WaveDetail detail) {
            detail.fileName = pathName.Split('\\')[pathName.Split('\\').GetLength(0) - 1];
            detail.row = csv.GetLength(0);
            detail.col = csv.GetLength(1);
            detail.startTime = csv[0, 0];
            detail.endTime = csv[csv.GetLength(0) - 1, 0];
        }

        // 开启选择 csv 文件的窗口
        private string GetCSVFilePathName() {
            OpenFileDialog ofd = new OpenFileDialog {
                Title = "请选择要打开的文件",
                InitialDirectory = @"C:\",
                Filter = "数据文件| *.csv"
            };
            ofd.ShowDialog();

            string path = ofd.FileName;
            return path;

        }

        // 根据文件名读取 csv 文件
        private double[,] ReadCSV(string filePathName) {

            // 测试csv的行数和列数
            StreamReader fileTester = new StreamReader(filePathName);
            string testStr = "";
            int row = 0, col = 0;
            while (testStr != null) {
                testStr = fileTester.ReadLine();
                if (col == 0) col = testStr.Split(',').Length;
                row++;
            }
            row--;
            fileTester.Close();


            double[,] tempDoubleArr = new double[row, col];


            StreamReader fileReader = new StreamReader(filePathName);
      
            string strLine = "";
            int i = 0;

            while (strLine != null) {
                strLine = fileReader.ReadLine();
                if (strLine != null && strLine.Length > 0) {
                    string[] tempStrArr = strLine.Split(',');
                    for(int j = 0; j < tempStrArr.Length; j++) {
                        tempDoubleArr[i, j] = Convert.ToDouble(tempStrArr[j]);
                    }
                    i++;
                }
            }
            fileReader.Close();

            return tempDoubleArr;
        }

        // 按钮[StartCompare_btn] 作用：验证所有已输入数据的合法性，并开始进行比较
        private void StartCompare_btn_Click(object sender, EventArgs e) {

            if (checkConfig(ref CurrentConfig)) {

                // 在生成新的 Chart 图表之前删去所有已生成的 Chart
                for(int i = 0; i < charts.GetLength(0); i++) {
                    this.Controls.Remove(charts[i]);
                }

                for(int i = 0; i < CurrentConfig.cmpColArr.GetLength(0); i++) {

                    // 在指定位置生成 Chart
                    creatWaveCmpChart(CurrentConfig.cmpColDescription[i], i);

                    // 设置坐标轴
                    Main.setChartMinAndMax_ClearSeriesAndResetChartArea(charts[i], CurrentConfig.cmpPeriod, 0);

                    // 往刚刚生成的 chart 里面添加数据
                    Main.drawToChart(CurrentArr1, CurrentConfig.cmpColArr[i, 0], charts[i], "波形1 第" + CurrentConfig.cmpColArr[i, 0] + "列数据", -CurrentConfig.cmpStartTime1);
                    Main.drawToChart(CurrentArr2, CurrentConfig.cmpColArr[i, 1], charts[i], "波形2 第" + CurrentConfig.cmpColArr[i, 1] + "列数据", -CurrentConfig.cmpStartTime2);

                    // 设置仅第一个可见，其余不可见
                    charts[i].Visible = i == 0 ? true : false;
                }


            }

            



        }

        // 辅助函数：验证目前所有已输入数据的合法性，合法则进行设置的存储，并返回 true；不合法则进行错误提示，并返回 false
        private bool checkConfig(ref CmpConfig config) {

            // 判断1：是否已读入 csv 文件
            if(CurrentArr1 == null || CurrentArr2 == null) {
                MessageBox.Show("尚未选择波形文件，请选择之后重试");
                return false;
            }

            // 判断2-1：判断起始时间和持续时间输入是否合法
            double? cmpStartTime1_W = Main.checkTextbox(cmpStartTime1_TB, cmpStartTime1_Label);
            double? cmpStartTime2_W = Main.checkTextbox(cmpStartTime2_TB, cmpStartTime2_Label);
            double? cmpPeriod_W = Main.checkTextbox(cmpPeriod_TB, cmpPeriod_Label);
            if(cmpStartTime1_W == null || cmpStartTime2_W == null || cmpPeriod_W == null) {
                return false;
            }

            // 判断2-2：判断起始时间和持续时间是否在时间范围内
            double cmpStartTime1 = Convert.ToDouble(cmpStartTime1_W);
            double cmpStartTime2 = Convert.ToDouble(cmpStartTime2_W);
            double cmpPeriod = Convert.ToDouble(cmpPeriod_W);
            if(cmpPeriod <= 0) {
                MessageBox.Show("进行比较的时间范围必须大于0，请修改之后重试");
                return false;
            }
            if(cmpStartTime1 < CurrentDetail1.startTime || cmpStartTime2 < CurrentDetail2.startTime) {
                MessageBox.Show("要进行比较的时间段的起始时间必须大于波形的起始时间，请修改之后重试");
                return false;
            }
            if (cmpStartTime1 + cmpPeriod > CurrentDetail1.endTime || cmpStartTime2 + cmpPeriod > CurrentDetail2.endTime) {
                MessageBox.Show("要进行比较的时间段的结束时间必须小于波形的结束时间，请修改之后重试");
                return false;
            }

            // 判断3-1：判断要进行比较的对应列输入是否合法
            int colCount = CmpCol_DGV.Rows.Count - 1;
            if (colCount == 0) {
                MessageBox.Show("应该输入要进行比较的数据列，请修改之后重试");
                return false;
            }

            int[,] cmpColArr = new int[colCount, 2];
            string[] cmpColDescription = new String[colCount];
            for(int i = 0; i < colCount; i++) {
                for(int j = 0; j < 2; j++) {
                    int temp;
                    try {
                        temp = Convert.ToInt32(CmpCol_DGV.Rows[i].Cells[j].Value);
                    }
                    catch (Exception) {
                        MessageBox.Show("要比较的数据列应该为整数，请修改之后重试");
                        return false;
                    }
                    cmpColArr[i, j] = temp;
                }

                // 设置描述的读取，对为赋值的描述赋予默认值
                if (CmpCol_DGV.Rows[i].Cells[2].Value == null) {
                    cmpColDescription[i] = "比较" + (i + 1);
                } else {
                    cmpColDescription[i] = CmpCol_DGV.Rows[i].Cells[2].Value.ToString();
                }
            }

            // 判断3-2：判断要进行比较的对应列是否在数据列范围内
            for(int i = 0; i < cmpColArr.GetLength(0); i++) {
                if(cmpColArr[i, 0] > CurrentDetail1.col - 1 || cmpColArr[i, 1] > CurrentDetail2.col - 1) {
                    MessageBox.Show("要比较的数据列中存在超出数据列范围的值，请修改之后重试");
                    return false;
                }
                if(cmpColArr[i, 0] < 0 || cmpColArr[i, 1] < 0) {
                    MessageBox.Show("要比较的数据列中存在小于0的值，请修改之后重试");
                    return false;
                }
            }

            // 一切设置均合法，储存所有的设置内容
            config.cmpStartTime1 = cmpStartTime1;
            config.cmpStartTime2 = cmpStartTime2;
            config.cmpPeriod = cmpPeriod;
            config.cmpColArr = cmpColArr;
            config.cmpColDescription = cmpColDescription;

            // 补充未填写的比较描述
            for(int i = 0; i < cmpColDescription.Length; i++) {
                CmpCol_DGV.Rows[i].Cells[2].Value = cmpColDescription[i];
            }

            return true;
        }

        // 辅助函数：生成 chart 以用于波形比较
        // 需要传入的参数： description —— 目前进行比较的波形的描述
        //                  index —— 该比较波形在波形比较队列中的序号
        private void creatWaveCmpChart(string description, int index) {

            // 基础控件生成
            Chart chart = new Chart();
            ChartArea chartarea  = new ChartArea();
            Title title = new Title();
            Legend legend = new Legend();

            chartarea.Name = "chartarea";
            chart.ChartAreas.Add(chartarea);
            legend.Name = "legend";
            legend.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            chart.Legends.Add(legend);
            chart.Location = new System.Drawing.Point(891, 74);
            chart.Name = "chart1";
            chart.Size = new System.Drawing.Size(859, 557);
            chart.TabIndex = 12;
            chart.Text = "chart1";
            title.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title.Name = "Title1";
            chart.Titles.Add(title);

            // 有意义语句
            title.Text = description + " 波形比较";

            charts[index] = chart;
            this.Controls.Add(chart);

        }

        // 按钮[toLeft_btn] 作用： 将当前显示图像左移一位
        private void toLeft_btn_Click(object sender, EventArgs e) {
            changeViewChart(0, -1);
        }

        // 按钮[toLeft_btn] 作用： 将当前显示图像右移一位
        private void toRight_btn_Click(object sender, EventArgs e) {
            changeViewChart(0, 1);
        }

        // 辅助函数：根据给定 图像序号 或 移位数 更改图像的显示
        private void changeViewChart(int index, int offset = 0) {

            // 先获取目前正在显示的 chart 的序号
            int exVisiableChartIndex = -10;
            for (int i = 0; i < charts.GetLength(0); i++) {
                if (charts[i].Visible == true) {
                    exVisiableChartIndex = i;
                    break;
                }
            }

            // 判断移位值，若移位值不为 0 ，则根据移位值更改 chart 的显示
            if(offset != 0) {
                exVisiableChartIndex += offset;
                if(exVisiableChartIndex == -1) {
                    exVisiableChartIndex = CurrentConfig.cmpColArr.GetLength(0) - 1;
                } else if (exVisiableChartIndex == CurrentConfig.cmpColArr.GetLength(0)) {
                    exVisiableChartIndex = 0;
                }

                for (int i = 0; i < CurrentConfig.cmpColArr.GetLength(0); i++) {
                    charts[i].Visible = i == exVisiableChartIndex ? true : false;
                }

                // 此处特别注意：当 offset 为赋值为不为0的整数，则此函数仅根据 offset 进行变化，而与 index 无关
                return;
            }
        }
    }
}
