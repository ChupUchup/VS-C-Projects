namespace Simulasi_Jumlah_Penduduk
{
    partial class Form1
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.laju_check = new System.Windows.Forms.RadioButton();
            this.pend_check = new System.Windows.Forms.RadioButton();
            this.btn_indo = new System.Windows.Forms.Button();
            this.btn_sumut_v1 = new System.Windows.Forms.Button();
            this.btn_sumut_v2 = new System.Windows.Forms.Button();
            this.btn_medan = new System.Windows.Forms.Button();
            this.btn_kurang = new System.Windows.Forms.Button();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.btn_simpan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 37);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(760, 212);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // laju_check
            // 
            this.laju_check.AutoSize = true;
            this.laju_check.Location = new System.Drawing.Point(336, 11);
            this.laju_check.Name = "laju_check";
            this.laju_check.Size = new System.Drawing.Size(45, 17);
            this.laju_check.TabIndex = 2;
            this.laju_check.TabStop = true;
            this.laju_check.Text = "Laju";
            this.laju_check.UseVisualStyleBackColor = true;
            this.laju_check.CheckedChanged += new System.EventHandler(this.laju_check_CheckedChanged);
            // 
            // pend_check
            // 
            this.pend_check.AutoSize = true;
            this.pend_check.Location = new System.Drawing.Point(387, 11);
            this.pend_check.Name = "pend_check";
            this.pend_check.Size = new System.Drawing.Size(58, 17);
            this.pend_check.TabIndex = 2;
            this.pend_check.TabStop = true;
            this.pend_check.Text = "Jumlah";
            this.pend_check.UseVisualStyleBackColor = true;
            // 
            // btn_indo
            // 
            this.btn_indo.BackColor = System.Drawing.Color.Transparent;
            this.btn_indo.Location = new System.Drawing.Point(12, 8);
            this.btn_indo.Name = "btn_indo";
            this.btn_indo.Size = new System.Drawing.Size(75, 23);
            this.btn_indo.TabIndex = 3;
            this.btn_indo.Text = "Indonesia";
            this.btn_indo.UseVisualStyleBackColor = false;
            this.btn_indo.Click += new System.EventHandler(this.btn_indo_Click);
            // 
            // btn_sumut_v1
            // 
            this.btn_sumut_v1.BackColor = System.Drawing.Color.Transparent;
            this.btn_sumut_v1.Location = new System.Drawing.Point(93, 8);
            this.btn_sumut_v1.Name = "btn_sumut_v1";
            this.btn_sumut_v1.Size = new System.Drawing.Size(75, 23);
            this.btn_sumut_v1.TabIndex = 3;
            this.btn_sumut_v1.Text = "Sumut v1";
            this.btn_sumut_v1.UseVisualStyleBackColor = false;
            this.btn_sumut_v1.Click += new System.EventHandler(this.btn_sumut_v1_Click);
            // 
            // btn_sumut_v2
            // 
            this.btn_sumut_v2.BackColor = System.Drawing.Color.Transparent;
            this.btn_sumut_v2.Location = new System.Drawing.Point(174, 8);
            this.btn_sumut_v2.Name = "btn_sumut_v2";
            this.btn_sumut_v2.Size = new System.Drawing.Size(75, 23);
            this.btn_sumut_v2.TabIndex = 3;
            this.btn_sumut_v2.Text = "Sumut v2";
            this.btn_sumut_v2.UseVisualStyleBackColor = false;
            this.btn_sumut_v2.Click += new System.EventHandler(this.btn_sumut_v2_Click);
            // 
            // btn_medan
            // 
            this.btn_medan.BackColor = System.Drawing.Color.Transparent;
            this.btn_medan.Location = new System.Drawing.Point(255, 8);
            this.btn_medan.Name = "btn_medan";
            this.btn_medan.Size = new System.Drawing.Size(75, 23);
            this.btn_medan.TabIndex = 3;
            this.btn_medan.Text = "Medan";
            this.btn_medan.UseVisualStyleBackColor = false;
            this.btn_medan.Click += new System.EventHandler(this.btn_medan_Click);
            // 
            // btn_kurang
            // 
            this.btn_kurang.Location = new System.Drawing.Point(451, 6);
            this.btn_kurang.Name = "btn_kurang";
            this.btn_kurang.Size = new System.Drawing.Size(27, 27);
            this.btn_kurang.TabIndex = 4;
            this.btn_kurang.Text = "<";
            this.btn_kurang.UseVisualStyleBackColor = true;
            this.btn_kurang.Click += new System.EventHandler(this.btn_kurang_Click);
            // 
            // btn_tambah
            // 
            this.btn_tambah.Location = new System.Drawing.Point(484, 6);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(27, 27);
            this.btn_tambah.TabIndex = 4;
            this.btn_tambah.Text = ">";
            this.btn_tambah.UseVisualStyleBackColor = true;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // btn_simpan
            // 
            this.btn_simpan.Location = new System.Drawing.Point(681, 8);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(91, 23);
            this.btn_simpan.TabIndex = 5;
            this.btn_simpan.Text = "Simpan Gambar";
            this.btn_simpan.UseVisualStyleBackColor = true;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 261);
            this.Controls.Add(this.btn_simpan);
            this.Controls.Add(this.btn_tambah);
            this.Controls.Add(this.btn_kurang);
            this.Controls.Add(this.btn_medan);
            this.Controls.Add(this.btn_sumut_v2);
            this.Controls.Add(this.btn_sumut_v1);
            this.Controls.Add(this.btn_indo);
            this.Controls.Add(this.pend_check);
            this.Controls.Add(this.laju_check);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Simulasi Jumlah Penduduk";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.RadioButton laju_check;
        private System.Windows.Forms.RadioButton pend_check;
        private System.Windows.Forms.Button btn_indo;
        private System.Windows.Forms.Button btn_sumut_v1;
        private System.Windows.Forms.Button btn_sumut_v2;
        private System.Windows.Forms.Button btn_medan;
        private System.Windows.Forms.Button btn_kurang;
        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.Button btn_simpan;
    }
}

