namespace HM_Gift
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
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menu_right_click = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menu_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_open = new System.Windows.Forms.Button();
            this.lbl_count = new System.Windows.Forms.Label();
            this.pase_1 = new System.Windows.Forms.RadioButton();
            this.pase_2 = new System.Windows.Forms.RadioButton();
            this.pase_3 = new System.Windows.Forms.RadioButton();
            this.pase_4 = new System.Windows.Forms.RadioButton();
            this.pase_5 = new System.Windows.Forms.RadioButton();
            this.pase_6 = new System.Windows.Forms.RadioButton();
            this.pase_7 = new System.Windows.Forms.RadioButton();
            this.check_write = new System.Windows.Forms.CheckBox();
            this.btn_input = new System.Windows.Forms.Button();
            this.menu_right_click.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(667, 305);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // listBox1
            // 
            this.listBox1.ContextMenuStrip = this.menu_right_click;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(0, 305);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(574, 306);
            this.listBox1.TabIndex = 1;
            // 
            // menu_right_click
            // 
            this.menu_right_click.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_delete});
            this.menu_right_click.Name = "menu_right_click";
            this.menu_right_click.Size = new System.Drawing.Size(187, 26);
            // 
            // menu_delete
            // 
            this.menu_delete.Name = "menu_delete";
            this.menu_delete.Size = new System.Drawing.Size(186, 22);
            this.menu_delete.Text = "Delete Selected Items";
            this.menu_delete.Click += new System.EventHandler(this.menu_delete_Click);
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(580, 311);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(75, 25);
            this.btn_open.TabIndex = 4;
            this.btn_open.Text = "Open Data";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Location = new System.Drawing.Point(580, 589);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(44, 13);
            this.lbl_count.TabIndex = 5;
            this.lbl_count.Text = "Count : ";
            // 
            // pase_1
            // 
            this.pase_1.AutoSize = true;
            this.pase_1.Location = new System.Drawing.Point(580, 392);
            this.pase_1.Name = "pase_1";
            this.pase_1.Size = new System.Drawing.Size(62, 17);
            this.pase_1.TabIndex = 6;
            this.pase_1.TabStop = true;
            this.pase_1.Text = "to lower";
            this.pase_1.UseVisualStyleBackColor = true;
            // 
            // pase_2
            // 
            this.pase_2.AutoSize = true;
            this.pase_2.Location = new System.Drawing.Point(580, 415);
            this.pase_2.Name = "pase_2";
            this.pase_2.Size = new System.Drawing.Size(50, 17);
            this.pase_2.TabIndex = 6;
            this.pase_2.TabStop = true;
            this.pase_2.Text = "trim 1";
            this.pase_2.UseVisualStyleBackColor = true;
            // 
            // pase_3
            // 
            this.pase_3.AutoSize = true;
            this.pase_3.Location = new System.Drawing.Point(580, 438);
            this.pase_3.Name = "pase_3";
            this.pase_3.Size = new System.Drawing.Size(53, 17);
            this.pase_3.TabIndex = 6;
            this.pase_3.TabStop = true;
            this.pase_3.Text = "filter 1";
            this.pase_3.UseVisualStyleBackColor = true;
            // 
            // pase_4
            // 
            this.pase_4.AutoSize = true;
            this.pase_4.Location = new System.Drawing.Point(580, 461);
            this.pase_4.Name = "pase_4";
            this.pase_4.Size = new System.Drawing.Size(50, 17);
            this.pase_4.TabIndex = 6;
            this.pase_4.TabStop = true;
            this.pase_4.Text = "trim 2";
            this.pase_4.UseVisualStyleBackColor = true;
            // 
            // pase_5
            // 
            this.pase_5.AutoSize = true;
            this.pase_5.Location = new System.Drawing.Point(580, 484);
            this.pase_5.Name = "pase_5";
            this.pase_5.Size = new System.Drawing.Size(92, 17);
            this.pase_5.TabIndex = 6;
            this.pase_5.TabStop = true;
            this.pase_5.Text = "change \"and\"";
            this.pase_5.UseVisualStyleBackColor = true;
            // 
            // pase_6
            // 
            this.pase_6.AutoSize = true;
            this.pase_6.Location = new System.Drawing.Point(580, 507);
            this.pase_6.Name = "pase_6";
            this.pase_6.Size = new System.Drawing.Size(61, 17);
            this.pase_6.TabIndex = 6;
            this.pase_6.TabStop = true;
            this.pase_6.Text = "gabung";
            this.pase_6.UseVisualStyleBackColor = true;
            // 
            // pase_7
            // 
            this.pase_7.AutoSize = true;
            this.pase_7.Location = new System.Drawing.Point(580, 530);
            this.pase_7.Name = "pase_7";
            this.pase_7.Size = new System.Drawing.Size(44, 17);
            this.pase_7.TabIndex = 6;
            this.pase_7.TabStop = true;
            this.pase_7.Text = "final";
            this.pase_7.UseVisualStyleBackColor = true;
            // 
            // check_write
            // 
            this.check_write.AutoSize = true;
            this.check_write.Location = new System.Drawing.Point(580, 569);
            this.check_write.Name = "check_write";
            this.check_write.Size = new System.Drawing.Size(51, 17);
            this.check_write.TabIndex = 7;
            this.check_write.Text = "Write";
            this.check_write.UseVisualStyleBackColor = true;
            // 
            // btn_input
            // 
            this.btn_input.Location = new System.Drawing.Point(580, 342);
            this.btn_input.Name = "btn_input";
            this.btn_input.Size = new System.Drawing.Size(75, 25);
            this.btn_input.TabIndex = 8;
            this.btn_input.Text = "Input Data";
            this.btn_input.UseVisualStyleBackColor = true;
            this.btn_input.Click += new System.EventHandler(this.btn_input_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 611);
            this.Controls.Add(this.btn_input);
            this.Controls.Add(this.check_write);
            this.Controls.Add(this.pase_7);
            this.Controls.Add(this.pase_6);
            this.Controls.Add(this.pase_5);
            this.Controls.Add(this.pase_4);
            this.Controls.Add(this.pase_3);
            this.Controls.Add(this.pase_2);
            this.Controls.Add(this.pase_1);
            this.Controls.Add(this.lbl_count);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu_right_click.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ContextMenuStrip menu_right_click;
        private System.Windows.Forms.ToolStripMenuItem menu_delete;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.RadioButton pase_1;
        private System.Windows.Forms.RadioButton pase_2;
        private System.Windows.Forms.RadioButton pase_3;
        private System.Windows.Forms.RadioButton pase_4;
        private System.Windows.Forms.RadioButton pase_5;
        private System.Windows.Forms.RadioButton pase_6;
        private System.Windows.Forms.RadioButton pase_7;
        private System.Windows.Forms.CheckBox check_write;
        private System.Windows.Forms.Button btn_input;
    }
}

