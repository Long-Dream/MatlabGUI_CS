namespace MatlabGUI_CS {
    partial class RLC_Compute {
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
            this.label1 = new System.Windows.Forms.Label();
            this.RLC_GB = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RLC_Result_TB = new System.Windows.Forms.TextBox();
            this.RLC_L_init_TB = new System.Windows.Forms.TextBox();
            this.RLC_L_init = new System.Windows.Forms.Label();
            this.RLC_C_init_TB = new System.Windows.Forms.TextBox();
            this.RLC_C_init = new System.Windows.Forms.Label();
            this.RLC_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.StartCompute_btn = new System.Windows.Forms.Button();
            this.RLC_C_TB = new System.Windows.Forms.TextBox();
            this.RLC_C = new System.Windows.Forms.Label();
            this.RLC_L_TB = new System.Windows.Forms.TextBox();
            this.RLC_L = new System.Windows.Forms.Label();
            this.RLC_R_TB = new System.Windows.Forms.TextBox();
            this.RLC_R = new System.Windows.Forms.Label();
            this.RLC_GB2 = new System.Windows.Forms.GroupBox();
            this.RLC_Result2_TB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RLC_C_init2_TB = new System.Windows.Forms.TextBox();
            this.RLC_C_init2 = new System.Windows.Forms.Label();
            this.StartCompute2_btn = new System.Windows.Forms.Button();
            this.RLC_Im_TB = new System.Windows.Forms.TextBox();
            this.RLC_F = new System.Windows.Forms.Label();
            this.RLC_Im = new System.Windows.Forms.Label();
            this.RLC_F_TB = new System.Windows.Forms.TextBox();
            this.RLC_GB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RLC_Chart)).BeginInit();
            this.RLC_GB2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(437, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "RLC振荡回路 参数计算工具";
            // 
            // RLC_GB
            // 
            this.RLC_GB.Controls.Add(this.label2);
            this.RLC_GB.Controls.Add(this.RLC_Result_TB);
            this.RLC_GB.Controls.Add(this.RLC_L_init_TB);
            this.RLC_GB.Controls.Add(this.RLC_L_init);
            this.RLC_GB.Controls.Add(this.RLC_C_init_TB);
            this.RLC_GB.Controls.Add(this.RLC_C_init);
            this.RLC_GB.Controls.Add(this.RLC_Chart);
            this.RLC_GB.Controls.Add(this.StartCompute_btn);
            this.RLC_GB.Controls.Add(this.RLC_C_TB);
            this.RLC_GB.Controls.Add(this.RLC_C);
            this.RLC_GB.Controls.Add(this.RLC_L_TB);
            this.RLC_GB.Controls.Add(this.RLC_L);
            this.RLC_GB.Controls.Add(this.RLC_R_TB);
            this.RLC_GB.Controls.Add(this.RLC_R);
            this.RLC_GB.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RLC_GB.Location = new System.Drawing.Point(32, 114);
            this.RLC_GB.Name = "RLC_GB";
            this.RLC_GB.Size = new System.Drawing.Size(1082, 556);
            this.RLC_GB.TabIndex = 0;
            this.RLC_GB.TabStop = false;
            this.RLC_GB.Text = "已知RLC的计算";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(773, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "具体数据";
            // 
            // RLC_Result_TB
            // 
            this.RLC_Result_TB.Location = new System.Drawing.Point(778, 58);
            this.RLC_Result_TB.Multiline = true;
            this.RLC_Result_TB.Name = "RLC_Result_TB";
            this.RLC_Result_TB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RLC_Result_TB.Size = new System.Drawing.Size(283, 460);
            this.RLC_Result_TB.TabIndex = 28;
            // 
            // RLC_L_init_TB
            // 
            this.RLC_L_init_TB.Location = new System.Drawing.Point(24, 315);
            this.RLC_L_init_TB.Name = "RLC_L_init_TB";
            this.RLC_L_init_TB.Size = new System.Drawing.Size(163, 31);
            this.RLC_L_init_TB.TabIndex = 4;
            this.RLC_L_init_TB.Text = "0";
            // 
            // RLC_L_init
            // 
            this.RLC_L_init.AutoSize = true;
            this.RLC_L_init.Location = new System.Drawing.Point(19, 287);
            this.RLC_L_init.Name = "RLC_L_init";
            this.RLC_L_init.Size = new System.Drawing.Size(160, 25);
            this.RLC_L_init.TabIndex = 26;
            this.RLC_L_init.Text = "电感_初始电流(A)";
            // 
            // RLC_C_init_TB
            // 
            this.RLC_C_init_TB.Location = new System.Drawing.Point(24, 396);
            this.RLC_C_init_TB.Name = "RLC_C_init_TB";
            this.RLC_C_init_TB.Size = new System.Drawing.Size(163, 31);
            this.RLC_C_init_TB.TabIndex = 5;
            this.RLC_C_init_TB.Text = "10000";
            // 
            // RLC_C_init
            // 
            this.RLC_C_init.AutoSize = true;
            this.RLC_C_init.Location = new System.Drawing.Point(19, 368);
            this.RLC_C_init.Name = "RLC_C_init";
            this.RLC_C_init.Size = new System.Drawing.Size(160, 25);
            this.RLC_C_init.TabIndex = 24;
            this.RLC_C_init.Text = "电容_初始电压(V)";
            // 
            // RLC_Chart
            // 
            chartArea1.Name = "ChartArea1";
            this.RLC_Chart.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.RLC_Chart.Legends.Add(legend1);
            this.RLC_Chart.Location = new System.Drawing.Point(208, 30);
            this.RLC_Chart.Name = "RLC_Chart";
            this.RLC_Chart.Size = new System.Drawing.Size(549, 488);
            this.RLC_Chart.TabIndex = 21;
            this.RLC_Chart.Text = "RLC_Chart";
            // 
            // StartCompute_btn
            // 
            this.StartCompute_btn.Location = new System.Drawing.Point(24, 463);
            this.StartCompute_btn.Name = "StartCompute_btn";
            this.StartCompute_btn.Size = new System.Drawing.Size(163, 55);
            this.StartCompute_btn.TabIndex = 6;
            this.StartCompute_btn.Text = "开始计算";
            this.StartCompute_btn.UseVisualStyleBackColor = true;
            this.StartCompute_btn.Click += new System.EventHandler(this.StartCompute_btn_Click);
            // 
            // RLC_C_TB
            // 
            this.RLC_C_TB.Location = new System.Drawing.Point(24, 234);
            this.RLC_C_TB.Name = "RLC_C_TB";
            this.RLC_C_TB.Size = new System.Drawing.Size(163, 31);
            this.RLC_C_TB.TabIndex = 3;
            this.RLC_C_TB.Text = "0.53";
            // 
            // RLC_C
            // 
            this.RLC_C.AutoSize = true;
            this.RLC_C.Location = new System.Drawing.Point(19, 206);
            this.RLC_C.Name = "RLC_C";
            this.RLC_C.Size = new System.Drawing.Size(72, 25);
            this.RLC_C.TabIndex = 18;
            this.RLC_C.Text = "电容(F)";
            // 
            // RLC_L_TB
            // 
            this.RLC_L_TB.Location = new System.Drawing.Point(24, 154);
            this.RLC_L_TB.Name = "RLC_L_TB";
            this.RLC_L_TB.Size = new System.Drawing.Size(163, 31);
            this.RLC_L_TB.TabIndex = 2;
            this.RLC_L_TB.Text = "1";
            // 
            // RLC_L
            // 
            this.RLC_L.AutoSize = true;
            this.RLC_L.Location = new System.Drawing.Point(19, 126);
            this.RLC_L.Name = "RLC_L";
            this.RLC_L.Size = new System.Drawing.Size(77, 25);
            this.RLC_L.TabIndex = 16;
            this.RLC_L.Text = "电感(H)";
            // 
            // RLC_R_TB
            // 
            this.RLC_R_TB.Location = new System.Drawing.Point(24, 74);
            this.RLC_R_TB.Name = "RLC_R_TB";
            this.RLC_R_TB.Size = new System.Drawing.Size(163, 31);
            this.RLC_R_TB.TabIndex = 1;
            this.RLC_R_TB.Text = "0.1";
            // 
            // RLC_R
            // 
            this.RLC_R.AutoSize = true;
            this.RLC_R.Location = new System.Drawing.Point(19, 46);
            this.RLC_R.Name = "RLC_R";
            this.RLC_R.Size = new System.Drawing.Size(78, 25);
            this.RLC_R.TabIndex = 14;
            this.RLC_R.Text = "电阻(Ω)";
            // 
            // RLC_GB2
            // 
            this.RLC_GB2.Controls.Add(this.RLC_Result2_TB);
            this.RLC_GB2.Controls.Add(this.label3);
            this.RLC_GB2.Controls.Add(this.RLC_C_init2_TB);
            this.RLC_GB2.Controls.Add(this.RLC_C_init2);
            this.RLC_GB2.Controls.Add(this.StartCompute2_btn);
            this.RLC_GB2.Controls.Add(this.RLC_Im_TB);
            this.RLC_GB2.Controls.Add(this.RLC_F);
            this.RLC_GB2.Controls.Add(this.RLC_Im);
            this.RLC_GB2.Controls.Add(this.RLC_F_TB);
            this.RLC_GB2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RLC_GB2.Location = new System.Drawing.Point(1129, 114);
            this.RLC_GB2.Name = "RLC_GB2";
            this.RLC_GB2.Size = new System.Drawing.Size(308, 556);
            this.RLC_GB2.TabIndex = 30;
            this.RLC_GB2.TabStop = false;
            this.RLC_GB2.Text = "未知LC的计算";
            // 
            // RLC_Result2_TB
            // 
            this.RLC_Result2_TB.Location = new System.Drawing.Point(25, 396);
            this.RLC_Result2_TB.Multiline = true;
            this.RLC_Result2_TB.Name = "RLC_Result2_TB";
            this.RLC_Result2_TB.Size = new System.Drawing.Size(261, 122);
            this.RLC_Result2_TB.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 34;
            this.label3.Text = "计算结果";
            // 
            // RLC_C_init2_TB
            // 
            this.RLC_C_init2_TB.Location = new System.Drawing.Point(27, 234);
            this.RLC_C_init2_TB.Name = "RLC_C_init2_TB";
            this.RLC_C_init2_TB.Size = new System.Drawing.Size(259, 31);
            this.RLC_C_init2_TB.TabIndex = 2;
            this.RLC_C_init2_TB.Text = "10000";
            // 
            // RLC_C_init2
            // 
            this.RLC_C_init2.AutoSize = true;
            this.RLC_C_init2.Location = new System.Drawing.Point(22, 206);
            this.RLC_C_init2.Name = "RLC_C_init2";
            this.RLC_C_init2.Size = new System.Drawing.Size(160, 25);
            this.RLC_C_init2.TabIndex = 30;
            this.RLC_C_init2.Text = "电容_初始电压(V)";
            // 
            // StartCompute2_btn
            // 
            this.StartCompute2_btn.Location = new System.Drawing.Point(25, 287);
            this.StartCompute2_btn.Name = "StartCompute2_btn";
            this.StartCompute2_btn.Size = new System.Drawing.Size(261, 45);
            this.StartCompute2_btn.TabIndex = 3;
            this.StartCompute2_btn.Text = "开始计算";
            this.StartCompute2_btn.UseVisualStyleBackColor = true;
            this.StartCompute2_btn.Click += new System.EventHandler(this.StartCompute2_btn_Click);
            // 
            // RLC_Im_TB
            // 
            this.RLC_Im_TB.Location = new System.Drawing.Point(25, 154);
            this.RLC_Im_TB.Name = "RLC_Im_TB";
            this.RLC_Im_TB.Size = new System.Drawing.Size(261, 31);
            this.RLC_Im_TB.TabIndex = 1;
            this.RLC_Im_TB.Text = "1";
            // 
            // RLC_F
            // 
            this.RLC_F.AutoSize = true;
            this.RLC_F.Location = new System.Drawing.Point(20, 46);
            this.RLC_F.Name = "RLC_F";
            this.RLC_F.Size = new System.Drawing.Size(86, 25);
            this.RLC_F.TabIndex = 30;
            this.RLC_F.Text = "频率(Hz)";
            // 
            // RLC_Im
            // 
            this.RLC_Im.AutoSize = true;
            this.RLC_Im.Location = new System.Drawing.Point(20, 126);
            this.RLC_Im.Name = "RLC_Im";
            this.RLC_Im.Size = new System.Drawing.Size(132, 25);
            this.RLC_Im.TabIndex = 32;
            this.RLC_Im.Text = "最大电流值(A)";
            // 
            // RLC_F_TB
            // 
            this.RLC_F_TB.Location = new System.Drawing.Point(25, 74);
            this.RLC_F_TB.Name = "RLC_F_TB";
            this.RLC_F_TB.Size = new System.Drawing.Size(261, 31);
            this.RLC_F_TB.TabIndex = 0;
            this.RLC_F_TB.Text = "0.1";
            // 
            // RLC_Compute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 715);
            this.Controls.Add(this.RLC_GB2);
            this.Controls.Add(this.RLC_GB);
            this.Controls.Add(this.label1);
            this.Name = "RLC_Compute";
            this.Text = "RLC振荡回路 参数计算工具";
            this.RLC_GB.ResumeLayout(false);
            this.RLC_GB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RLC_Chart)).EndInit();
            this.RLC_GB2.ResumeLayout(false);
            this.RLC_GB2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox RLC_GB;
        private System.Windows.Forms.TextBox RLC_R_TB;
        private System.Windows.Forms.Label RLC_R;
        private System.Windows.Forms.TextBox RLC_C_TB;
        private System.Windows.Forms.Label RLC_C;
        private System.Windows.Forms.TextBox RLC_L_TB;
        private System.Windows.Forms.Label RLC_L;
        private System.Windows.Forms.Button StartCompute_btn;
        private System.Windows.Forms.DataVisualization.Charting.Chart RLC_Chart;
        private System.Windows.Forms.TextBox RLC_L_init_TB;
        private System.Windows.Forms.Label RLC_L_init;
        private System.Windows.Forms.TextBox RLC_C_init_TB;
        private System.Windows.Forms.Label RLC_C_init;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RLC_Result_TB;
        private System.Windows.Forms.GroupBox RLC_GB2;
        private System.Windows.Forms.TextBox RLC_C_init2_TB;
        private System.Windows.Forms.Label RLC_C_init2;
        private System.Windows.Forms.Button StartCompute2_btn;
        private System.Windows.Forms.TextBox RLC_Im_TB;
        private System.Windows.Forms.Label RLC_F;
        private System.Windows.Forms.Label RLC_Im;
        private System.Windows.Forms.TextBox RLC_F_TB;
        private System.Windows.Forms.TextBox RLC_Result2_TB;
        private System.Windows.Forms.Label label3;
    }
}