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

namespace MatlabGUI_CS {
    public partial class WaveCompare : Form {

        public double[,] CurrentArr1;
        public double[,] CurrentArr2;


        public WaveCompare() {
            InitializeComponent();
        }

        private void SelectCSVFile_btn_Click(object sender, EventArgs e) {
            string csvPathName = GetCSVFilePathName();
            if (csvPathName == "") return;

            Button button = (Button)sender;

            TextBox detailTB;
            double[,] detailData;

            if (button.Name == "SelectCSVFile1_btn") {
                CurrentArr1 = ReadCSV(csvPathName);
                detailTB = Wave1_tb;
                detailData = CurrentArr1;
            }
            else {
                CurrentArr2 = ReadCSV(csvPathName);
                detailTB = Wave2_tb;
                detailData = CurrentArr2;
            }



            detailTB.Text = "文件名：" + csvPathName.Split('\\')[csvPathName.Split('\\').GetLength(0) - 1] + "\r\n";
            detailTB.Text += "行数：" + detailData.GetLength(0) + "\r\n";
            detailTB.Text += "列数：" + detailData.GetLength(1) + "\r\n";
            detailTB.Text += " 其中数据列 " + (detailData.GetLength(1) - 1) + " 列\r\n";
            detailTB.Text += "起始时间：" + detailData[0, 0] + "\r\n";
            detailTB.Text += "终止时间：" + detailData[detailData.GetLength(0) - 1, 0] + "\r\n";

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
    }
}
