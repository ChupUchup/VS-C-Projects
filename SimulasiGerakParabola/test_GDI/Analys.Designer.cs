namespace test_GDI
{
    partial class Analys
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.list_data = new System.Windows.Forms.ListBox();
            this.btn_load = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel_select = new System.Windows.Forms.Panel();
            this.panel_y = new System.Windows.Forms.Panel();
            this.lbl_y = new System.Windows.Forms.Label();
            this.rd_y_yMax = new System.Windows.Forms.RadioButton();
            this.rd_y_sudut = new System.Windows.Forms.RadioButton();
            this.rd_y_xMax = new System.Windows.Forms.RadioButton();
            this.rd_y_v = new System.Windows.Forms.RadioButton();
            this.rd_y_tMax = new System.Windows.Forms.RadioButton();
            this.rd_y_g = new System.Windows.Forms.RadioButton();
            this.panel_x = new System.Windows.Forms.Panel();
            this.lbl_x = new System.Windows.Forms.Label();
            this.rd_x_yMax = new System.Windows.Forms.RadioButton();
            this.rd_x_xMax = new System.Windows.Forms.RadioButton();
            this.rd_x_tMax = new System.Windows.Forms.RadioButton();
            this.rd_x_g = new System.Windows.Forms.RadioButton();
            this.rd_x_v = new System.Windows.Forms.RadioButton();
            this.rd_x_sudut = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel_select.SuspendLayout();
            this.panel_y.SuspendLayout();
            this.panel_x.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.list_data);
            this.panel1.Controls.Add(this.btn_load);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 64);
            this.panel1.TabIndex = 0;
            // 
            // list_data
            // 
            this.list_data.FormattingEnabled = true;
            this.list_data.Location = new System.Drawing.Point(614, 3);
            this.list_data.Name = "list_data";
            this.list_data.Size = new System.Drawing.Size(443, 56);
            this.list_data.TabIndex = 1;
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(3, 3);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 54);
            this.btn_load.TabIndex = 0;
            this.btn_load.Text = "Load Data";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // chart1
            // 
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 82);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1084, 647);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // panel_select
            // 
            this.panel_select.Controls.Add(this.panel_y);
            this.panel_select.Controls.Add(this.panel_x);
            this.panel_select.Location = new System.Drawing.Point(96, 12);
            this.panel_select.Name = "panel_select";
            this.panel_select.Size = new System.Drawing.Size(524, 64);
            this.panel_select.TabIndex = 1;
            // 
            // panel_y
            // 
            this.panel_y.Controls.Add(this.lbl_y);
            this.panel_y.Controls.Add(this.rd_y_yMax);
            this.panel_y.Controls.Add(this.rd_y_sudut);
            this.panel_y.Controls.Add(this.rd_y_xMax);
            this.panel_y.Controls.Add(this.rd_y_v);
            this.panel_y.Controls.Add(this.rd_y_tMax);
            this.panel_y.Controls.Add(this.rd_y_g);
            this.panel_y.Location = new System.Drawing.Point(3, 33);
            this.panel_y.Name = "panel_y";
            this.panel_y.Size = new System.Drawing.Size(505, 24);
            this.panel_y.TabIndex = 0;
            // 
            // lbl_y
            // 
            this.lbl_y.AutoSize = true;
            this.lbl_y.Location = new System.Drawing.Point(3, 7);
            this.lbl_y.Name = "lbl_y";
            this.lbl_y.Size = new System.Drawing.Size(42, 13);
            this.lbl_y.TabIndex = 1;
            this.lbl_y.Text = "Pilih Y :";
            // 
            // rd_y_yMax
            // 
            this.rd_y_yMax.AutoSize = true;
            this.rd_y_yMax.Location = new System.Drawing.Point(444, 5);
            this.rd_y_yMax.Name = "rd_y_yMax";
            this.rd_y_yMax.Size = new System.Drawing.Size(50, 17);
            this.rd_y_yMax.TabIndex = 0;
            this.rd_y_yMax.Text = "yMax";
            this.rd_y_yMax.UseVisualStyleBackColor = true;
            this.rd_y_yMax.Click += new System.EventHandler(this.rd_y_sudut_Click);
            // 
            // rd_y_sudut
            // 
            this.rd_y_sudut.AutoSize = true;
            this.rd_y_sudut.Location = new System.Drawing.Point(51, 5);
            this.rd_y_sudut.Name = "rd_y_sudut";
            this.rd_y_sudut.Size = new System.Drawing.Size(77, 17);
            this.rd_y_sudut.TabIndex = 0;
            this.rd_y_sudut.Text = "Sudut ( ∝ )";
            this.rd_y_sudut.UseVisualStyleBackColor = true;
            this.rd_y_sudut.Click += new System.EventHandler(this.rd_y_sudut_Click);
            // 
            // rd_y_xMax
            // 
            this.rd_y_xMax.AutoSize = true;
            this.rd_y_xMax.Checked = true;
            this.rd_y_xMax.Location = new System.Drawing.Point(388, 5);
            this.rd_y_xMax.Name = "rd_y_xMax";
            this.rd_y_xMax.Size = new System.Drawing.Size(50, 17);
            this.rd_y_xMax.TabIndex = 0;
            this.rd_y_xMax.TabStop = true;
            this.rd_y_xMax.Text = "xMax";
            this.rd_y_xMax.UseVisualStyleBackColor = true;
            this.rd_y_xMax.Click += new System.EventHandler(this.rd_y_sudut_Click);
            // 
            // rd_y_v
            // 
            this.rd_y_v.AutoSize = true;
            this.rd_y_v.Location = new System.Drawing.Point(134, 5);
            this.rd_y_v.Name = "rd_y_v";
            this.rd_y_v.Size = new System.Drawing.Size(98, 17);
            this.rd_y_v.TabIndex = 0;
            this.rd_y_v.Text = "Kecepatan ( v )";
            this.rd_y_v.UseVisualStyleBackColor = true;
            this.rd_y_v.Click += new System.EventHandler(this.rd_y_sudut_Click);
            // 
            // rd_y_tMax
            // 
            this.rd_y_tMax.AutoSize = true;
            this.rd_y_tMax.Location = new System.Drawing.Point(331, 4);
            this.rd_y_tMax.Name = "rd_y_tMax";
            this.rd_y_tMax.Size = new System.Drawing.Size(51, 17);
            this.rd_y_tMax.TabIndex = 0;
            this.rd_y_tMax.Text = "t Max";
            this.rd_y_tMax.UseVisualStyleBackColor = true;
            this.rd_y_tMax.Click += new System.EventHandler(this.rd_y_sudut_Click);
            // 
            // rd_y_g
            // 
            this.rd_y_g.AutoSize = true;
            this.rd_y_g.Location = new System.Drawing.Point(238, 4);
            this.rd_y_g.Name = "rd_y_g";
            this.rd_y_g.Size = new System.Drawing.Size(87, 17);
            this.rd_y_g.TabIndex = 0;
            this.rd_y_g.Text = "Gravitasi ( g )";
            this.rd_y_g.UseVisualStyleBackColor = true;
            this.rd_y_g.Click += new System.EventHandler(this.rd_y_sudut_Click);
            // 
            // panel_x
            // 
            this.panel_x.Controls.Add(this.lbl_x);
            this.panel_x.Controls.Add(this.rd_x_yMax);
            this.panel_x.Controls.Add(this.rd_x_xMax);
            this.panel_x.Controls.Add(this.rd_x_tMax);
            this.panel_x.Controls.Add(this.rd_x_g);
            this.panel_x.Controls.Add(this.rd_x_v);
            this.panel_x.Controls.Add(this.rd_x_sudut);
            this.panel_x.Location = new System.Drawing.Point(3, 3);
            this.panel_x.Name = "panel_x";
            this.panel_x.Size = new System.Drawing.Size(505, 24);
            this.panel_x.TabIndex = 0;
            // 
            // lbl_x
            // 
            this.lbl_x.AutoSize = true;
            this.lbl_x.Location = new System.Drawing.Point(3, 4);
            this.lbl_x.Name = "lbl_x";
            this.lbl_x.Size = new System.Drawing.Size(42, 13);
            this.lbl_x.TabIndex = 1;
            this.lbl_x.Text = "Pilih X :";
            // 
            // rd_x_yMax
            // 
            this.rd_x_yMax.AutoSize = true;
            this.rd_x_yMax.Location = new System.Drawing.Point(444, 4);
            this.rd_x_yMax.Name = "rd_x_yMax";
            this.rd_x_yMax.Size = new System.Drawing.Size(50, 17);
            this.rd_x_yMax.TabIndex = 0;
            this.rd_x_yMax.Text = "yMax";
            this.rd_x_yMax.UseVisualStyleBackColor = true;
            this.rd_x_yMax.Click += new System.EventHandler(this.rd_x_sudut_Click);
            // 
            // rd_x_xMax
            // 
            this.rd_x_xMax.AutoSize = true;
            this.rd_x_xMax.Location = new System.Drawing.Point(388, 4);
            this.rd_x_xMax.Name = "rd_x_xMax";
            this.rd_x_xMax.Size = new System.Drawing.Size(50, 17);
            this.rd_x_xMax.TabIndex = 0;
            this.rd_x_xMax.Text = "xMax";
            this.rd_x_xMax.UseVisualStyleBackColor = true;
            this.rd_x_xMax.Click += new System.EventHandler(this.rd_x_sudut_Click);
            // 
            // rd_x_tMax
            // 
            this.rd_x_tMax.AutoSize = true;
            this.rd_x_tMax.Location = new System.Drawing.Point(331, 4);
            this.rd_x_tMax.Name = "rd_x_tMax";
            this.rd_x_tMax.Size = new System.Drawing.Size(51, 17);
            this.rd_x_tMax.TabIndex = 0;
            this.rd_x_tMax.Text = "t Max";
            this.rd_x_tMax.UseVisualStyleBackColor = true;
            this.rd_x_tMax.Click += new System.EventHandler(this.rd_x_sudut_Click);
            // 
            // rd_x_g
            // 
            this.rd_x_g.AutoSize = true;
            this.rd_x_g.Location = new System.Drawing.Point(238, 4);
            this.rd_x_g.Name = "rd_x_g";
            this.rd_x_g.Size = new System.Drawing.Size(87, 17);
            this.rd_x_g.TabIndex = 0;
            this.rd_x_g.Text = "Gravitasi ( g )";
            this.rd_x_g.UseVisualStyleBackColor = true;
            this.rd_x_g.Click += new System.EventHandler(this.rd_x_sudut_Click);
            // 
            // rd_x_v
            // 
            this.rd_x_v.AutoSize = true;
            this.rd_x_v.Checked = true;
            this.rd_x_v.Location = new System.Drawing.Point(134, 4);
            this.rd_x_v.Name = "rd_x_v";
            this.rd_x_v.Size = new System.Drawing.Size(98, 17);
            this.rd_x_v.TabIndex = 0;
            this.rd_x_v.TabStop = true;
            this.rd_x_v.Text = "Kecepatan ( v )";
            this.rd_x_v.UseVisualStyleBackColor = true;
            this.rd_x_v.Click += new System.EventHandler(this.rd_x_sudut_Click);
            // 
            // rd_x_sudut
            // 
            this.rd_x_sudut.AutoSize = true;
            this.rd_x_sudut.Location = new System.Drawing.Point(51, 4);
            this.rd_x_sudut.Name = "rd_x_sudut";
            this.rd_x_sudut.Size = new System.Drawing.Size(77, 17);
            this.rd_x_sudut.TabIndex = 0;
            this.rd_x_sudut.Text = "Sudut ( ∝ )";
            this.rd_x_sudut.UseVisualStyleBackColor = true;
            this.rd_x_sudut.Click += new System.EventHandler(this.rd_x_sudut_Click);
            // 
            // Analys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 729);
            this.Controls.Add(this.panel_select);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Analys";
            this.Text = "Analisis dan Grafik Data";
            this.Load += new System.EventHandler(this.Analys_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel_select.ResumeLayout(false);
            this.panel_y.ResumeLayout(false);
            this.panel_y.PerformLayout();
            this.panel_x.ResumeLayout(false);
            this.panel_x.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Panel panel_select;
        private System.Windows.Forms.Panel panel_y;
        private System.Windows.Forms.Panel panel_x;
        private System.Windows.Forms.RadioButton rd_x_xMax;
        private System.Windows.Forms.RadioButton rd_x_tMax;
        private System.Windows.Forms.RadioButton rd_x_g;
        private System.Windows.Forms.RadioButton rd_x_v;
        private System.Windows.Forms.RadioButton rd_x_sudut;
        private System.Windows.Forms.RadioButton rd_x_yMax;
        private System.Windows.Forms.RadioButton rd_y_yMax;
        private System.Windows.Forms.RadioButton rd_y_sudut;
        private System.Windows.Forms.RadioButton rd_y_xMax;
        private System.Windows.Forms.RadioButton rd_y_v;
        private System.Windows.Forms.RadioButton rd_y_tMax;
        private System.Windows.Forms.RadioButton rd_y_g;
        private System.Windows.Forms.Label lbl_y;
        private System.Windows.Forms.Label lbl_x;
        private System.Windows.Forms.ListBox list_data;

    }
}