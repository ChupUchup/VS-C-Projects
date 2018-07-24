namespace WindowsFormsApplication3
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
            this.btn_hook = new System.Windows.Forms.Button();
            this.txt_x = new System.Windows.Forms.TextBox();
            this.txt_y = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.list_pos = new System.Windows.Forms.ListView();
            this.col_x = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_y = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_process = new System.Windows.Forms.ListView();
            this.col_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.radio_kiri = new System.Windows.Forms.RadioButton();
            this.radio_kanan = new System.Windows.Forms.RadioButton();
            this.btn_help = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.num_interval = new System.Windows.Forms.NumericUpDown();
            this.txt_repeat = new System.Windows.Forms.TextBox();
            this.lbl_count = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_interval)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_hook
            // 
            this.btn_hook.BackColor = System.Drawing.Color.Lime;
            this.btn_hook.Location = new System.Drawing.Point(139, 10);
            this.btn_hook.Name = "btn_hook";
            this.btn_hook.Size = new System.Drawing.Size(75, 23);
            this.btn_hook.TabIndex = 0;
            this.btn_hook.Text = "Start Hook";
            this.btn_hook.UseVisualStyleBackColor = false;
            this.btn_hook.Click += new System.EventHandler(this.btn_hook_Click);
            // 
            // txt_x
            // 
            this.txt_x.Enabled = false;
            this.txt_x.Location = new System.Drawing.Point(38, 12);
            this.txt_x.Name = "txt_x";
            this.txt_x.Size = new System.Drawing.Size(32, 20);
            this.txt_x.TabIndex = 1;
            // 
            // txt_y
            // 
            this.txt_y.Enabled = false;
            this.txt_y.Location = new System.Drawing.Point(101, 12);
            this.txt_y.Name = "txt_y";
            this.txt_y.Size = new System.Drawing.Size(32, 20);
            this.txt_y.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "X :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y :";
            // 
            // list_pos
            // 
            this.list_pos.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.list_pos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_x,
            this.col_y});
            this.list_pos.FullRowSelect = true;
            this.list_pos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.list_pos.Location = new System.Drawing.Point(12, 39);
            this.list_pos.MultiSelect = false;
            this.list_pos.Name = "list_pos";
            this.list_pos.Size = new System.Drawing.Size(260, 97);
            this.list_pos.TabIndex = 5;
            this.list_pos.UseCompatibleStateImageBehavior = false;
            this.list_pos.View = System.Windows.Forms.View.Details;
            // 
            // col_x
            // 
            this.col_x.Text = "Posisi X";
            this.col_x.Width = 115;
            // 
            // col_y
            // 
            this.col_y.Text = "Posisi Y";
            this.col_y.Width = 115;
            // 
            // list_process
            // 
            this.list_process.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.list_process.CheckBoxes = true;
            this.list_process.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_name,
            this.col_id});
            this.list_process.FullRowSelect = true;
            this.list_process.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.list_process.Location = new System.Drawing.Point(12, 166);
            this.list_process.MultiSelect = false;
            this.list_process.Name = "list_process";
            this.list_process.Size = new System.Drawing.Size(260, 97);
            this.list_process.TabIndex = 7;
            this.list_process.UseCompatibleStateImageBehavior = false;
            this.list_process.View = System.Windows.Forms.View.Details;
            this.list_process.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.list_process_ItemChecked);
            // 
            // col_name
            // 
            this.col_name.Text = "Process Name";
            this.col_name.Width = 115;
            // 
            // col_id
            // 
            this.col_id.Text = "Process Id";
            this.col_id.Width = 115;
            // 
            // radio_kiri
            // 
            this.radio_kiri.AutoSize = true;
            this.radio_kiri.BackColor = System.Drawing.SystemColors.Control;
            this.radio_kiri.Checked = true;
            this.radio_kiri.Location = new System.Drawing.Point(12, 143);
            this.radio_kiri.Name = "radio_kiri";
            this.radio_kiri.Size = new System.Drawing.Size(31, 17);
            this.radio_kiri.TabIndex = 8;
            this.radio_kiri.TabStop = true;
            this.radio_kiri.Text = "L";
            this.radio_kiri.UseVisualStyleBackColor = false;
            // 
            // radio_kanan
            // 
            this.radio_kanan.AutoSize = true;
            this.radio_kanan.Location = new System.Drawing.Point(49, 143);
            this.radio_kanan.Name = "radio_kanan";
            this.radio_kanan.Size = new System.Drawing.Size(31, 17);
            this.radio_kanan.TabIndex = 9;
            this.radio_kanan.Text = "R";
            this.radio_kanan.UseVisualStyleBackColor = true;
            // 
            // btn_help
            // 
            this.btn_help.BackColor = System.Drawing.Color.Aqua;
            this.btn_help.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_help.FlatAppearance.BorderSize = 0;
            this.btn_help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_help.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_help.Location = new System.Drawing.Point(249, 139);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(23, 23);
            this.btn_help.TabIndex = 10;
            this.btn_help.Text = "?";
            this.btn_help.UseVisualStyleBackColor = false;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Detik";
            // 
            // num_interval
            // 
            this.num_interval.DecimalPlaces = 1;
            this.num_interval.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_interval.Location = new System.Drawing.Point(86, 141);
            this.num_interval.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.num_interval.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            196608});
            this.num_interval.Name = "num_interval";
            this.num_interval.Size = new System.Drawing.Size(52, 20);
            this.num_interval.TabIndex = 12;
            this.num_interval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txt_repeat
            // 
            this.txt_repeat.Location = new System.Drawing.Point(182, 141);
            this.txt_repeat.Name = "txt_repeat";
            this.txt_repeat.Size = new System.Drawing.Size(32, 20);
            this.txt_repeat.TabIndex = 13;
            this.txt_repeat.Text = "1";
            this.txt_repeat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_repeat_KeyPress);
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Location = new System.Drawing.Point(216, 145);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(19, 13);
            this.lbl_count.TabIndex = 14;
            this.lbl_count.Text = "/0";
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(220, 10);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(52, 23);
            this.btn_reset.TabIndex = 15;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 272);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.lbl_count);
            this.Controls.Add(this.txt_repeat);
            this.Controls.Add(this.num_interval);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.radio_kanan);
            this.Controls.Add(this.radio_kiri);
            this.Controls.Add(this.list_process);
            this.Controls.Add(this.list_pos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_y);
            this.Controls.Add(this.txt_x);
            this.Controls.Add(this.btn_hook);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uhuk";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.num_interval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_hook;
        private System.Windows.Forms.TextBox txt_x;
        private System.Windows.Forms.TextBox txt_y;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView list_pos;
        private System.Windows.Forms.ColumnHeader col_x;
        private System.Windows.Forms.ColumnHeader col_y;
        private System.Windows.Forms.ListView list_process;
        private System.Windows.Forms.RadioButton radio_kiri;
        private System.Windows.Forms.RadioButton radio_kanan;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.ColumnHeader col_name;
        private System.Windows.Forms.ColumnHeader col_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown num_interval;
        private System.Windows.Forms.TextBox txt_repeat;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.Button btn_reset;
    }
}

