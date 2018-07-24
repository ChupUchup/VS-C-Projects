namespace wilmarTest
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnPrima = new System.Windows.Forms.Button();
            this.txtPrimaOut = new System.Windows.Forms.RichTextBox();
            this.txtPrimaIn = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblBerjalan = new System.Windows.Forms.Label();
            this.btnBerjalan = new System.Windows.Forms.Button();
            this.txtBerjalan = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtUbahOut = new System.Windows.Forms.RichTextBox();
            this.btnUbah = new System.Windows.Forms.Button();
            this.txtUbahIn = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.numericSegitigaIn = new System.Windows.Forms.NumericUpDown();
            this.txtSegitigaOut = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSegitigaIn)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(584, 261);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnPrima);
            this.tabPage1.Controls.Add(this.txtPrimaOut);
            this.tabPage1.Controls.Add(this.txtPrimaIn);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(576, 235);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Soal 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnPrima
            // 
            this.btnPrima.Location = new System.Drawing.Point(462, 4);
            this.btnPrima.Name = "btnPrima";
            this.btnPrima.Size = new System.Drawing.Size(106, 23);
            this.btnPrima.TabIndex = 2;
            this.btnPrima.Text = "List Bilangan Prima";
            this.btnPrima.UseVisualStyleBackColor = true;
            this.btnPrima.Click += new System.EventHandler(this.btnPrima_Click);
            // 
            // txtPrimaOut
            // 
            this.txtPrimaOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtPrimaOut.Location = new System.Drawing.Point(3, 32);
            this.txtPrimaOut.Name = "txtPrimaOut";
            this.txtPrimaOut.Size = new System.Drawing.Size(570, 200);
            this.txtPrimaOut.TabIndex = 1;
            this.txtPrimaOut.Text = "";
            // 
            // txtPrimaIn
            // 
            this.txtPrimaIn.Location = new System.Drawing.Point(8, 6);
            this.txtPrimaIn.Name = "txtPrimaIn";
            this.txtPrimaIn.Size = new System.Drawing.Size(448, 20);
            this.txtPrimaIn.TabIndex = 0;
            this.txtPrimaIn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrimaIn_KeyDown);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblBerjalan);
            this.tabPage2.Controls.Add(this.btnBerjalan);
            this.tabPage2.Controls.Add(this.txtBerjalan);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(576, 235);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Soal 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblBerjalan
            // 
            this.lblBerjalan.AutoSize = true;
            this.lblBerjalan.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBerjalan.Location = new System.Drawing.Point(-18, 86);
            this.lblBerjalan.Name = "lblBerjalan";
            this.lblBerjalan.Size = new System.Drawing.Size(0, 73);
            this.lblBerjalan.TabIndex = 2;
            // 
            // btnBerjalan
            // 
            this.btnBerjalan.Location = new System.Drawing.Point(469, 4);
            this.btnBerjalan.Name = "btnBerjalan";
            this.btnBerjalan.Size = new System.Drawing.Size(99, 23);
            this.btnBerjalan.TabIndex = 1;
            this.btnBerjalan.Text = "Teks Berjalan";
            this.btnBerjalan.UseVisualStyleBackColor = true;
            this.btnBerjalan.Click += new System.EventHandler(this.btnBerjalan_Click);
            // 
            // txtBerjalan
            // 
            this.txtBerjalan.Location = new System.Drawing.Point(8, 6);
            this.txtBerjalan.Name = "txtBerjalan";
            this.txtBerjalan.Size = new System.Drawing.Size(455, 20);
            this.txtBerjalan.TabIndex = 0;
            this.txtBerjalan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBerjalan_KeyDown);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtUbahOut);
            this.tabPage3.Controls.Add(this.btnUbah);
            this.tabPage3.Controls.Add(this.txtUbahIn);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(576, 235);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Soal 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtUbahOut
            // 
            this.txtUbahOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtUbahOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUbahOut.Location = new System.Drawing.Point(0, 33);
            this.txtUbahOut.Name = "txtUbahOut";
            this.txtUbahOut.Size = new System.Drawing.Size(576, 202);
            this.txtUbahOut.TabIndex = 2;
            this.txtUbahOut.Text = "";
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(444, 4);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(124, 23);
            this.btnUbah.TabIndex = 1;
            this.btnUbah.Text = "Ubah Menjadi Kalimat";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // txtUbahIn
            // 
            this.txtUbahIn.Location = new System.Drawing.Point(8, 6);
            this.txtUbahIn.Name = "txtUbahIn";
            this.txtUbahIn.Size = new System.Drawing.Size(430, 20);
            this.txtUbahIn.TabIndex = 0;
            this.txtUbahIn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUbahIn_KeyDown);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtSegitigaOut);
            this.tabPage4.Controls.Add(this.numericSegitigaIn);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(576, 235);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Soal 4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // numericSegitigaIn
            // 
            this.numericSegitigaIn.Location = new System.Drawing.Point(8, 6);
            this.numericSegitigaIn.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericSegitigaIn.Name = "numericSegitigaIn";
            this.numericSegitigaIn.Size = new System.Drawing.Size(120, 20);
            this.numericSegitigaIn.TabIndex = 0;
            this.numericSegitigaIn.ValueChanged += new System.EventHandler(this.numericSegitigaIn_ValueChanged);
            // 
            // txtSegitigaOut
            // 
            this.txtSegitigaOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtSegitigaOut.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegitigaOut.Location = new System.Drawing.Point(0, 33);
            this.txtSegitigaOut.Name = "txtSegitigaOut";
            this.txtSegitigaOut.Size = new System.Drawing.Size(576, 202);
            this.txtSegitigaOut.TabIndex = 2;
            this.txtSegitigaOut.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Wilmar Test";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericSegitigaIn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnPrima;
        private System.Windows.Forms.RichTextBox txtPrimaOut;
        private System.Windows.Forms.TextBox txtPrimaIn;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lblBerjalan;
        private System.Windows.Forms.Button btnBerjalan;
        private System.Windows.Forms.TextBox txtBerjalan;
        private System.Windows.Forms.RichTextBox txtUbahOut;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.TextBox txtUbahIn;
        private System.Windows.Forms.NumericUpDown numericSegitigaIn;
        private System.Windows.Forms.RichTextBox txtSegitigaOut;
    }
}

