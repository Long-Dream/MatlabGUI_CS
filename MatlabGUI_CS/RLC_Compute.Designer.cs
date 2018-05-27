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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RLC2_Im2_TB = new System.Windows.Forms.TextBox();
            this.RLC2_Im2 = new System.Windows.Forms.Label();
            this.RLC_Result3_TB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RLC2_C_TB = new System.Windows.Forms.TextBox();
            this.RLC2_C = new System.Windows.Forms.Label();
            this.StartCompute3_btn = new System.Windows.Forms.Button();
            this.RLC2_Im1_TB = new System.Windows.Forms.TextBox();
            this.RLC2_T = new System.Windows.Forms.Label();
            this.RLC2_Im1 = new System.Windows.Forms.Label();
            this.RLC2_T_TB = new System.Windows.Forms.TextBox();
            this.RLC_GB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RLC_Chart)).BeginInit();
            this.RLC_GB2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(602, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "RLC电路 参数计算工具";
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
            this.RLC_GB.Text = "RLC——参数已知";
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
            chartArea2.Name = "ChartArea1";
            this.RLC_Chart.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.Name = "Legend1";
            this.RLC_Chart.Legends.Add(legend2);
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
            this.RLC_GB2.Size = new System.Drawing.Size(285, 556);
            this.RLC_GB2.TabIndex = 30;
            this.RLC_GB2.TabStop = false;
            this.RLC_GB2.Text = "LC——参数未知";
            // 
            // RLC_Result2_TB
            // 
            this.RLC_Result2_TB.Location = new System.Drawing.Point(25, 396);
            this.RLC_Result2_TB.Multiline = true;
            this.RLC_Result2_TB.Name = "RLC_Result2_TB";
            this.RLC_Result2_TB.Size = new System.Drawing.Size(244, 122);
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
            this.RLC_C_init2_TB.Size = new System.Drawing.Size(222, 31);
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
            this.StartCompute2_btn.Location = new System.Drawing.Point(25, 308);
            this.StartCompute2_btn.Name = "StartCompute2_btn";
            this.StartCompute2_btn.Size = new System.Drawing.Size(224, 45);
            this.StartCompute2_btn.TabIndex = 3;
            this.StartCompute2_btn.Text = "开始计算";
            this.StartCompute2_btn.UseVisualStyleBackColor = true;
            this.StartCompute2_btn.Click += new System.EventHandler(this.StartCompute2_btn_Click);
            // 
            // RLC_Im_TB
            // 
            this.RLC_Im_TB.Location = new System.Drawing.Point(25, 154);
            this.RLC_Im_TB.Name = "RLC_Im_TB";
            this.RLC_Im_TB.Size = new System.Drawing.Size(224, 31);
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
            this.RLC_F_TB.Size = new System.Drawing.Size(224, 31);
            this.RLC_F_TB.TabIndex = 0;
            this.RLC_F_TB.Text = "0.1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RLC2_Im2_TB);
            this.groupBox1.Controls.Add(this.RLC2_Im2);
            this.groupBox1.Controls.Add(this.RLC_Result3_TB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.RLC2_C_TB);
            this.groupBox1.Controls.Add(this.RLC2_C);
            this.groupBox1.Controls.Add(this.StartCompute3_btn);
            this.groupBox1.Controls.Add(this.RLC2_Im1_TB);
            this.groupBox1.Controls.Add(this.RLC2_T);
            this.groupBox1.Controls.Add(this.RLC2_Im1);
            this.groupBox1.Controls.Add(this.RLC2_T_TB);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(1430, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 556);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RLC——参数未知";
            // 
            // RLC2_Im2_TB
            // 
            this.RLC2_Im2_TB.Location = new System.Drawing.Point(24, 256);
            this.RLC2_Im2_TB.Name = "RLC2_Im2_TB";
            this.RLC2_Im2_TB.Size = new System.Drawing.Size(224, 31);
            this.RLC2_Im2_TB.TabIndex = 7;
            // 
            // RLC2_Im2
            // 
            this.RLC2_Im2.AutoSize = true;
            this.RLC2_Im2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RLC2_Im2.Location = new System.Drawing.Point(24, 233);
            this.RLC2_Im2.Name = "RLC2_Im2";
            this.RLC2_Im2.Size = new System.Drawing.Size(120, 20);
            this.RLC2_Im2.TabIndex = 37;
            this.RLC2_Im2.Text = "电流第二峰值(A)";
            // 
            // RLC_Result3_TB
            // 
            this.RLC_Result3_TB.Location = new System.Drawing.Point(21, 396);
            this.RLC_Result3_TB.Multiline = true;
            this.RLC_Result3_TB.Name = "RLC_Result3_TB";
            this.RLC_Result3_TB.Size = new System.Drawing.Size(243, 125);
            this.RLC_Result3_TB.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(16, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "计算结果";
            // 
            // RLC2_C_TB
            // 
            this.RLC2_C_TB.Location = new System.Drawing.Point(24, 58);
            this.RLC2_C_TB.Name = "RLC2_C_TB";
            this.RLC2_C_TB.Size = new System.Drawing.Size(224, 31);
            this.RLC2_C_TB.TabIndex = 4;
            this.RLC2_C_TB.Text = "40";
            // 
            // RLC2_C
            // 
            this.RLC2_C.AutoSize = true;
            this.RLC2_C.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RLC2_C.Location = new System.Drawing.Point(24, 35);
            this.RLC2_C.Name = "RLC2_C";
            this.RLC2_C.Size = new System.Drawing.Size(71, 20);
            this.RLC2_C.TabIndex = 30;
            this.RLC2_C.Text = "电容(mF)";
            // 
            // StartCompute3_btn
            // 
            this.StartCompute3_btn.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StartCompute3_btn.Location = new System.Drawing.Point(21, 308);
            this.StartCompute3_btn.Name = "StartCompute3_btn";
            this.StartCompute3_btn.Size = new System.Drawing.Size(224, 45);
            this.StartCompute3_btn.TabIndex = 8;
            this.StartCompute3_btn.Text = "开始计算";
            this.StartCompute3_btn.UseVisualStyleBackColor = true;
            this.StartCompute3_btn.Click += new System.EventHandler(this.StartCompute3_btn_Click);
            // 
            // RLC2_Im1_TB
            // 
            this.RLC2_Im1_TB.Location = new System.Drawing.Point(24, 189);
            this.RLC2_Im1_TB.Name = "RLC2_Im1_TB";
            this.RLC2_Im1_TB.Size = new System.Drawing.Size(224, 31);
            this.RLC2_Im1_TB.TabIndex = 6;
            // 
            // RLC2_T
            // 
            this.RLC2_T.AutoSize = true;
            this.RLC2_T.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RLC2_T.Location = new System.Drawing.Point(24, 101);
            this.RLC2_T.Name = "RLC2_T";
            this.RLC2_T.Size = new System.Drawing.Size(70, 20);
            this.RLC2_T.TabIndex = 30;
            this.RLC2_T.Text = "周期(ms)";
            // 
            // RLC2_Im1
            // 
            this.RLC2_Im1.AutoSize = true;
            this.RLC2_Im1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RLC2_Im1.Location = new System.Drawing.Point(24, 166);
            this.RLC2_Im1.Name = "RLC2_Im1";
            this.RLC2_Im1.Size = new System.Drawing.Size(120, 20);
            this.RLC2_Im1.TabIndex = 32;
            this.RLC2_Im1.Text = "电流第一峰值(A)";
            // 
            // RLC2_T_TB
            // 
            this.RLC2_T_TB.Location = new System.Drawing.Point(24, 124);
            this.RLC2_T_TB.Name = "RLC2_T_TB";
            this.RLC2_T_TB.Size = new System.Drawing.Size(224, 31);
            this.RLC2_T_TB.TabIndex = 5;
            // 
            // RLC_Compute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1777, 715);
            this.Controls.Add(this.groupBox1);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox RLC2_Im2_TB;
        private System.Windows.Forms.Label RLC2_Im2;
        private System.Windows.Forms.TextBox RLC_Result3_TB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RLC2_C_TB;
        private System.Windows.Forms.Label RLC2_C;
        private System.Windows.Forms.Button StartCompute3_btn;
        private System.Windows.Forms.TextBox RLC2_Im1_TB;
        private System.Windows.Forms.Label RLC2_T;
        private System.Windows.Forms.Label RLC2_Im1;
        private System.Windows.Forms.TextBox RLC2_T_TB;
    }
}