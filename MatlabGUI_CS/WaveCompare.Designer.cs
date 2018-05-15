namespace MatlabGUI_CS {
    partial class WaveCompare {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Wave2_tb = new System.Windows.Forms.TextBox();
            this.Wave1_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectCSVFile2_btn = new System.Windows.Forms.Button();
            this.SelectCSVFile1_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmpPeriod_TB = new System.Windows.Forms.TextBox();
            this.cmpPeriod_Label = new System.Windows.Forms.Label();
            this.cmpStartTime2_TB = new System.Windows.Forms.TextBox();
            this.cmpStartTime2_Label = new System.Windows.Forms.Label();
            this.cmpStartTime1_TB = new System.Windows.Forms.TextBox();
            this.cmpStartTime1_Label = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CmpCol_DGV = new System.Windows.Forms.DataGridView();
            this.StartCompare_btn = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toLeft_btn = new System.Windows.Forms.Button();
            this.toRight_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.wave1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wave2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmpCol_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(753, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "波形比较工具";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Wave2_tb);
            this.groupBox1.Controls.Add(this.Wave1_tb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SelectCSVFile2_btn);
            this.groupBox1.Controls.Add(this.SelectCSVFile1_btn);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(39, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 334);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "第一步：请选择波形文件（.csv）";
            // 
            // Wave2_tb
            // 
            this.Wave2_tb.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Wave2_tb.Location = new System.Drawing.Point(163, 143);
            this.Wave2_tb.Multiline = true;
            this.Wave2_tb.Name = "Wave2_tb";
            this.Wave2_tb.Size = new System.Drawing.Size(135, 173);
            this.Wave2_tb.TabIndex = 5;
            // 
            // Wave1_tb
            // 
            this.Wave1_tb.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Wave1_tb.Location = new System.Drawing.Point(13, 143);
            this.Wave1_tb.Multiline = true;
            this.Wave1_tb.Name = "Wave1_tb";
            this.Wave1_tb.Size = new System.Drawing.Size(135, 173);
            this.Wave1_tb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "已选择波形文件信息";
            // 
            // SelectCSVFile2_btn
            // 
            this.SelectCSVFile2_btn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SelectCSVFile2_btn.Location = new System.Drawing.Point(163, 50);
            this.SelectCSVFile2_btn.Name = "SelectCSVFile2_btn";
            this.SelectCSVFile2_btn.Size = new System.Drawing.Size(135, 49);
            this.SelectCSVFile2_btn.TabIndex = 4;
            this.SelectCSVFile2_btn.Text = "波形文件2";
            this.SelectCSVFile2_btn.UseVisualStyleBackColor = true;
            this.SelectCSVFile2_btn.Click += new System.EventHandler(this.SelectCSVFile_btn_Click);
            // 
            // SelectCSVFile1_btn
            // 
            this.SelectCSVFile1_btn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SelectCSVFile1_btn.Location = new System.Drawing.Point(13, 50);
            this.SelectCSVFile1_btn.Name = "SelectCSVFile1_btn";
            this.SelectCSVFile1_btn.Size = new System.Drawing.Size(135, 49);
            this.SelectCSVFile1_btn.TabIndex = 3;
            this.SelectCSVFile1_btn.Text = "波形文件1";
            this.SelectCSVFile1_btn.UseVisualStyleBackColor = true;
            this.SelectCSVFile1_btn.Click += new System.EventHandler(this.SelectCSVFile_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmpPeriod_TB);
            this.groupBox2.Controls.Add(this.cmpPeriod_Label);
            this.groupBox2.Controls.Add(this.cmpStartTime2_TB);
            this.groupBox2.Controls.Add(this.cmpStartTime2_Label);
            this.groupBox2.Controls.Add(this.cmpStartTime1_TB);
            this.groupBox2.Controls.Add(this.cmpStartTime1_Label);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(39, 427);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 280);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "第二步：请输入时间范围";
            // 
            // cmpPeriod_TB
            // 
            this.cmpPeriod_TB.Location = new System.Drawing.Point(29, 231);
            this.cmpPeriod_TB.Name = "cmpPeriod_TB";
            this.cmpPeriod_TB.Size = new System.Drawing.Size(203, 31);
            this.cmpPeriod_TB.TabIndex = 10;
            this.cmpPeriod_TB.Text = "0.0008";
            // 
            // cmpPeriod_Label
            // 
            this.cmpPeriod_Label.AutoSize = true;
            this.cmpPeriod_Label.Location = new System.Drawing.Point(24, 203);
            this.cmpPeriod_Label.Name = "cmpPeriod_Label";
            this.cmpPeriod_Label.Size = new System.Drawing.Size(88, 25);
            this.cmpPeriod_Label.TabIndex = 11;
            this.cmpPeriod_Label.Text = "持续时间";
            // 
            // cmpStartTime2_TB
            // 
            this.cmpStartTime2_TB.Location = new System.Drawing.Point(29, 155);
            this.cmpStartTime2_TB.Name = "cmpStartTime2_TB";
            this.cmpStartTime2_TB.Size = new System.Drawing.Size(203, 31);
            this.cmpStartTime2_TB.TabIndex = 8;
            this.cmpStartTime2_TB.Text = "0.0046";
            // 
            // cmpStartTime2_Label
            // 
            this.cmpStartTime2_Label.AutoSize = true;
            this.cmpStartTime2_Label.Location = new System.Drawing.Point(24, 127);
            this.cmpStartTime2_Label.Name = "cmpStartTime2_Label";
            this.cmpStartTime2_Label.Size = new System.Drawing.Size(181, 25);
            this.cmpStartTime2_Label.TabIndex = 9;
            this.cmpStartTime2_Label.Text = "波形文件2 起始时间";
            // 
            // cmpStartTime1_TB
            // 
            this.cmpStartTime1_TB.Location = new System.Drawing.Point(29, 78);
            this.cmpStartTime1_TB.Name = "cmpStartTime1_TB";
            this.cmpStartTime1_TB.Size = new System.Drawing.Size(203, 31);
            this.cmpStartTime1_TB.TabIndex = 7;
            this.cmpStartTime1_TB.Text = "0.0046";
            // 
            // cmpStartTime1_Label
            // 
            this.cmpStartTime1_Label.AutoSize = true;
            this.cmpStartTime1_Label.Location = new System.Drawing.Point(24, 50);
            this.cmpStartTime1_Label.Name = "cmpStartTime1_Label";
            this.cmpStartTime1_Label.Size = new System.Drawing.Size(181, 25);
            this.cmpStartTime1_Label.TabIndex = 7;
            this.cmpStartTime1_Label.Text = "波形文件1 起始时间";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.CmpCol_DGV);
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(369, 74);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(501, 567);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "第三步：请输入要比较的数据列";
            // 
            // CmpCol_DGV
            // 
            this.CmpCol_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CmpCol_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wave1,
            this.wave2,
            this.description,
            this.view});
            this.CmpCol_DGV.Location = new System.Drawing.Point(21, 50);
            this.CmpCol_DGV.Name = "CmpCol_DGV";
            this.CmpCol_DGV.RowTemplate.Height = 27;
            this.CmpCol_DGV.Size = new System.Drawing.Size(474, 378);
            this.CmpCol_DGV.TabIndex = 0;
            this.CmpCol_DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CmpCol_DGV_CellContentClick);
            // 
            // StartCompare_btn
            // 
            this.StartCompare_btn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StartCompare_btn.Location = new System.Drawing.Point(655, 647);
            this.StartCompare_btn.Name = "StartCompare_btn";
            this.StartCompare_btn.Size = new System.Drawing.Size(185, 55);
            this.StartCompare_btn.TabIndex = 11;
            this.StartCompare_btn.Text = "开始比较";
            this.StartCompare_btn.UseVisualStyleBackColor = true;
            this.StartCompare_btn.Click += new System.EventHandler(this.StartCompare_btn_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(891, 74);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(859, 557);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            title1.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "title1";
            title1.Text = "定位用Chart";
            this.chart1.Titles.Add(title1);
            this.chart1.Visible = false;
            // 
            // toLeft_btn
            // 
            this.toLeft_btn.Enabled = false;
            this.toLeft_btn.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toLeft_btn.Location = new System.Drawing.Point(1228, 652);
            this.toLeft_btn.Name = "toLeft_btn";
            this.toLeft_btn.Size = new System.Drawing.Size(83, 38);
            this.toLeft_btn.TabIndex = 13;
            this.toLeft_btn.Text = "<";
            this.toLeft_btn.UseVisualStyleBackColor = true;
            this.toLeft_btn.Click += new System.EventHandler(this.toLeft_btn_Click);
            // 
            // toRight_btn
            // 
            this.toRight_btn.Enabled = false;
            this.toRight_btn.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toRight_btn.Location = new System.Drawing.Point(1378, 654);
            this.toRight_btn.Name = "toRight_btn";
            this.toRight_btn.Size = new System.Drawing.Size(83, 38);
            this.toRight_btn.TabIndex = 14;
            this.toRight_btn.Text = ">";
            this.toRight_btn.UseVisualStyleBackColor = true;
            this.toRight_btn.Click += new System.EventHandler(this.toRight_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "注意事项：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(16, 480);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(388, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "1. 进行比较的将是除最后一行之外的所有行，最后一行请留空";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(17, 508);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(480, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "2. 删除多余行的方法是在非编辑状态下，选中要删除的行之后，按 delete 键";
            // 
            // wave1
            // 
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.wave1.DefaultCellStyle = dataGridViewCellStyle1;
            this.wave1.HeaderText = "文件1";
            this.wave1.Name = "wave1";
            this.wave1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.wave1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.wave1.Width = 80;
            // 
            // wave2
            // 
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.wave2.DefaultCellStyle = dataGridViewCellStyle2;
            this.wave2.HeaderText = "文件2";
            this.wave2.Name = "wave2";
            this.wave2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.wave2.Width = 80;
            // 
            // description
            // 
            this.description.HeaderText = "描述(可选)";
            this.description.Name = "description";
            this.description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.description.Width = 160;
            // 
            // view
            // 
            this.view.HeaderText = "显示";
            this.view.Name = "view";
            this.view.Text = "显示";
            this.view.Visible = false;
            this.view.Width = 80;
            // 
            // WaveCompare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1774, 719);
            this.Controls.Add(this.toRight_btn);
            this.Controls.Add(this.toLeft_btn);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.StartCompare_btn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "WaveCompare";
            this.Text = "WaveCompare";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmpCol_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SelectCSVFile2_btn;
        private System.Windows.Forms.Button SelectCSVFile1_btn;
        private System.Windows.Forms.TextBox Wave1_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Wave2_tb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox cmpStartTime2_TB;
        private System.Windows.Forms.Label cmpStartTime2_Label;
        private System.Windows.Forms.TextBox cmpStartTime1_TB;
        private System.Windows.Forms.Label cmpStartTime1_Label;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView CmpCol_DGV;
        private System.Windows.Forms.TextBox cmpPeriod_TB;
        private System.Windows.Forms.Label cmpPeriod_Label;
        private System.Windows.Forms.Button StartCompare_btn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button toLeft_btn;
        private System.Windows.Forms.Button toRight_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn wave1;
        private System.Windows.Forms.DataGridViewTextBoxColumn wave2;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewButtonColumn view;
    }
}