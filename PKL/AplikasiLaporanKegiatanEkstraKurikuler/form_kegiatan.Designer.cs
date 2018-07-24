namespace AplikasiLaporanKegiatanEkstraKurikuler
{
    partial class form_kegiatan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_kegiatan));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dgv_kegiatan = new System.Windows.Forms.DataGridView();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nama_kegiatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_guru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_hari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_jam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dgv_siswa = new System.Windows.Forms.DataGridView();
            this.col_nis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nama_siswa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_kelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kegiatan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_siswa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Kegiatan";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(108, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Guru Pembimbing";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hari Kegiatan";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(108, 111);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Jam Kegiatan";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(108, 138);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Simpan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(233, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Print";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(4, 237);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(275, 20);
            this.textBox3.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Image = global::AplikasiLaporanKegiatanEkstraKurikuler.Properties.Resources.search;
            this.button3.Location = new System.Drawing.Point(285, 235);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(23, 23);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button4_Click);
            // 
            // dgv_kegiatan
            // 
            this.dgv_kegiatan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_kegiatan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id,
            this.col_nama_kegiatan,
            this.col_guru,
            this.col_hari,
            this.col_jam});
            this.dgv_kegiatan.Location = new System.Drawing.Point(4, 264);
            this.dgv_kegiatan.Name = "dgv_kegiatan";
            this.dgv_kegiatan.Size = new System.Drawing.Size(756, 226);
            this.dgv_kegiatan.TabIndex = 7;
            // 
            // col_id
            // 
            this.col_id.HeaderText = "ID Kegiatan";
            this.col_id.Name = "col_id";
            this.col_id.Width = 130;
            // 
            // col_nama_kegiatan
            // 
            this.col_nama_kegiatan.HeaderText = "Nama Kegiatan";
            this.col_nama_kegiatan.Name = "col_nama_kegiatan";
            this.col_nama_kegiatan.Width = 160;
            // 
            // col_guru
            // 
            this.col_guru.HeaderText = "Guru Pembimbing";
            this.col_guru.Name = "col_guru";
            this.col_guru.Width = 200;
            // 
            // col_hari
            // 
            this.col_hari.HeaderText = "Hari";
            this.col_hari.Name = "col_hari";
            // 
            // col_jam
            // 
            this.col_jam.HeaderText = "Jam";
            this.col_jam.Name = "col_jam";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "ID Kegiatan";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(108, 32);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(200, 20);
            this.textBox4.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Pilih Kegiatan";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(389, 6);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(183, 21);
            this.comboBox3.TabIndex = 6;
            // 
            // dgv_siswa
            // 
            this.dgv_siswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_siswa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_nis,
            this.col_nama_siswa,
            this.col_kelas});
            this.dgv_siswa.Location = new System.Drawing.Point(314, 32);
            this.dgv_siswa.Name = "dgv_siswa";
            this.dgv_siswa.Size = new System.Drawing.Size(446, 226);
            this.dgv_siswa.TabIndex = 8;
            // 
            // col_nis
            // 
            this.col_nis.HeaderText = "NIS";
            this.col_nis.Name = "col_nis";
            // 
            // col_nama_siswa
            // 
            this.col_nama_siswa.HeaderText = "Nama Siswa";
            this.col_nama_siswa.Name = "col_nama_siswa";
            this.col_nama_siswa.Width = 200;
            // 
            // col_kelas
            // 
            this.col_kelas.HeaderText = "Kelas";
            this.col_kelas.Name = "col_kelas";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(578, 6);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(154, 20);
            this.textBox5.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.Image = global::AplikasiLaporanKegiatanEkstraKurikuler.Properties.Resources.search;
            this.button4.Location = new System.Drawing.Point(737, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(23, 23);
            this.button4.TabIndex = 6;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(128, 185);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Hapus";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button4_Click);
            // 
            // form_kegiatan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 494);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dgv_siswa);
            this.Controls.Add(this.dgv_kegiatan);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_kegiatan";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Data Kegiatan";
            this.Shown += new System.EventHandler(this.form_kegiatan_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kegiatan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_siswa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgv_kegiatan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nama_kegiatan;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_guru;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_hari;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_jam;
        private System.Windows.Forms.DataGridView dgv_siswa;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nis;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nama_siswa;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_kelas;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}