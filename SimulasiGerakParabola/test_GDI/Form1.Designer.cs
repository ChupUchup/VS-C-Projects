namespace test_GDI
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
            this.lbl_sudut = new System.Windows.Forms.Label();
            this.lbl_v = new System.Windows.Forms.Label();
            this.lbl_g = new System.Windows.Forms.Label();
            this.txt_tMax = new System.Windows.Forms.TextBox();
            this.txt_yMax = new System.Windows.Forms.TextBox();
            this.txt_xMax = new System.Windows.Forms.TextBox();
            this.lbl_tMax = new System.Windows.Forms.Label();
            this.lbl_xMax = new System.Windows.Forms.Label();
            this.lbl_yMax = new System.Windows.Forms.Label();
            this.btn_hitung = new System.Windows.Forms.Button();
            this.list_koor = new System.Windows.Forms.ListBox();
            this.lbl_tick = new System.Windows.Forms.Label();
            this.lbl_skala = new System.Windows.Forms.Label();
            this.lbl_diameter = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_fire = new System.Windows.Forms.Button();
            this.btn_analisis = new System.Windows.Forms.Button();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.txt_g = new System.Windows.Forms.NumericUpDown();
            this.txt_v = new System.Windows.Forms.NumericUpDown();
            this.btn_reset = new System.Windows.Forms.Button();
            this.txt_diameter = new System.Windows.Forms.NumericUpDown();
            this.btn_stop = new System.Windows.Forms.Button();
            this.txt_skala = new System.Windows.Forms.NumericUpDown();
            this.txt_tick = new System.Windows.Forms.NumericUpDown();
            this.txt_sudut = new System.Windows.Forms.NumericUpDown();
            this.kanvas = new System.Windows.Forms.PictureBox();
            this.chk_jejak = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_g)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_v)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_diameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_skala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sudut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_sudut
            // 
            this.lbl_sudut.AutoSize = true;
            this.lbl_sudut.Location = new System.Drawing.Point(25, 9);
            this.lbl_sudut.Name = "lbl_sudut";
            this.lbl_sudut.Size = new System.Drawing.Size(59, 13);
            this.lbl_sudut.TabIndex = 100;
            this.lbl_sudut.Text = "Sudut ( ∝ )";
            // 
            // lbl_v
            // 
            this.lbl_v.AutoSize = true;
            this.lbl_v.Location = new System.Drawing.Point(4, 36);
            this.lbl_v.Name = "lbl_v";
            this.lbl_v.Size = new System.Drawing.Size(80, 13);
            this.lbl_v.TabIndex = 100;
            this.lbl_v.Text = "Kecepatan ( v )";
            // 
            // lbl_g
            // 
            this.lbl_g.AutoSize = true;
            this.lbl_g.Location = new System.Drawing.Point(15, 67);
            this.lbl_g.Name = "lbl_g";
            this.lbl_g.Size = new System.Drawing.Size(69, 13);
            this.lbl_g.TabIndex = 100;
            this.lbl_g.Text = "Gravitasi ( g )";
            // 
            // txt_tMax
            // 
            this.txt_tMax.Location = new System.Drawing.Point(446, 4);
            this.txt_tMax.Name = "txt_tMax";
            this.txt_tMax.Size = new System.Drawing.Size(67, 20);
            this.txt_tMax.TabIndex = 6;
            // 
            // txt_yMax
            // 
            this.txt_yMax.Location = new System.Drawing.Point(446, 62);
            this.txt_yMax.Name = "txt_yMax";
            this.txt_yMax.Size = new System.Drawing.Size(67, 20);
            this.txt_yMax.TabIndex = 8;
            // 
            // txt_xMax
            // 
            this.txt_xMax.Location = new System.Drawing.Point(446, 33);
            this.txt_xMax.Name = "txt_xMax";
            this.txt_xMax.Size = new System.Drawing.Size(67, 20);
            this.txt_xMax.TabIndex = 7;
            // 
            // lbl_tMax
            // 
            this.lbl_tMax.AutoSize = true;
            this.lbl_tMax.Location = new System.Drawing.Point(340, 9);
            this.lbl_tMax.Name = "lbl_tMax";
            this.lbl_tMax.Size = new System.Drawing.Size(100, 13);
            this.lbl_tMax.TabIndex = 100;
            this.lbl_tMax.Text = "Waktu Max ( tMax )";
            // 
            // lbl_xMax
            // 
            this.lbl_xMax.AutoSize = true;
            this.lbl_xMax.Location = new System.Drawing.Point(341, 65);
            this.lbl_xMax.Name = "lbl_xMax";
            this.lbl_xMax.Size = new System.Drawing.Size(99, 13);
            this.lbl_xMax.TabIndex = 100;
            this.lbl_xMax.Text = "Tinggi Max ( yMax )";
            // 
            // lbl_yMax
            // 
            this.lbl_yMax.AutoSize = true;
            this.lbl_yMax.Location = new System.Drawing.Point(344, 36);
            this.lbl_yMax.Name = "lbl_yMax";
            this.lbl_yMax.Size = new System.Drawing.Size(96, 13);
            this.lbl_yMax.TabIndex = 100;
            this.lbl_yMax.Text = "Jarak Max ( xMax )";
            // 
            // btn_hitung
            // 
            this.btn_hitung.Location = new System.Drawing.Point(785, 4);
            this.btn_hitung.Name = "btn_hitung";
            this.btn_hitung.Size = new System.Drawing.Size(48, 23);
            this.btn_hitung.TabIndex = 10;
            this.btn_hitung.Text = "Hitung";
            this.btn_hitung.UseVisualStyleBackColor = true;
            this.btn_hitung.Click += new System.EventHandler(this.btn_hitung_Click);
            // 
            // list_koor
            // 
            this.list_koor.FormattingEnabled = true;
            this.list_koor.Location = new System.Drawing.Point(519, 2);
            this.list_koor.Name = "list_koor";
            this.list_koor.Size = new System.Drawing.Size(260, 82);
            this.list_koor.TabIndex = 9;
            // 
            // lbl_tick
            // 
            this.lbl_tick.AutoSize = true;
            this.lbl_tick.Location = new System.Drawing.Point(160, 9);
            this.lbl_tick.Name = "lbl_tick";
            this.lbl_tick.Size = new System.Drawing.Size(101, 13);
            this.lbl_tick.TabIndex = 100;
            this.lbl_tick.Text = "Rentang Waktu ( t )";
            // 
            // lbl_skala
            // 
            this.lbl_skala.AutoSize = true;
            this.lbl_skala.Location = new System.Drawing.Point(160, 38);
            this.lbl_skala.Name = "lbl_skala";
            this.lbl_skala.Size = new System.Drawing.Size(101, 13);
            this.lbl_skala.TabIndex = 100;
            this.lbl_skala.Text = "Skala ( meter/pixel )";
            // 
            // lbl_diameter
            // 
            this.lbl_diameter.AutoSize = true;
            this.lbl_diameter.Location = new System.Drawing.Point(176, 67);
            this.lbl_diameter.Name = "lbl_diameter";
            this.lbl_diameter.Size = new System.Drawing.Size(85, 13);
            this.lbl_diameter.TabIndex = 100;
            this.lbl_diameter.Text = "Diameter ( pixel )";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chk_jejak);
            this.panel1.Controls.Add(this.btn_fire);
            this.panel1.Controls.Add(this.btn_analisis);
            this.panel1.Controls.Add(this.btn_simpan);
            this.panel1.Controls.Add(this.txt_g);
            this.panel1.Controls.Add(this.txt_v);
            this.panel1.Controls.Add(this.btn_reset);
            this.panel1.Controls.Add(this.txt_diameter);
            this.panel1.Controls.Add(this.btn_stop);
            this.panel1.Controls.Add(this.txt_skala);
            this.panel1.Controls.Add(this.txt_tick);
            this.panel1.Controls.Add(this.txt_sudut);
            this.panel1.Controls.Add(this.lbl_sudut);
            this.panel1.Controls.Add(this.list_koor);
            this.panel1.Controls.Add(this.btn_hitung);
            this.panel1.Controls.Add(this.lbl_diameter);
            this.panel1.Controls.Add(this.txt_tMax);
            this.panel1.Controls.Add(this.lbl_yMax);
            this.panel1.Controls.Add(this.lbl_g);
            this.panel1.Controls.Add(this.lbl_skala);
            this.panel1.Controls.Add(this.txt_yMax);
            this.panel1.Controls.Add(this.lbl_xMax);
            this.panel1.Controls.Add(this.txt_xMax);
            this.panel1.Controls.Add(this.lbl_v);
            this.panel1.Controls.Add(this.lbl_tick);
            this.panel1.Controls.Add(this.lbl_tMax);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 100);
            this.panel1.TabIndex = 103;
            // 
            // btn_fire
            // 
            this.btn_fire.Location = new System.Drawing.Point(785, 38);
            this.btn_fire.Name = "btn_fire";
            this.btn_fire.Size = new System.Drawing.Size(264, 40);
            this.btn_fire.TabIndex = 102;
            this.btn_fire.Text = "Fire";
            this.btn_fire.UseVisualStyleBackColor = true;
            this.btn_fire.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_fire_KeyDown);
            this.btn_fire.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btn_fire_KeyUp);
            // 
            // btn_analisis
            // 
            this.btn_analisis.Location = new System.Drawing.Point(893, 4);
            this.btn_analisis.Name = "btn_analisis";
            this.btn_analisis.Size = new System.Drawing.Size(48, 23);
            this.btn_analisis.TabIndex = 101;
            this.btn_analisis.Text = "Analys";
            this.btn_analisis.UseVisualStyleBackColor = true;
            this.btn_analisis.Click += new System.EventHandler(this.btn_analisis_Click);
            // 
            // btn_simpan
            // 
            this.btn_simpan.Location = new System.Drawing.Point(839, 4);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(48, 23);
            this.btn_simpan.TabIndex = 101;
            this.btn_simpan.Text = "Save";
            this.btn_simpan.UseVisualStyleBackColor = true;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // txt_g
            // 
            this.txt_g.DecimalPlaces = 2;
            this.txt_g.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.txt_g.Location = new System.Drawing.Point(87, 65);
            this.txt_g.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.txt_g.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_g.Name = "txt_g";
            this.txt_g.Size = new System.Drawing.Size(67, 20);
            this.txt_g.TabIndex = 2;
            this.txt_g.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txt_g.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_diameter_KeyDown);
            // 
            // txt_v
            // 
            this.txt_v.Location = new System.Drawing.Point(87, 36);
            this.txt_v.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.txt_v.Name = "txt_v";
            this.txt_v.Size = new System.Drawing.Size(67, 20);
            this.txt_v.TabIndex = 1;
            this.txt_v.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txt_v.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_diameter_KeyDown);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(947, 4);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(48, 23);
            this.btn_reset.TabIndex = 11;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // txt_diameter
            // 
            this.txt_diameter.Location = new System.Drawing.Point(267, 65);
            this.txt_diameter.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.txt_diameter.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.txt_diameter.Name = "txt_diameter";
            this.txt_diameter.Size = new System.Drawing.Size(67, 20);
            this.txt_diameter.TabIndex = 4;
            this.txt_diameter.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.txt_diameter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_diameter_KeyDown);
            // 
            // btn_stop
            // 
            this.btn_stop.Enabled = false;
            this.btn_stop.Location = new System.Drawing.Point(1001, 4);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(48, 23);
            this.btn_stop.TabIndex = 12;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Visible = false;
            // 
            // txt_skala
            // 
            this.txt_skala.DecimalPlaces = 2;
            this.txt_skala.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txt_skala.Location = new System.Drawing.Point(267, 36);
            this.txt_skala.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.txt_skala.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txt_skala.Name = "txt_skala";
            this.txt_skala.Size = new System.Drawing.Size(67, 20);
            this.txt_skala.TabIndex = 4;
            this.txt_skala.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txt_skala.ValueChanged += new System.EventHandler(this.txt_skala_ValueChanged);
            this.txt_skala.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_diameter_KeyDown);
            // 
            // txt_tick
            // 
            this.txt_tick.DecimalPlaces = 2;
            this.txt_tick.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txt_tick.Location = new System.Drawing.Point(267, 7);
            this.txt_tick.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.txt_tick.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txt_tick.Name = "txt_tick";
            this.txt_tick.Size = new System.Drawing.Size(67, 20);
            this.txt_tick.TabIndex = 3;
            this.txt_tick.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txt_tick.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_diameter_KeyDown);
            // 
            // txt_sudut
            // 
            this.txt_sudut.Location = new System.Drawing.Point(87, 7);
            this.txt_sudut.Name = "txt_sudut";
            this.txt_sudut.Size = new System.Drawing.Size(67, 20);
            this.txt_sudut.TabIndex = 0;
            this.txt_sudut.Value = new decimal(new int[] {
            37,
            0,
            0,
            0});
            this.txt_sudut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_diameter_KeyDown);
            // 
            // kanvas
            // 
            this.kanvas.Location = new System.Drawing.Point(12, 118);
            this.kanvas.Name = "kanvas";
            this.kanvas.Size = new System.Drawing.Size(1060, 599);
            this.kanvas.TabIndex = 104;
            this.kanvas.TabStop = false;
            // 
            // chk_jejak
            // 
            this.chk_jejak.AutoSize = true;
            this.chk_jejak.Checked = true;
            this.chk_jejak.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_jejak.Location = new System.Drawing.Point(1001, 8);
            this.chk_jejak.Name = "chk_jejak";
            this.chk_jejak.Size = new System.Drawing.Size(51, 17);
            this.chk_jejak.TabIndex = 103;
            this.chk_jejak.Text = "Jejak";
            this.chk_jejak.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 729);
            this.Controls.Add(this.kanvas);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Simulasi Gerak Parabola";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_g)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_v)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_diameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_skala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sudut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_sudut;
        private System.Windows.Forms.Label lbl_v;
        private System.Windows.Forms.Label lbl_g;
        private System.Windows.Forms.TextBox txt_tMax;
        private System.Windows.Forms.TextBox txt_yMax;
        private System.Windows.Forms.TextBox txt_xMax;
        private System.Windows.Forms.Label lbl_tMax;
        private System.Windows.Forms.Label lbl_xMax;
        private System.Windows.Forms.Label lbl_yMax;
        private System.Windows.Forms.Button btn_hitung;
        private System.Windows.Forms.ListBox list_koor;
        private System.Windows.Forms.Label lbl_tick;
        private System.Windows.Forms.Label lbl_skala;
        private System.Windows.Forms.Label lbl_diameter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox kanvas;
        private System.Windows.Forms.NumericUpDown txt_sudut;
        private System.Windows.Forms.NumericUpDown txt_tick;
        private System.Windows.Forms.NumericUpDown txt_skala;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.NumericUpDown txt_diameter;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.NumericUpDown txt_g;
        private System.Windows.Forms.NumericUpDown txt_v;
        private System.Windows.Forms.Button btn_fire;
        private System.Windows.Forms.Button btn_analisis;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.CheckBox chk_jejak;

    }
}

