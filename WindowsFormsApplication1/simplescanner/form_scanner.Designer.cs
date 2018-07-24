namespace simplescanner
{
    partial class form_scanner
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
            this.btn_target = new System.Windows.Forms.Button();
            this.txt_target = new System.Windows.Forms.TextBox();
            this.combo_scan_type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_start = new System.Windows.Forms.TextBox();
            this.txt_end = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_scan = new System.Windows.Forms.Button();
            this.txt_scan_result = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_target
            // 
            this.btn_target.Location = new System.Drawing.Point(12, 12);
            this.btn_target.Name = "btn_target";
            this.btn_target.Size = new System.Drawing.Size(99, 23);
            this.btn_target.TabIndex = 0;
            this.btn_target.Text = "Target Process";
            this.btn_target.UseVisualStyleBackColor = true;
            this.btn_target.Click += new System.EventHandler(this.btn_target_Click);
            // 
            // txt_target
            // 
            this.txt_target.Enabled = false;
            this.txt_target.Location = new System.Drawing.Point(117, 14);
            this.txt_target.Name = "txt_target";
            this.txt_target.Size = new System.Drawing.Size(155, 20);
            this.txt_target.TabIndex = 1;
            this.txt_target.TextChanged += new System.EventHandler(this.txt_target_TextChanged);
            // 
            // combo_scan_type
            // 
            this.combo_scan_type.FormattingEnabled = true;
            this.combo_scan_type.Location = new System.Drawing.Point(50, 66);
            this.combo_scan_type.Name = "combo_scan_type";
            this.combo_scan_type.Size = new System.Drawing.Size(222, 21);
            this.combo_scan_type.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Type";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Value";
            // 
            // txt_start
            // 
            this.txt_start.Enabled = false;
            this.txt_start.Location = new System.Drawing.Point(50, 40);
            this.txt_start.Name = "txt_start";
            this.txt_start.Size = new System.Drawing.Size(98, 20);
            this.txt_start.TabIndex = 1;
            this.txt_start.TextChanged += new System.EventHandler(this.txt_target_TextChanged);
            // 
            // txt_end
            // 
            this.txt_end.Enabled = false;
            this.txt_end.Location = new System.Drawing.Point(174, 40);
            this.txt_end.Name = "txt_end";
            this.txt_end.Size = new System.Drawing.Size(98, 20);
            this.txt_end.TabIndex = 1;
            this.txt_end.TextChanged += new System.EventHandler(this.txt_target_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "To";
            // 
            // btn_scan
            // 
            this.btn_scan.Location = new System.Drawing.Point(197, 119);
            this.btn_scan.Name = "btn_scan";
            this.btn_scan.Size = new System.Drawing.Size(75, 23);
            this.btn_scan.TabIndex = 5;
            this.btn_scan.Text = "Scan";
            this.btn_scan.UseVisualStyleBackColor = true;
            this.btn_scan.Click += new System.EventHandler(this.btn_scan_Click);
            // 
            // txt_scan_result
            // 
            this.txt_scan_result.Location = new System.Drawing.Point(11, 148);
            this.txt_scan_result.Name = "txt_scan_result";
            this.txt_scan_result.Size = new System.Drawing.Size(261, 205);
            this.txt_scan_result.TabIndex = 6;
            this.txt_scan_result.Text = "";
            this.txt_scan_result.WordWrap = false;
            // 
            // form_scanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 365);
            this.Controls.Add(this.txt_scan_result);
            this.Controls.Add(this.btn_scan);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_scan_type);
            this.Controls.Add(this.txt_end);
            this.Controls.Add(this.txt_start);
            this.Controls.Add(this.txt_target);
            this.Controls.Add(this.btn_target);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "form_scanner";
            this.Text = "Simple Scanner";
            this.Shown += new System.EventHandler(this.form_scanner_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_target;
        public System.Windows.Forms.TextBox txt_target;
        private System.Windows.Forms.ComboBox combo_scan_type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_start;
        public System.Windows.Forms.TextBox txt_end;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_scan;
        private System.Windows.Forms.RichTextBox txt_scan_result;
    }
}