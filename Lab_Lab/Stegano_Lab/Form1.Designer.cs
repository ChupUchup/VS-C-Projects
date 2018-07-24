namespace Stegano_Lab
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
            this.Txt_Sisip = new System.Windows.Forms.RichTextBox();
            this.Kanvas_Sisip = new System.Windows.Forms.PictureBox();
            this.Kanvas_Hsl = new System.Windows.Forms.PictureBox();
            this.Kanvas_Ekstrak = new System.Windows.Forms.PictureBox();
            this.Btn_Open_Sisip = new System.Windows.Forms.Button();
            this.Btn_Save_Sisip = new System.Windows.Forms.Button();
            this.Btn_Open_Ekstrak = new System.Windows.Forms.Button();
            this.Txt_Kunci_S = new System.Windows.Forms.TextBox();
            this.Txt_Kunci_E = new System.Windows.Forms.TextBox();
            this.Txt_Ekstrak = new System.Windows.Forms.RichTextBox();
            this.Btn_Sisip = new System.Windows.Forms.Button();
            this.Btn_Ekstrak = new System.Windows.Forms.Button();
            this.Pilih_Mode = new System.Windows.Forms.ComboBox();
            this.Pilih_Enkrip = new System.Windows.Forms.ComboBox();
            this.Btn_Reset = new System.Windows.Forms.Button();
            this.Btn_OpenTxt = new System.Windows.Forms.Button();
            this.Btn_SaveTxt_S = new System.Windows.Forms.Button();
            this.Btn_SaveTxt_E = new System.Windows.Forms.Button();
            this.Lbl_Txt_S = new System.Windows.Forms.Label();
            this.Lbl_Txt_E = new System.Windows.Forms.Label();
            this.Lbl_Key_S = new System.Windows.Forms.Label();
            this.Lbl_Key_E = new System.Windows.Forms.Label();
            this.myChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Histo_S = new System.Windows.Forms.Button();
            this.Histo_E = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Kanvas_Sisip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kanvas_Hsl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kanvas_Ekstrak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myChart)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Sisip
            // 
            this.Txt_Sisip.Location = new System.Drawing.Point(12, 12);
            this.Txt_Sisip.Name = "Txt_Sisip";
            this.Txt_Sisip.Size = new System.Drawing.Size(321, 110);
            this.Txt_Sisip.TabIndex = 0;
            this.Txt_Sisip.Text = "";
            this.Txt_Sisip.TextChanged += new System.EventHandler(this.Txt_Sisip_TextChanged);
            // 
            // Kanvas_Sisip
            // 
            this.Kanvas_Sisip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Kanvas_Sisip.Location = new System.Drawing.Point(12, 154);
            this.Kanvas_Sisip.Name = "Kanvas_Sisip";
            this.Kanvas_Sisip.Size = new System.Drawing.Size(136, 118);
            this.Kanvas_Sisip.TabIndex = 1;
            this.Kanvas_Sisip.TabStop = false;
            // 
            // Kanvas_Hsl
            // 
            this.Kanvas_Hsl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Kanvas_Hsl.Location = new System.Drawing.Point(339, 154);
            this.Kanvas_Hsl.Name = "Kanvas_Hsl";
            this.Kanvas_Hsl.Size = new System.Drawing.Size(141, 118);
            this.Kanvas_Hsl.TabIndex = 2;
            this.Kanvas_Hsl.TabStop = false;
            // 
            // Kanvas_Ekstrak
            // 
            this.Kanvas_Ekstrak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Kanvas_Ekstrak.Location = new System.Drawing.Point(666, 154);
            this.Kanvas_Ekstrak.Name = "Kanvas_Ekstrak";
            this.Kanvas_Ekstrak.Size = new System.Drawing.Size(120, 118);
            this.Kanvas_Ekstrak.TabIndex = 3;
            this.Kanvas_Ekstrak.TabStop = false;
            // 
            // Btn_Open_Sisip
            // 
            this.Btn_Open_Sisip.Location = new System.Drawing.Point(190, 164);
            this.Btn_Open_Sisip.Name = "Btn_Open_Sisip";
            this.Btn_Open_Sisip.Size = new System.Drawing.Size(75, 23);
            this.Btn_Open_Sisip.TabIndex = 4;
            this.Btn_Open_Sisip.Text = "Open Img";
            this.Btn_Open_Sisip.UseVisualStyleBackColor = true;
            this.Btn_Open_Sisip.Click += new System.EventHandler(this.Btn_OpenImg_S_Click);
            // 
            // Btn_Save_Sisip
            // 
            this.Btn_Save_Sisip.Location = new System.Drawing.Point(467, 164);
            this.Btn_Save_Sisip.Name = "Btn_Save_Sisip";
            this.Btn_Save_Sisip.Size = new System.Drawing.Size(75, 23);
            this.Btn_Save_Sisip.TabIndex = 5;
            this.Btn_Save_Sisip.Text = "Save Img";
            this.Btn_Save_Sisip.UseVisualStyleBackColor = true;
            this.Btn_Save_Sisip.Click += new System.EventHandler(this.Btn_SaveImg_Click);
            // 
            // Btn_Open_Ekstrak
            // 
            this.Btn_Open_Ekstrak.Location = new System.Drawing.Point(733, 164);
            this.Btn_Open_Ekstrak.Name = "Btn_Open_Ekstrak";
            this.Btn_Open_Ekstrak.Size = new System.Drawing.Size(75, 23);
            this.Btn_Open_Ekstrak.TabIndex = 6;
            this.Btn_Open_Ekstrak.Text = "Open Img";
            this.Btn_Open_Ekstrak.UseVisualStyleBackColor = true;
            this.Btn_Open_Ekstrak.Click += new System.EventHandler(this.Btn_OpenImg_E_Click);
            // 
            // Txt_Kunci_S
            // 
            this.Txt_Kunci_S.Location = new System.Drawing.Point(12, 128);
            this.Txt_Kunci_S.Name = "Txt_Kunci_S";
            this.Txt_Kunci_S.Size = new System.Drawing.Size(320, 20);
            this.Txt_Kunci_S.TabIndex = 7;
            this.Txt_Kunci_S.TextChanged += new System.EventHandler(this.Txt_Kunci_S_TextChanged);
            // 
            // Txt_Kunci_E
            // 
            this.Txt_Kunci_E.Location = new System.Drawing.Point(666, 128);
            this.Txt_Kunci_E.Name = "Txt_Kunci_E";
            this.Txt_Kunci_E.Size = new System.Drawing.Size(320, 20);
            this.Txt_Kunci_E.TabIndex = 9;
            this.Txt_Kunci_E.TextChanged += new System.EventHandler(this.Txt_Kunci_E_TextChanged);
            // 
            // Txt_Ekstrak
            // 
            this.Txt_Ekstrak.Location = new System.Drawing.Point(666, 11);
            this.Txt_Ekstrak.Name = "Txt_Ekstrak";
            this.Txt_Ekstrak.Size = new System.Drawing.Size(320, 110);
            this.Txt_Ekstrak.TabIndex = 8;
            this.Txt_Ekstrak.Text = "";
            this.Txt_Ekstrak.TextChanged += new System.EventHandler(this.Txt_Ekstrak_TextChanged);
            // 
            // Btn_Sisip
            // 
            this.Btn_Sisip.Location = new System.Drawing.Point(339, 60);
            this.Btn_Sisip.Name = "Btn_Sisip";
            this.Btn_Sisip.Size = new System.Drawing.Size(75, 23);
            this.Btn_Sisip.TabIndex = 10;
            this.Btn_Sisip.Text = "Sisip";
            this.Btn_Sisip.UseVisualStyleBackColor = true;
            this.Btn_Sisip.Click += new System.EventHandler(this.Btn_Sisip_Click);
            // 
            // Btn_Ekstrak
            // 
            this.Btn_Ekstrak.Location = new System.Drawing.Point(585, 36);
            this.Btn_Ekstrak.Name = "Btn_Ekstrak";
            this.Btn_Ekstrak.Size = new System.Drawing.Size(75, 23);
            this.Btn_Ekstrak.TabIndex = 11;
            this.Btn_Ekstrak.Text = "Ekstrak";
            this.Btn_Ekstrak.UseVisualStyleBackColor = true;
            this.Btn_Ekstrak.Click += new System.EventHandler(this.Btn_Ekstrak_Click);
            // 
            // Pilih_Mode
            // 
            this.Pilih_Mode.FormattingEnabled = true;
            this.Pilih_Mode.Items.AddRange(new object[] {
            "PCA",
            "PCS"});
            this.Pilih_Mode.Location = new System.Drawing.Point(441, 12);
            this.Pilih_Mode.Name = "Pilih_Mode";
            this.Pilih_Mode.Size = new System.Drawing.Size(121, 21);
            this.Pilih_Mode.TabIndex = 17;
            this.Pilih_Mode.Text = "Pilih Mode";
            this.Pilih_Mode.SelectedIndexChanged += new System.EventHandler(this.Pilih_Mode_SelectedIndexChanged);
            // 
            // Pilih_Enkrip
            // 
            this.Pilih_Enkrip.FormattingEnabled = true;
            this.Pilih_Enkrip.Items.AddRange(new object[] {
            "NoEnkrip",
            "AES128",
            "AES256"});
            this.Pilih_Enkrip.Location = new System.Drawing.Point(441, 39);
            this.Pilih_Enkrip.Name = "Pilih_Enkrip";
            this.Pilih_Enkrip.Size = new System.Drawing.Size(121, 21);
            this.Pilih_Enkrip.TabIndex = 18;
            this.Pilih_Enkrip.Text = "Pilih Enkripsi";
            this.Pilih_Enkrip.SelectedIndexChanged += new System.EventHandler(this.Pilih_Enkrip_SelectedIndexChanged);
            // 
            // Btn_Reset
            // 
            this.Btn_Reset.Location = new System.Drawing.Point(585, 60);
            this.Btn_Reset.Name = "Btn_Reset";
            this.Btn_Reset.Size = new System.Drawing.Size(75, 23);
            this.Btn_Reset.TabIndex = 19;
            this.Btn_Reset.Text = "Reset";
            this.Btn_Reset.UseVisualStyleBackColor = true;
            this.Btn_Reset.Click += new System.EventHandler(this.Btn_Reset_Click);
            // 
            // Btn_OpenTxt
            // 
            this.Btn_OpenTxt.Location = new System.Drawing.Point(339, 12);
            this.Btn_OpenTxt.Name = "Btn_OpenTxt";
            this.Btn_OpenTxt.Size = new System.Drawing.Size(75, 23);
            this.Btn_OpenTxt.TabIndex = 20;
            this.Btn_OpenTxt.Text = "Buka Txt";
            this.Btn_OpenTxt.UseVisualStyleBackColor = true;
            this.Btn_OpenTxt.Click += new System.EventHandler(this.Btn_OpenTxt_Click);
            // 
            // Btn_SaveTxt_S
            // 
            this.Btn_SaveTxt_S.Location = new System.Drawing.Point(339, 36);
            this.Btn_SaveTxt_S.Name = "Btn_SaveTxt_S";
            this.Btn_SaveTxt_S.Size = new System.Drawing.Size(75, 23);
            this.Btn_SaveTxt_S.TabIndex = 21;
            this.Btn_SaveTxt_S.Text = "Save Txt";
            this.Btn_SaveTxt_S.UseVisualStyleBackColor = true;
            this.Btn_SaveTxt_S.Click += new System.EventHandler(this.Btn_SaveTxt_S_Click);
            // 
            // Btn_SaveTxt_E
            // 
            this.Btn_SaveTxt_E.Location = new System.Drawing.Point(585, 12);
            this.Btn_SaveTxt_E.Name = "Btn_SaveTxt_E";
            this.Btn_SaveTxt_E.Size = new System.Drawing.Size(75, 23);
            this.Btn_SaveTxt_E.TabIndex = 22;
            this.Btn_SaveTxt_E.Text = "Save Txt";
            this.Btn_SaveTxt_E.UseVisualStyleBackColor = true;
            this.Btn_SaveTxt_E.Click += new System.EventHandler(this.Btn_SaveTxt_E_Click);
            // 
            // Lbl_Txt_S
            // 
            this.Lbl_Txt_S.AutoSize = true;
            this.Lbl_Txt_S.Location = new System.Drawing.Point(339, 109);
            this.Lbl_Txt_S.Name = "Lbl_Txt_S";
            this.Lbl_Txt_S.Size = new System.Drawing.Size(88, 13);
            this.Lbl_Txt_S.TabIndex = 23;
            this.Lbl_Txt_S.Text = "Panjang Pesan : ";
            // 
            // Lbl_Txt_E
            // 
            this.Lbl_Txt_E.AutoSize = true;
            this.Lbl_Txt_E.Location = new System.Drawing.Point(532, 108);
            this.Lbl_Txt_E.Name = "Lbl_Txt_E";
            this.Lbl_Txt_E.Size = new System.Drawing.Size(88, 13);
            this.Lbl_Txt_E.TabIndex = 24;
            this.Lbl_Txt_E.Text = "Panjang Pesan : ";
            // 
            // Lbl_Key_S
            // 
            this.Lbl_Key_S.AutoSize = true;
            this.Lbl_Key_S.Location = new System.Drawing.Point(339, 131);
            this.Lbl_Key_S.Name = "Lbl_Key_S";
            this.Lbl_Key_S.Size = new System.Drawing.Size(85, 13);
            this.Lbl_Key_S.TabIndex = 25;
            this.Lbl_Key_S.Text = "Panjang Kunci : ";
            // 
            // Lbl_Key_E
            // 
            this.Lbl_Key_E.AutoSize = true;
            this.Lbl_Key_E.Location = new System.Drawing.Point(532, 131);
            this.Lbl_Key_E.Name = "Lbl_Key_E";
            this.Lbl_Key_E.Size = new System.Drawing.Size(85, 13);
            this.Lbl_Key_E.TabIndex = 26;
            this.Lbl_Key_E.Text = "Panjang Kunci : ";
            // 
            // myChart
            // 
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.SystemColors.ControlLight;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.Name = "ChartArea1";
            this.myChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.myChart.Legends.Add(legend1);
            this.myChart.Location = new System.Drawing.Point(12, 278);
            this.myChart.Name = "myChart";
            this.myChart.Size = new System.Drawing.Size(974, 351);
            this.myChart.TabIndex = 27;
            this.myChart.Text = "chart1";
            // 
            // Histo_S
            // 
            this.Histo_S.Location = new System.Drawing.Point(73, 164);
            this.Histo_S.Name = "Histo_S";
            this.Histo_S.Size = new System.Drawing.Size(75, 23);
            this.Histo_S.TabIndex = 28;
            this.Histo_S.Text = "Histogram";
            this.Histo_S.UseVisualStyleBackColor = true;
            this.Histo_S.Click += new System.EventHandler(this.Histo_S_Click);
            // 
            // Histo_E
            // 
            this.Histo_E.Location = new System.Drawing.Point(860, 164);
            this.Histo_E.Name = "Histo_E";
            this.Histo_E.Size = new System.Drawing.Size(75, 23);
            this.Histo_E.TabIndex = 29;
            this.Histo_E.Text = "Histogram";
            this.Histo_E.UseVisualStyleBackColor = true;
            this.Histo_E.Click += new System.EventHandler(this.Histo_E_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 641);
            this.Controls.Add(this.Histo_E);
            this.Controls.Add(this.Histo_S);
            this.Controls.Add(this.myChart);
            this.Controls.Add(this.Lbl_Key_E);
            this.Controls.Add(this.Lbl_Key_S);
            this.Controls.Add(this.Lbl_Txt_E);
            this.Controls.Add(this.Lbl_Txt_S);
            this.Controls.Add(this.Btn_SaveTxt_E);
            this.Controls.Add(this.Btn_SaveTxt_S);
            this.Controls.Add(this.Btn_OpenTxt);
            this.Controls.Add(this.Btn_Reset);
            this.Controls.Add(this.Pilih_Enkrip);
            this.Controls.Add(this.Pilih_Mode);
            this.Controls.Add(this.Btn_Ekstrak);
            this.Controls.Add(this.Btn_Sisip);
            this.Controls.Add(this.Txt_Kunci_E);
            this.Controls.Add(this.Txt_Ekstrak);
            this.Controls.Add(this.Txt_Kunci_S);
            this.Controls.Add(this.Btn_Open_Ekstrak);
            this.Controls.Add(this.Btn_Save_Sisip);
            this.Controls.Add(this.Btn_Open_Sisip);
            this.Controls.Add(this.Kanvas_Ekstrak);
            this.Controls.Add(this.Kanvas_Hsl);
            this.Controls.Add(this.Kanvas_Sisip);
            this.Controls.Add(this.Txt_Sisip);
            this.Name = "Form1";
            this.Text = "Test Stegano";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Kanvas_Sisip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kanvas_Hsl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kanvas_Ekstrak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Txt_Sisip;
        private System.Windows.Forms.PictureBox Kanvas_Sisip;
        private System.Windows.Forms.PictureBox Kanvas_Hsl;
        private System.Windows.Forms.PictureBox Kanvas_Ekstrak;
        private System.Windows.Forms.Button Btn_Open_Sisip;
        private System.Windows.Forms.Button Btn_Save_Sisip;
        private System.Windows.Forms.Button Btn_Open_Ekstrak;
        private System.Windows.Forms.TextBox Txt_Kunci_S;
        private System.Windows.Forms.TextBox Txt_Kunci_E;
        private System.Windows.Forms.RichTextBox Txt_Ekstrak;
        private System.Windows.Forms.Button Btn_Sisip;
        private System.Windows.Forms.Button Btn_Ekstrak;
        private System.Windows.Forms.ComboBox Pilih_Mode;
        private System.Windows.Forms.ComboBox Pilih_Enkrip;
        private System.Windows.Forms.Button Btn_Reset;
        private System.Windows.Forms.Button Btn_OpenTxt;
        private System.Windows.Forms.Button Btn_SaveTxt_S;
        private System.Windows.Forms.Button Btn_SaveTxt_E;
        private System.Windows.Forms.Label Lbl_Txt_S;
        private System.Windows.Forms.Label Lbl_Txt_E;
        private System.Windows.Forms.Label Lbl_Key_S;
        private System.Windows.Forms.Label Lbl_Key_E;
        private System.Windows.Forms.DataVisualization.Charting.Chart myChart;
        private System.Windows.Forms.Button Histo_S;
        private System.Windows.Forms.Button Histo_E;
    }
}

