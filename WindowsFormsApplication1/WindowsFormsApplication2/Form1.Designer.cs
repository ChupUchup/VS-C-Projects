namespace WindowsFormsApplication2
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
            this.btn_spam = new System.Windows.Forms.Button();
            this.txt_x = new System.Windows.Forms.TextBox();
            this.txt_y = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_y_hex = new System.Windows.Forms.TextBox();
            this.txt_x_hex = new System.Windows.Forms.TextBox();
            this.list_pos = new System.Windows.Forms.ListView();
            this.col_x = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_y = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.pos_y_1_h = new System.Windows.Forms.TextBox();
            this.pos_x_1_h = new System.Windows.Forms.TextBox();
            this.btn_pos_1 = new System.Windows.Forms.Button();
            this.btn_pos_2 = new System.Windows.Forms.Button();
            this.pos_y_2_h = new System.Windows.Forms.TextBox();
            this.pos_x_2_h = new System.Windows.Forms.TextBox();
            this.btn_pos_3 = new System.Windows.Forms.Button();
            this.pos_y_3_h = new System.Windows.Forms.TextBox();
            this.pos_x_3_h = new System.Windows.Forms.TextBox();
            this.pos_x_1 = new System.Windows.Forms.NumericUpDown();
            this.pos_y_1 = new System.Windows.Forms.NumericUpDown();
            this.pos_y_2 = new System.Windows.Forms.NumericUpDown();
            this.pos_x_2 = new System.Windows.Forms.NumericUpDown();
            this.pos_y_3 = new System.Windows.Forms.NumericUpDown();
            this.pos_x_3 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pos_x_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pos_y_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pos_y_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pos_x_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pos_y_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pos_x_3)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_spam
            // 
            this.btn_spam.BackColor = System.Drawing.Color.Lime;
            this.btn_spam.Location = new System.Drawing.Point(32, 58);
            this.btn_spam.Name = "btn_spam";
            this.btn_spam.Size = new System.Drawing.Size(75, 23);
            this.btn_spam.TabIndex = 0;
            this.btn_spam.Text = "Start";
            this.btn_spam.UseVisualStyleBackColor = false;
            this.btn_spam.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_x
            // 
            this.txt_x.Location = new System.Drawing.Point(32, 6);
            this.txt_x.Name = "txt_x";
            this.txt_x.Size = new System.Drawing.Size(75, 20);
            this.txt_x.TabIndex = 1;
            this.txt_x.Text = "0";
            // 
            // txt_y
            // 
            this.txt_y.Location = new System.Drawing.Point(32, 32);
            this.txt_y.Name = "txt_y";
            this.txt_y.Size = new System.Drawing.Size(75, 20);
            this.txt_y.TabIndex = 2;
            this.txt_y.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y";
            // 
            // txt_y_hex
            // 
            this.txt_y_hex.Location = new System.Drawing.Point(113, 32);
            this.txt_y_hex.Name = "txt_y_hex";
            this.txt_y_hex.Size = new System.Drawing.Size(75, 20);
            this.txt_y_hex.TabIndex = 6;
            this.txt_y_hex.Text = "0";
            // 
            // txt_x_hex
            // 
            this.txt_x_hex.Location = new System.Drawing.Point(113, 6);
            this.txt_x_hex.Name = "txt_x_hex";
            this.txt_x_hex.Size = new System.Drawing.Size(75, 20);
            this.txt_x_hex.TabIndex = 5;
            this.txt_x_hex.Text = "0";
            // 
            // list_pos
            // 
            this.list_pos.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.list_pos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_x,
            this.col_y});
            this.list_pos.FullRowSelect = true;
            this.list_pos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.list_pos.Location = new System.Drawing.Point(15, 87);
            this.list_pos.Name = "list_pos";
            this.list_pos.Size = new System.Drawing.Size(262, 156);
            this.list_pos.TabIndex = 7;
            this.list_pos.UseCompatibleStateImageBehavior = false;
            this.list_pos.View = System.Windows.Forms.View.Details;
            // 
            // col_x
            // 
            this.col_x.Text = "Position X";
            this.col_x.Width = 120;
            // 
            // col_y
            // 
            this.col_y.Text = "Position Y";
            this.col_y.Width = 120;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pos_y_1_h
            // 
            this.pos_y_1_h.Enabled = false;
            this.pos_y_1_h.Location = new System.Drawing.Point(683, 27);
            this.pos_y_1_h.Name = "pos_y_1_h";
            this.pos_y_1_h.Size = new System.Drawing.Size(53, 20);
            this.pos_y_1_h.TabIndex = 12;
            this.pos_y_1_h.Text = "0000";
            // 
            // pos_x_1_h
            // 
            this.pos_x_1_h.Enabled = false;
            this.pos_x_1_h.Location = new System.Drawing.Point(624, 27);
            this.pos_x_1_h.Name = "pos_x_1_h";
            this.pos_x_1_h.Size = new System.Drawing.Size(53, 20);
            this.pos_x_1_h.TabIndex = 11;
            this.pos_x_1_h.Text = "0000";
            // 
            // btn_pos_1
            // 
            this.btn_pos_1.Location = new System.Drawing.Point(742, 25);
            this.btn_pos_1.Name = "btn_pos_1";
            this.btn_pos_1.Size = new System.Drawing.Size(75, 23);
            this.btn_pos_1.TabIndex = 13;
            this.btn_pos_1.Text = "Klik Pos 1";
            this.btn_pos_1.UseVisualStyleBackColor = true;
            this.btn_pos_1.Click += new System.EventHandler(this.btn_pos_1_Click);
            // 
            // btn_pos_2
            // 
            this.btn_pos_2.Location = new System.Drawing.Point(742, 54);
            this.btn_pos_2.Name = "btn_pos_2";
            this.btn_pos_2.Size = new System.Drawing.Size(75, 23);
            this.btn_pos_2.TabIndex = 18;
            this.btn_pos_2.Text = "Klik Pos 2";
            this.btn_pos_2.UseVisualStyleBackColor = true;
            this.btn_pos_2.Click += new System.EventHandler(this.btn_pos_2_Click);
            // 
            // pos_y_2_h
            // 
            this.pos_y_2_h.Enabled = false;
            this.pos_y_2_h.Location = new System.Drawing.Point(683, 56);
            this.pos_y_2_h.Name = "pos_y_2_h";
            this.pos_y_2_h.Size = new System.Drawing.Size(53, 20);
            this.pos_y_2_h.TabIndex = 17;
            this.pos_y_2_h.Text = "0000";
            // 
            // pos_x_2_h
            // 
            this.pos_x_2_h.Enabled = false;
            this.pos_x_2_h.Location = new System.Drawing.Point(624, 56);
            this.pos_x_2_h.Name = "pos_x_2_h";
            this.pos_x_2_h.Size = new System.Drawing.Size(53, 20);
            this.pos_x_2_h.TabIndex = 16;
            this.pos_x_2_h.Text = "0000";
            // 
            // btn_pos_3
            // 
            this.btn_pos_3.Location = new System.Drawing.Point(742, 83);
            this.btn_pos_3.Name = "btn_pos_3";
            this.btn_pos_3.Size = new System.Drawing.Size(75, 23);
            this.btn_pos_3.TabIndex = 23;
            this.btn_pos_3.Text = "Klik Pos 3";
            this.btn_pos_3.UseVisualStyleBackColor = true;
            this.btn_pos_3.Click += new System.EventHandler(this.btn_pos_3_Click);
            // 
            // pos_y_3_h
            // 
            this.pos_y_3_h.Enabled = false;
            this.pos_y_3_h.Location = new System.Drawing.Point(683, 85);
            this.pos_y_3_h.Name = "pos_y_3_h";
            this.pos_y_3_h.Size = new System.Drawing.Size(53, 20);
            this.pos_y_3_h.TabIndex = 22;
            this.pos_y_3_h.Text = "0000";
            // 
            // pos_x_3_h
            // 
            this.pos_x_3_h.Enabled = false;
            this.pos_x_3_h.Location = new System.Drawing.Point(624, 85);
            this.pos_x_3_h.Name = "pos_x_3_h";
            this.pos_x_3_h.Size = new System.Drawing.Size(53, 20);
            this.pos_x_3_h.TabIndex = 21;
            this.pos_x_3_h.Text = "0000";
            // 
            // pos_x_1
            // 
            this.pos_x_1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.pos_x_1.Location = new System.Drawing.Point(506, 28);
            this.pos_x_1.Maximum = new decimal(new int[] {
            1366,
            0,
            0,
            0});
            this.pos_x_1.Name = "pos_x_1";
            this.pos_x_1.Size = new System.Drawing.Size(53, 20);
            this.pos_x_1.TabIndex = 24;
            this.pos_x_1.ValueChanged += new System.EventHandler(this.pos_x_1_ValueChanged);
            // 
            // pos_y_1
            // 
            this.pos_y_1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.pos_y_1.Location = new System.Drawing.Point(565, 28);
            this.pos_y_1.Maximum = new decimal(new int[] {
            1366,
            0,
            0,
            0});
            this.pos_y_1.Name = "pos_y_1";
            this.pos_y_1.Size = new System.Drawing.Size(53, 20);
            this.pos_y_1.TabIndex = 25;
            this.pos_y_1.ValueChanged += new System.EventHandler(this.pos_y_1_ValueChanged);
            // 
            // pos_y_2
            // 
            this.pos_y_2.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.pos_y_2.Location = new System.Drawing.Point(565, 57);
            this.pos_y_2.Maximum = new decimal(new int[] {
            1366,
            0,
            0,
            0});
            this.pos_y_2.Name = "pos_y_2";
            this.pos_y_2.Size = new System.Drawing.Size(53, 20);
            this.pos_y_2.TabIndex = 27;
            this.pos_y_2.ValueChanged += new System.EventHandler(this.pos_y_2_ValueChanged);
            // 
            // pos_x_2
            // 
            this.pos_x_2.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.pos_x_2.Location = new System.Drawing.Point(506, 57);
            this.pos_x_2.Maximum = new decimal(new int[] {
            1366,
            0,
            0,
            0});
            this.pos_x_2.Name = "pos_x_2";
            this.pos_x_2.Size = new System.Drawing.Size(53, 20);
            this.pos_x_2.TabIndex = 26;
            this.pos_x_2.ValueChanged += new System.EventHandler(this.pos_x_2_ValueChanged);
            // 
            // pos_y_3
            // 
            this.pos_y_3.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.pos_y_3.Location = new System.Drawing.Point(565, 86);
            this.pos_y_3.Maximum = new decimal(new int[] {
            1366,
            0,
            0,
            0});
            this.pos_y_3.Name = "pos_y_3";
            this.pos_y_3.Size = new System.Drawing.Size(53, 20);
            this.pos_y_3.TabIndex = 29;
            this.pos_y_3.ValueChanged += new System.EventHandler(this.pos_y_3_ValueChanged);
            // 
            // pos_x_3
            // 
            this.pos_x_3.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.pos_x_3.Location = new System.Drawing.Point(506, 86);
            this.pos_x_3.Maximum = new decimal(new int[] {
            1366,
            0,
            0,
            0});
            this.pos_x_3.Name = "pos_x_3";
            this.pos_x_3.Size = new System.Drawing.Size(53, 20);
            this.pos_x_3.TabIndex = 28;
            this.pos_x_3.ValueChanged += new System.EventHandler(this.pos_x_3_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(526, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(586, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(690, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Y hex";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(631, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "X hex";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(499, 112);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(318, 52);
            this.richTextBox1.TabIndex = 34;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 256);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pos_y_3);
            this.Controls.Add(this.pos_x_3);
            this.Controls.Add(this.pos_y_2);
            this.Controls.Add(this.pos_x_2);
            this.Controls.Add(this.pos_y_1);
            this.Controls.Add(this.pos_x_1);
            this.Controls.Add(this.btn_pos_3);
            this.Controls.Add(this.pos_y_3_h);
            this.Controls.Add(this.pos_x_3_h);
            this.Controls.Add(this.btn_pos_2);
            this.Controls.Add(this.pos_y_2_h);
            this.Controls.Add(this.pos_x_2_h);
            this.Controls.Add(this.btn_pos_1);
            this.Controls.Add(this.pos_y_1_h);
            this.Controls.Add(this.pos_x_1_h);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.list_pos);
            this.Controls.Add(this.txt_y_hex);
            this.Controls.Add(this.txt_x_hex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_y);
            this.Controls.Add(this.txt_x);
            this.Controls.Add(this.btn_spam);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send Click";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pos_x_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pos_y_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pos_y_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pos_x_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pos_y_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pos_x_3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_spam;
        private System.Windows.Forms.TextBox txt_x;
        private System.Windows.Forms.TextBox txt_y;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_y_hex;
        private System.Windows.Forms.TextBox txt_x_hex;
        private System.Windows.Forms.ListView list_pos;
        private System.Windows.Forms.ColumnHeader col_x;
        private System.Windows.Forms.ColumnHeader col_y;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox pos_y_1_h;
        private System.Windows.Forms.TextBox pos_x_1_h;
        private System.Windows.Forms.Button btn_pos_1;
        private System.Windows.Forms.Button btn_pos_2;
        private System.Windows.Forms.TextBox pos_y_2_h;
        private System.Windows.Forms.TextBox pos_x_2_h;
        private System.Windows.Forms.Button btn_pos_3;
        private System.Windows.Forms.TextBox pos_y_3_h;
        private System.Windows.Forms.TextBox pos_x_3_h;
        private System.Windows.Forms.NumericUpDown pos_x_1;
        private System.Windows.Forms.NumericUpDown pos_y_1;
        private System.Windows.Forms.NumericUpDown pos_y_2;
        private System.Windows.Forms.NumericUpDown pos_x_2;
        private System.Windows.Forms.NumericUpDown pos_y_3;
        private System.Windows.Forms.NumericUpDown pos_x_3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

