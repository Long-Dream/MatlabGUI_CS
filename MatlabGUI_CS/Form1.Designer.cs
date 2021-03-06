﻿namespace MatlabGUI_CS
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title7 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title8 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.Title = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TypeSelect = new System.Windows.Forms.GroupBox();
            this.TypeSelect_L = new System.Windows.Forms.RadioButton();
            this.TypeSelect_LC = new System.Windows.Forms.RadioButton();
            this.initInput = new System.Windows.Forms.GroupBox();
            this.ZeroCrossing_F_TB = new System.Windows.Forms.TextBox();
            this.ZeroCrossing_F_Label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ZeroCrossing_L_TB = new System.Windows.Forms.TextBox();
            this.ZeroCrossing_L_Label = new System.Windows.Forms.Label();
            this.ZeroCrossing_C_TB = new System.Windows.Forms.TextBox();
            this.ZeroCrossing_C_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.setDefault_btn = new System.Windows.Forms.Button();
            this.Discharge_R_TB = new System.Windows.Forms.TextBox();
            this.applyDefault_btn = new System.Windows.Forms.Button();
            this.Discharge_R_Label = new System.Windows.Forms.Label();
            this.VCB_C_TB = new System.Windows.Forms.TextBox();
            this.VCB_C_Label = new System.Windows.Forms.Label();
            this.Source_LorC_TB = new System.Windows.Forms.TextBox();
            this.Source_LorC_Label = new System.Windows.Forms.Label();
            this.StartSimulink_btn = new System.Windows.Forms.Button();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toggleView_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.viewNone_btn = new System.Windows.Forms.Button();
            this.viewAll_btn = new System.Windows.Forms.Button();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.OpenRLC_btn = new System.Windows.Forms.Button();
            this.saveToFile_btn = new System.Windows.Forms.Button();
            this.OpenCmp_btn = new System.Windows.Forms.Button();
            this.ThyristorTime_TB = new System.Windows.Forms.TextBox();
            this.ThyristorTime_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.TypeSelect.SuspendLayout();
            this.initInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("微软雅黑", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Title.Location = new System.Drawing.Point(508, 20);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(364, 50);
            this.Title.TabIndex = 1;
            this.Title.Text = "失超保护开关的仿真";
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(517, 88);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(544, 532);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            title5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            title5.Name = "Title1";
            title5.Text = "仿真电流波形_整体";
            this.chart1.Titles.Add(title5);
            // 
            // chart2
            // 
            chartArea6.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea6);
            legend6.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend6.Name = "Legend1";
            this.chart2.Legends.Add(legend6);
            this.chart2.Location = new System.Drawing.Point(517, 87);
            this.chart2.Name = "chart2";
            this.chart2.Size = new System.Drawing.Size(544, 533);
            this.chart2.TabIndex = 8;
            this.chart2.Text = "chart2";
            title6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            title6.Name = "Title1";
            title6.Text = "仿真电流波形_换流附近";
            this.chart2.Titles.Add(title6);
            // 
            // TypeSelect
            // 
            this.TypeSelect.Controls.Add(this.TypeSelect_L);
            this.TypeSelect.Controls.Add(this.TypeSelect_LC);
            this.TypeSelect.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TypeSelect.Location = new System.Drawing.Point(21, 88);
            this.TypeSelect.Name = "TypeSelect";
            this.TypeSelect.Size = new System.Drawing.Size(223, 89);
            this.TypeSelect.TabIndex = 11;
            this.TypeSelect.TabStop = false;
            this.TypeSelect.Text = "仿真类型选择";
            // 
            // TypeSelect_L
            // 
            this.TypeSelect_L.AutoSize = true;
            this.TypeSelect_L.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TypeSelect_L.Location = new System.Drawing.Point(15, 60);
            this.TypeSelect_L.Name = "TypeSelect_L";
            this.TypeSelect_L.Size = new System.Drawing.Size(175, 24);
            this.TypeSelect_L.TabIndex = 13;
            this.TypeSelect_L.Text = "失超电感仿真——L源";
            this.TypeSelect_L.UseVisualStyleBackColor = true;
            this.TypeSelect_L.CheckedChanged += new System.EventHandler(this.TypeSelect_L_CheckedChanged);
            // 
            // TypeSelect_LC
            // 
            this.TypeSelect_LC.AutoSize = true;
            this.TypeSelect_LC.Checked = true;
            this.TypeSelect_LC.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TypeSelect_LC.Location = new System.Drawing.Point(15, 30);
            this.TypeSelect_LC.Name = "TypeSelect_LC";
            this.TypeSelect_LC.Size = new System.Drawing.Size(185, 24);
            this.TypeSelect_LC.TabIndex = 12;
            this.TypeSelect_LC.TabStop = true;
            this.TypeSelect_LC.Text = "实验装置仿真——LC源";
            this.TypeSelect_LC.UseVisualStyleBackColor = true;
            this.TypeSelect_LC.CheckedChanged += new System.EventHandler(this.TypeSelect_LC_CheckedChanged);
            // 
            // initInput
            // 
            this.initInput.Controls.Add(this.ThyristorTime_TB);
            this.initInput.Controls.Add(this.ThyristorTime_Label);
            this.initInput.Controls.Add(this.ZeroCrossing_F_TB);
            this.initInput.Controls.Add(this.ZeroCrossing_F_Label);
            this.initInput.Controls.Add(this.label5);
            this.initInput.Controls.Add(this.ZeroCrossing_L_TB);
            this.initInput.Controls.Add(this.ZeroCrossing_L_Label);
            this.initInput.Controls.Add(this.ZeroCrossing_C_TB);
            this.initInput.Controls.Add(this.ZeroCrossing_C_Label);
            this.initInput.Controls.Add(this.label1);
            this.initInput.Controls.Add(this.setDefault_btn);
            this.initInput.Controls.Add(this.Discharge_R_TB);
            this.initInput.Controls.Add(this.applyDefault_btn);
            this.initInput.Controls.Add(this.Discharge_R_Label);
            this.initInput.Controls.Add(this.VCB_C_TB);
            this.initInput.Controls.Add(this.VCB_C_Label);
            this.initInput.Controls.Add(this.Source_LorC_TB);
            this.initInput.Controls.Add(this.Source_LorC_Label);
            this.initInput.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.initInput.Location = new System.Drawing.Point(21, 183);
            this.initInput.Name = "initInput";
            this.initInput.Size = new System.Drawing.Size(223, 508);
            this.initInput.TabIndex = 12;
            this.initInput.TabStop = false;
            this.initInput.Text = "初始参数确定";
            // 
            // ZeroCrossing_F_TB
            // 
            this.ZeroCrossing_F_TB.Location = new System.Drawing.Point(91, 396);
            this.ZeroCrossing_F_TB.Name = "ZeroCrossing_F_TB";
            this.ZeroCrossing_F_TB.Size = new System.Drawing.Size(105, 31);
            this.ZeroCrossing_F_TB.TabIndex = 5;
            // 
            // ZeroCrossing_F_Label
            // 
            this.ZeroCrossing_F_Label.AutoSize = true;
            this.ZeroCrossing_F_Label.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ZeroCrossing_F_Label.Location = new System.Drawing.Point(13, 401);
            this.ZeroCrossing_F_Label.Name = "ZeroCrossing_F_Label";
            this.ZeroCrossing_F_Label.Size = new System.Drawing.Size(68, 20);
            this.ZeroCrossing_F_Label.TabIndex = 28;
            this.ZeroCrossing_F_Label.Text = "频率(Hz)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(13, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "若全填，则以前两项为准";
            // 
            // ZeroCrossing_L_TB
            // 
            this.ZeroCrossing_L_TB.Location = new System.Drawing.Point(91, 359);
            this.ZeroCrossing_L_TB.Name = "ZeroCrossing_L_TB";
            this.ZeroCrossing_L_TB.Size = new System.Drawing.Size(105, 31);
            this.ZeroCrossing_L_TB.TabIndex = 4;
            this.ZeroCrossing_L_TB.Text = "5";
            // 
            // ZeroCrossing_L_Label
            // 
            this.ZeroCrossing_L_Label.AutoSize = true;
            this.ZeroCrossing_L_Label.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ZeroCrossing_L_Label.Location = new System.Drawing.Point(13, 364);
            this.ZeroCrossing_L_Label.Name = "ZeroCrossing_L_Label";
            this.ZeroCrossing_L_Label.Size = new System.Drawing.Size(70, 20);
            this.ZeroCrossing_L_Label.TabIndex = 25;
            this.ZeroCrossing_L_Label.Text = "电感(μH)";
            // 
            // ZeroCrossing_C_TB
            // 
            this.ZeroCrossing_C_TB.Location = new System.Drawing.Point(91, 322);
            this.ZeroCrossing_C_TB.Name = "ZeroCrossing_C_TB";
            this.ZeroCrossing_C_TB.Size = new System.Drawing.Size(105, 31);
            this.ZeroCrossing_C_TB.TabIndex = 3;
            this.ZeroCrossing_C_TB.Text = "20";
            // 
            // ZeroCrossing_C_Label
            // 
            this.ZeroCrossing_C_Label.AutoSize = true;
            this.ZeroCrossing_C_Label.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ZeroCrossing_C_Label.Location = new System.Drawing.Point(13, 327);
            this.ZeroCrossing_C_Label.Name = "ZeroCrossing_C_Label";
            this.ZeroCrossing_C_Label.Size = new System.Drawing.Size(71, 20);
            this.ZeroCrossing_C_Label.TabIndex = 23;
            this.ZeroCrossing_C_Label.Text = "电容(mF)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(13, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "过零回路参数设置（三填二）";
            // 
            // setDefault_btn
            // 
            this.setDefault_btn.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.setDefault_btn.Location = new System.Drawing.Point(11, 447);
            this.setDefault_btn.Name = "setDefault_btn";
            this.setDefault_btn.Size = new System.Drawing.Size(92, 52);
            this.setDefault_btn.TabIndex = 6;
            this.setDefault_btn.Text = "按当前数据设置默认值";
            this.setDefault_btn.UseVisualStyleBackColor = true;
            this.setDefault_btn.Click += new System.EventHandler(this.setDefault_btn_Click);
            // 
            // Discharge_R_TB
            // 
            this.Discharge_R_TB.Location = new System.Drawing.Point(14, 176);
            this.Discharge_R_TB.Name = "Discharge_R_TB";
            this.Discharge_R_TB.Size = new System.Drawing.Size(163, 31);
            this.Discharge_R_TB.TabIndex = 2;
            this.Discharge_R_TB.Text = "0.1";
            // 
            // applyDefault_btn
            // 
            this.applyDefault_btn.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.applyDefault_btn.Location = new System.Drawing.Point(109, 447);
            this.applyDefault_btn.Name = "applyDefault_btn";
            this.applyDefault_btn.Size = new System.Drawing.Size(93, 52);
            this.applyDefault_btn.TabIndex = 7;
            this.applyDefault_btn.Text = "恢复默认值";
            this.applyDefault_btn.UseVisualStyleBackColor = true;
            this.applyDefault_btn.Click += new System.EventHandler(this.applyDefault_btn_Click);
            // 
            // Discharge_R_Label
            // 
            this.Discharge_R_Label.AutoSize = true;
            this.Discharge_R_Label.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Discharge_R_Label.Location = new System.Drawing.Point(14, 153);
            this.Discharge_R_Label.Name = "Discharge_R_Label";
            this.Discharge_R_Label.Size = new System.Drawing.Size(128, 20);
            this.Discharge_R_Label.TabIndex = 18;
            this.Discharge_R_Label.Text = "移能电阻_阻值(Ω)";
            // 
            // VCB_C_TB
            // 
            this.VCB_C_TB.Location = new System.Drawing.Point(14, 119);
            this.VCB_C_TB.Name = "VCB_C_TB";
            this.VCB_C_TB.Size = new System.Drawing.Size(165, 31);
            this.VCB_C_TB.TabIndex = 1;
            this.VCB_C_TB.Text = "-10000";
            // 
            // VCB_C_Label
            // 
            this.VCB_C_Label.AutoSize = true;
            this.VCB_C_Label.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.VCB_C_Label.Location = new System.Drawing.Point(14, 96);
            this.VCB_C_Label.Name = "VCB_C_Label";
            this.VCB_C_Label.Size = new System.Drawing.Size(185, 20);
            this.VCB_C_Label.TabIndex = 16;
            this.VCB_C_Label.Text = "VCB过零_初始电容电压(V)";
            // 
            // Source_LorC_TB
            // 
            this.Source_LorC_TB.Location = new System.Drawing.Point(14, 59);
            this.Source_LorC_TB.Name = "Source_LorC_TB";
            this.Source_LorC_TB.Size = new System.Drawing.Size(166, 31);
            this.Source_LorC_TB.TabIndex = 0;
            this.Source_LorC_TB.Text = "10000";
            // 
            // Source_LorC_Label
            // 
            this.Source_LorC_Label.AutoSize = true;
            this.Source_LorC_Label.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Source_LorC_Label.Location = new System.Drawing.Point(14, 36);
            this.Source_LorC_Label.Name = "Source_LorC_Label";
            this.Source_LorC_Label.Size = new System.Drawing.Size(159, 20);
            this.Source_LorC_Label.TabIndex = 0;
            this.Source_LorC_Label.Text = "LC源_初始电容电压(V)";
            // 
            // StartSimulink_btn
            // 
            this.StartSimulink_btn.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StartSimulink_btn.Location = new System.Drawing.Point(250, 621);
            this.StartSimulink_btn.Name = "StartSimulink_btn";
            this.StartSimulink_btn.Size = new System.Drawing.Size(261, 57);
            this.StartSimulink_btn.TabIndex = 0;
            this.StartSimulink_btn.Text = "开始仿真";
            this.StartSimulink_btn.UseVisualStyleBackColor = true;
            this.StartSimulink_btn.Click += new System.EventHandler(this.StartSimulink_btn_Click);
            // 
            // chart4
            // 
            chartArea7.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea7);
            legend7.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend7.Name = "Legend1";
            this.chart4.Legends.Add(legend7);
            this.chart4.Location = new System.Drawing.Point(1077, 87);
            this.chart4.Name = "chart4";
            this.chart4.Size = new System.Drawing.Size(544, 532);
            this.chart4.TabIndex = 10;
            this.chart4.Text = "chart4";
            title7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title7.Name = "Title1";
            title7.Text = "仿真电压波形_换流附近";
            this.chart4.Titles.Add(title7);
            // 
            // chart3
            // 
            chartArea8.AxisY.IsStartedFromZero = false;
            chartArea8.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea8);
            legend8.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend8.Name = "Legend1";
            this.chart3.Legends.Add(legend8);
            this.chart3.Location = new System.Drawing.Point(1077, 88);
            this.chart3.Name = "chart3";
            this.chart3.Size = new System.Drawing.Size(544, 532);
            this.chart3.TabIndex = 9;
            this.chart3.Text = "chart3";
            title8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title8.Name = "Title1";
            title8.Text = "仿真电压波形_整体";
            this.chart3.Titles.Add(title8);
            // 
            // toggleView_btn
            // 
            this.toggleView_btn.Enabled = false;
            this.toggleView_btn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toggleView_btn.Location = new System.Drawing.Point(700, 644);
            this.toggleView_btn.Name = "toggleView_btn";
            this.toggleView_btn.Size = new System.Drawing.Size(152, 34);
            this.toggleView_btn.TabIndex = 14;
            this.toggleView_btn.Text = "显示换流附近波形";
            this.toggleView_btn.UseVisualStyleBackColor = true;
            this.toggleView_btn.Click += new System.EventHandler(this.toggleView_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.viewNone_btn);
            this.groupBox1.Controls.Add(this.viewAll_btn);
            this.groupBox1.Controls.Add(this.checkBox11);
            this.groupBox1.Controls.Add(this.checkBox10);
            this.groupBox1.Controls.Add(this.checkBox9);
            this.groupBox1.Controls.Add(this.checkBox8);
            this.groupBox1.Controls.Add(this.checkBox7);
            this.groupBox1.Controls.Add(this.checkBox6);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(250, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 506);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选择要显示的波形";
            // 
            // viewNone_btn
            // 
            this.viewNone_btn.Enabled = false;
            this.viewNone_btn.Location = new System.Drawing.Point(166, 452);
            this.viewNone_btn.Name = "viewNone_btn";
            this.viewNone_btn.Size = new System.Drawing.Size(89, 38);
            this.viewNone_btn.TabIndex = 12;
            this.viewNone_btn.Text = "全不选";
            this.viewNone_btn.UseVisualStyleBackColor = true;
            this.viewNone_btn.Click += new System.EventHandler(this.viewNone_btn_Click);
            // 
            // viewAll_btn
            // 
            this.viewAll_btn.Enabled = false;
            this.viewAll_btn.Location = new System.Drawing.Point(71, 452);
            this.viewAll_btn.Name = "viewAll_btn";
            this.viewAll_btn.Size = new System.Drawing.Size(89, 38);
            this.viewAll_btn.TabIndex = 11;
            this.viewAll_btn.Text = "全选";
            this.viewAll_btn.UseVisualStyleBackColor = true;
            this.viewAll_btn.Click += new System.EventHandler(this.viewAll_btn_Click);
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Checked = true;
            this.checkBox11.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox11.Enabled = false;
            this.checkBox11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox11.Location = new System.Drawing.Point(6, 397);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(128, 24);
            this.checkBox11.TabIndex = 10;
            this.checkBox11.Text = "移能电阻_电流";
            this.checkBox11.UseVisualStyleBackColor = true;
            this.checkBox11.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Checked = true;
            this.checkBox10.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox10.Enabled = false;
            this.checkBox10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox10.Location = new System.Drawing.Point(6, 362);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(97, 24);
            this.checkBox10.TabIndex = 9;
            this.checkBox10.Text = "VCB_电流";
            this.checkBox10.UseVisualStyleBackColor = true;
            this.checkBox10.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Checked = true;
            this.checkBox9.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox9.Enabled = false;
            this.checkBox9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox9.Location = new System.Drawing.Point(6, 327);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(163, 24);
            this.checkBox9.TabIndex = 8;
            this.checkBox9.Text = "VCB/移能电阻_电压";
            this.checkBox9.UseVisualStyleBackColor = true;
            this.checkBox9.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Checked = true;
            this.checkBox8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox8.Enabled = false;
            this.checkBox8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox8.Location = new System.Drawing.Point(6, 292);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(191, 24);
            this.checkBox8.TabIndex = 7;
            this.checkBox8.Text = "模拟失超LC源_电感电压";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Checked = true;
            this.checkBox7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox7.Enabled = false;
            this.checkBox7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox7.Location = new System.Drawing.Point(6, 257);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(191, 24);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Text = "模拟失超LC源_电容电压";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Checked = true;
            this.checkBox6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox6.Enabled = false;
            this.checkBox6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox6.Location = new System.Drawing.Point(6, 222);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(113, 24);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "失超源_电流";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.Enabled = false;
            this.checkBox5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox5.Location = new System.Drawing.Point(6, 187);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(113, 24);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "失超源_电压";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Enabled = false;
            this.checkBox4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox4.Location = new System.Drawing.Point(6, 152);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(233, 24);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "过零电流提供回路_晶闸管电压";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Enabled = false;
            this.checkBox3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox3.Location = new System.Drawing.Point(6, 117);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(218, 24);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "过零电流提供回路_电感电压";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Enabled = false;
            this.checkBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox2.Location = new System.Drawing.Point(6, 82);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(218, 24);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "过零电流提供回路_电容电压";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Enabled = false;
            this.checkBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox1.Location = new System.Drawing.Point(6, 47);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(188, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "过零电流提供回路_电流";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // OpenRLC_btn
            // 
            this.OpenRLC_btn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OpenRLC_btn.Location = new System.Drawing.Point(1198, 644);
            this.OpenRLC_btn.Name = "OpenRLC_btn";
            this.OpenRLC_btn.Size = new System.Drawing.Size(203, 34);
            this.OpenRLC_btn.TabIndex = 16;
            this.OpenRLC_btn.Text = "工具——RLC参数计算";
            this.OpenRLC_btn.UseVisualStyleBackColor = true;
            this.OpenRLC_btn.Click += new System.EventHandler(this.OpenRLC_btn_Click);
            // 
            // saveToFile_btn
            // 
            this.saveToFile_btn.Enabled = false;
            this.saveToFile_btn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.saveToFile_btn.Location = new System.Drawing.Point(869, 644);
            this.saveToFile_btn.Name = "saveToFile_btn";
            this.saveToFile_btn.Size = new System.Drawing.Size(150, 34);
            this.saveToFile_btn.TabIndex = 17;
            this.saveToFile_btn.Text = "保存到文件(.csv)";
            this.saveToFile_btn.UseVisualStyleBackColor = true;
            this.saveToFile_btn.Click += new System.EventHandler(this.saveToFile_btn_Click);
            // 
            // OpenCmp_btn
            // 
            this.OpenCmp_btn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OpenCmp_btn.Location = new System.Drawing.Point(1418, 644);
            this.OpenCmp_btn.Name = "OpenCmp_btn";
            this.OpenCmp_btn.Size = new System.Drawing.Size(203, 34);
            this.OpenCmp_btn.TabIndex = 18;
            this.OpenCmp_btn.Text = "工具——波形比较工具";
            this.OpenCmp_btn.UseVisualStyleBackColor = true;
            this.OpenCmp_btn.Click += new System.EventHandler(this.OpenCmp_btn_Click);
            // 
            // ThyristorTime_TB
            // 
            this.ThyristorTime_TB.Location = new System.Drawing.Point(14, 233);
            this.ThyristorTime_TB.Name = "ThyristorTime_TB";
            this.ThyristorTime_TB.Size = new System.Drawing.Size(163, 31);
            this.ThyristorTime_TB.TabIndex = 29;
            this.ThyristorTime_TB.Text = "0.008";
            // 
            // ThyristorTime_Label
            // 
            this.ThyristorTime_Label.AutoSize = true;
            this.ThyristorTime_Label.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ThyristorTime_Label.Location = new System.Drawing.Point(14, 210);
            this.ThyristorTime_Label.Name = "ThyristorTime_Label";
            this.ThyristorTime_Label.Size = new System.Drawing.Size(131, 20);
            this.ThyristorTime_Label.TabIndex = 30;
            this.ThyristorTime_Label.Text = "晶闸管导通时间(s)";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1650, 703);
            this.Controls.Add(this.OpenCmp_btn);
            this.Controls.Add(this.saveToFile_btn);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.OpenRLC_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toggleView_btn);
            this.Controls.Add(this.StartSimulink_btn);
            this.Controls.Add(this.initInput);
            this.Controls.Add(this.TypeSelect);
            this.Controls.Add(this.chart4);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.Title);
            this.Name = "Main";
            this.Text = "失超保护开关的仿真_Demo";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.TypeSelect.ResumeLayout(false);
            this.TypeSelect.PerformLayout();
            this.initInput.ResumeLayout(false);
            this.initInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.GroupBox TypeSelect;
        private System.Windows.Forms.RadioButton TypeSelect_L;
        private System.Windows.Forms.GroupBox initInput;
        private System.Windows.Forms.TextBox VCB_C_TB;
        private System.Windows.Forms.Label VCB_C_Label;
        private System.Windows.Forms.TextBox Source_LorC_TB;
        private System.Windows.Forms.Label Source_LorC_Label;
        private System.Windows.Forms.Button StartSimulink_btn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.Button toggleView_btn;
        private System.Windows.Forms.RadioButton TypeSelect_LC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button viewAll_btn;
        private System.Windows.Forms.Button viewNone_btn;
        private System.Windows.Forms.TextBox Discharge_R_TB;
        private System.Windows.Forms.Label Discharge_R_Label;
        private System.Windows.Forms.Button OpenRLC_btn;
        private System.Windows.Forms.Button setDefault_btn;
        private System.Windows.Forms.Button applyDefault_btn;
        private System.Windows.Forms.Button saveToFile_btn;
        private System.Windows.Forms.Button OpenCmp_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ZeroCrossing_F_TB;
        private System.Windows.Forms.Label ZeroCrossing_F_Label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ZeroCrossing_L_TB;
        private System.Windows.Forms.Label ZeroCrossing_L_Label;
        private System.Windows.Forms.TextBox ZeroCrossing_C_TB;
        private System.Windows.Forms.Label ZeroCrossing_C_Label;
        private System.Windows.Forms.TextBox ThyristorTime_TB;
        private System.Windows.Forms.Label ThyristorTime_Label;
    }
}

