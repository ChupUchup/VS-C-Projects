namespace RNG
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
            this.list_hsl = new System.Windows.Forms.ListBox();
            this.combo_persen = new System.Windows.Forms.ComboBox();
            this.btn_test = new System.Windows.Forms.Button();
            this.combo_range = new System.Windows.Forms.ComboBox();
            this.text_gagal = new System.Windows.Forms.TextBox();
            this.text_sukses = new System.Windows.Forms.TextBox();
            this.text_total = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.text_prob = new System.Windows.Forms.TextBox();
            this.check_normal = new System.Windows.Forms.CheckBox();
            this.check_tumbal = new System.Windows.Forms.CheckBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_hsl
            // 
            this.list_hsl.FormattingEnabled = true;
            this.list_hsl.Location = new System.Drawing.Point(12, 12);
            this.list_hsl.Name = "list_hsl";
            this.list_hsl.Size = new System.Drawing.Size(120, 264);
            this.list_hsl.TabIndex = 0;
            // 
            // combo_persen
            // 
            this.combo_persen.FormattingEnabled = true;
            this.combo_persen.Location = new System.Drawing.Point(138, 37);
            this.combo_persen.Name = "combo_persen";
            this.combo_persen.Size = new System.Drawing.Size(75, 21);
            this.combo_persen.TabIndex = 1;
            this.combo_persen.Text = "Persentasi";
            // 
            // btn_test
            // 
            this.btn_test.Location = new System.Drawing.Point(138, 109);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(75, 30);
            this.btn_test.TabIndex = 2;
            this.btn_test.Text = "Test";
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // combo_range
            // 
            this.combo_range.FormattingEnabled = true;
            this.combo_range.Location = new System.Drawing.Point(138, 10);
            this.combo_range.Name = "combo_range";
            this.combo_range.Size = new System.Drawing.Size(75, 21);
            this.combo_range.TabIndex = 3;
            this.combo_range.Text = "Range";
            // 
            // text_gagal
            // 
            this.text_gagal.Enabled = false;
            this.text_gagal.Location = new System.Drawing.Point(178, 171);
            this.text_gagal.Name = "text_gagal";
            this.text_gagal.Size = new System.Drawing.Size(35, 20);
            this.text_gagal.TabIndex = 4;
            // 
            // text_sukses
            // 
            this.text_sukses.Enabled = false;
            this.text_sukses.Location = new System.Drawing.Point(178, 145);
            this.text_sukses.Name = "text_sukses";
            this.text_sukses.Size = new System.Drawing.Size(35, 20);
            this.text_sukses.TabIndex = 5;
            // 
            // text_total
            // 
            this.text_total.Enabled = false;
            this.text_total.Location = new System.Drawing.Point(178, 197);
            this.text_total.Name = "text_total";
            this.text_total.Size = new System.Drawing.Size(35, 20);
            this.text_total.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sukses";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Gagal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Total";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(135, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Prob";
            // 
            // text_prob
            // 
            this.text_prob.Enabled = false;
            this.text_prob.Location = new System.Drawing.Point(178, 223);
            this.text_prob.Name = "text_prob";
            this.text_prob.Size = new System.Drawing.Size(35, 20);
            this.text_prob.TabIndex = 10;
            // 
            // check_normal
            // 
            this.check_normal.AutoSize = true;
            this.check_normal.Checked = true;
            this.check_normal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_normal.Location = new System.Drawing.Point(138, 63);
            this.check_normal.Name = "check_normal";
            this.check_normal.Size = new System.Drawing.Size(59, 17);
            this.check_normal.TabIndex = 12;
            this.check_normal.Text = "Normal";
            this.check_normal.UseVisualStyleBackColor = true;
            this.check_normal.CheckedChanged += new System.EventHandler(this.check_normal_CheckedChanged);
            // 
            // check_tumbal
            // 
            this.check_tumbal.AutoSize = true;
            this.check_tumbal.Location = new System.Drawing.Point(138, 86);
            this.check_tumbal.Name = "check_tumbal";
            this.check_tumbal.Size = new System.Drawing.Size(61, 17);
            this.check_tumbal.TabIndex = 13;
            this.check_tumbal.Text = "Tumbal";
            this.check_tumbal.UseVisualStyleBackColor = true;
            this.check_tumbal.CheckedChanged += new System.EventHandler(this.check_tumbal_CheckedChanged);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(138, 249);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 30);
            this.btn_reset.TabIndex = 14;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 286);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.check_tumbal);
            this.Controls.Add(this.check_normal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_prob);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_total);
            this.Controls.Add(this.text_sukses);
            this.Controls.Add(this.text_gagal);
            this.Controls.Add(this.combo_range);
            this.Controls.Add(this.btn_test);
            this.Controls.Add(this.combo_persen);
            this.Controls.Add(this.list_hsl);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RNG Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list_hsl;
        private System.Windows.Forms.ComboBox combo_persen;
        private System.Windows.Forms.Button btn_test;
        private System.Windows.Forms.ComboBox combo_range;
        private System.Windows.Forms.TextBox text_gagal;
        private System.Windows.Forms.TextBox text_sukses;
        private System.Windows.Forms.TextBox text_total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_prob;
        private System.Windows.Forms.CheckBox check_normal;
        private System.Windows.Forms.CheckBox check_tumbal;
        private System.Windows.Forms.Button btn_reset;
    }
}

