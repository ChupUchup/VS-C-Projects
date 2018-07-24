namespace SimulateMouse
{
    partial class form_main
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "3",
            "1",
            "2"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            this.panel_utama = new System.Windows.Forms.Panel();
            this.lbl_reset = new System.Windows.Forms.Label();
            this.lbl_help = new System.Windows.Forms.Label();
            this.lbl_saverecord = new System.Windows.Forms.Label();
            this.lbl_exit = new System.Windows.Forms.Label();
            this.lbl_processlist = new System.Windows.Forms.Label();
            this.lbl_y = new System.Windows.Forms.Label();
            this.lbl_x = new System.Windows.Forms.Label();
            this.panel_record = new System.Windows.Forms.Panel();
            this.list_record = new System.Windows.Forms.ListBox();
            this.panel_processlist = new System.Windows.Forms.Panel();
            this.list_process = new System.Windows.Forms.ListView();
            this.col_nama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_startat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel_utama.SuspendLayout();
            this.panel_record.SuspendLayout();
            this.panel_processlist.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_utama
            // 
            this.panel_utama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel_utama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_utama.Controls.Add(this.lbl_reset);
            this.panel_utama.Controls.Add(this.lbl_help);
            this.panel_utama.Controls.Add(this.lbl_saverecord);
            this.panel_utama.Controls.Add(this.lbl_exit);
            this.panel_utama.Controls.Add(this.lbl_processlist);
            this.panel_utama.Controls.Add(this.lbl_y);
            this.panel_utama.Controls.Add(this.lbl_x);
            this.panel_utama.Location = new System.Drawing.Point(0, 0);
            this.panel_utama.Name = "panel_utama";
            this.panel_utama.Size = new System.Drawing.Size(190, 20);
            this.panel_utama.TabIndex = 2;
            this.panel_utama.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_utama_MouseDown);
            // 
            // lbl_reset
            // 
            this.lbl_reset.Image = global::SimulateMouse.Properties.Resources.reset_transparent;
            this.lbl_reset.Location = new System.Drawing.Point(130, -1);
            this.lbl_reset.Name = "lbl_reset";
            this.lbl_reset.Size = new System.Drawing.Size(20, 20);
            this.lbl_reset.TabIndex = 9;
            this.lbl_reset.Click += new System.EventHandler(this.lbl_reset_Click);
            this.lbl_reset.MouseEnter += new System.EventHandler(this.lbl_saverecord_MouseEnter);
            this.lbl_reset.MouseLeave += new System.EventHandler(this.lbl_saverecord_MouseLeave);
            // 
            // lbl_help
            // 
            this.lbl_help.Image = global::SimulateMouse.Properties.Resources.ask;
            this.lbl_help.Location = new System.Drawing.Point(150, -1);
            this.lbl_help.Name = "lbl_help";
            this.lbl_help.Size = new System.Drawing.Size(20, 20);
            this.lbl_help.TabIndex = 8;
            this.lbl_help.Click += new System.EventHandler(this.lbl_help_Click);
            this.lbl_help.MouseEnter += new System.EventHandler(this.lbl_saverecord_MouseEnter);
            this.lbl_help.MouseLeave += new System.EventHandler(this.lbl_saverecord_MouseLeave);
            // 
            // lbl_saverecord
            // 
            this.lbl_saverecord.Image = global::SimulateMouse.Properties.Resources.save1;
            this.lbl_saverecord.Location = new System.Drawing.Point(90, -1);
            this.lbl_saverecord.Name = "lbl_saverecord";
            this.lbl_saverecord.Size = new System.Drawing.Size(20, 20);
            this.lbl_saverecord.TabIndex = 7;
            this.lbl_saverecord.Click += new System.EventHandler(this.lbl_saverecord_Click);
            this.lbl_saverecord.MouseEnter += new System.EventHandler(this.lbl_saverecord_MouseEnter);
            this.lbl_saverecord.MouseLeave += new System.EventHandler(this.lbl_saverecord_MouseLeave);
            // 
            // lbl_exit
            // 
            this.lbl_exit.Image = global::SimulateMouse.Properties.Resources.exit;
            this.lbl_exit.Location = new System.Drawing.Point(170, -1);
            this.lbl_exit.Name = "lbl_exit";
            this.lbl_exit.Size = new System.Drawing.Size(20, 20);
            this.lbl_exit.TabIndex = 6;
            this.lbl_exit.Click += new System.EventHandler(this.lbl_exit_Click);
            this.lbl_exit.MouseEnter += new System.EventHandler(this.lbl_saverecord_MouseEnter);
            this.lbl_exit.MouseLeave += new System.EventHandler(this.lbl_saverecord_MouseLeave);
            // 
            // lbl_processlist
            // 
            this.lbl_processlist.Image = global::SimulateMouse.Properties.Resources.gear_transparent1;
            this.lbl_processlist.Location = new System.Drawing.Point(110, -1);
            this.lbl_processlist.Name = "lbl_processlist";
            this.lbl_processlist.Size = new System.Drawing.Size(20, 20);
            this.lbl_processlist.TabIndex = 5;
            this.lbl_processlist.Click += new System.EventHandler(this.lbl_processlist_Click);
            this.lbl_processlist.MouseEnter += new System.EventHandler(this.lbl_saverecord_MouseEnter);
            this.lbl_processlist.MouseLeave += new System.EventHandler(this.lbl_saverecord_MouseLeave);
            // 
            // lbl_y
            // 
            this.lbl_y.Enabled = false;
            this.lbl_y.Location = new System.Drawing.Point(45, 3);
            this.lbl_y.Name = "lbl_y";
            this.lbl_y.Size = new System.Drawing.Size(45, 13);
            this.lbl_y.TabIndex = 3;
            this.lbl_y.Text = "Y:";
            // 
            // lbl_x
            // 
            this.lbl_x.Enabled = false;
            this.lbl_x.Location = new System.Drawing.Point(0, 3);
            this.lbl_x.Name = "lbl_x";
            this.lbl_x.Size = new System.Drawing.Size(45, 13);
            this.lbl_x.TabIndex = 2;
            this.lbl_x.Text = "X:";
            // 
            // panel_record
            // 
            this.panel_record.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_record.Controls.Add(this.list_record);
            this.panel_record.Location = new System.Drawing.Point(0, 19);
            this.panel_record.Name = "panel_record";
            this.panel_record.Size = new System.Drawing.Size(110, 52);
            this.panel_record.TabIndex = 3;
            // 
            // list_record
            // 
            this.list_record.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_record.FormattingEnabled = true;
            this.list_record.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.list_record.Location = new System.Drawing.Point(0, 0);
            this.list_record.Name = "list_record";
            this.list_record.Size = new System.Drawing.Size(110, 52);
            this.list_record.TabIndex = 0;
            // 
            // panel_processlist
            // 
            this.panel_processlist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_processlist.Controls.Add(this.list_process);
            this.panel_processlist.Location = new System.Drawing.Point(109, 19);
            this.panel_processlist.Name = "panel_processlist";
            this.panel_processlist.Size = new System.Drawing.Size(150, 52);
            this.panel_processlist.TabIndex = 4;
            // 
            // list_process
            // 
            this.list_process.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.list_process.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_process.CheckBoxes = true;
            this.list_process.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_nama,
            this.col_startat});
            this.list_process.FullRowSelect = true;
            this.list_process.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.StateImageIndex = 0;
            listViewItem4.StateImageIndex = 0;
            this.list_process.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.list_process.Location = new System.Drawing.Point(0, 0);
            this.list_process.MultiSelect = false;
            this.list_process.Name = "list_process";
            this.list_process.Size = new System.Drawing.Size(150, 52);
            this.list_process.TabIndex = 0;
            this.list_process.UseCompatibleStateImageBehavior = false;
            this.list_process.View = System.Windows.Forms.View.Details;
            // 
            // col_nama
            // 
            this.col_nama.Text = "Nama";
            this.col_nama.Width = 70;
            // 
            // col_startat
            // 
            this.col_startat.Text = "StartAt";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(284, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(4, 113);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(284, 20);
            this.textBox2.TabIndex = 5;
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 155);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel_processlist);
            this.Controls.Add(this.panel_record);
            this.Controls.Add(this.panel_utama);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_main";
            this.Text = "Simulate Mouse";
            this.TopMost = true;
            this.panel_utama.ResumeLayout(false);
            this.panel_record.ResumeLayout(false);
            this.panel_processlist.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_utama;
        private System.Windows.Forms.Label lbl_y;
        private System.Windows.Forms.Label lbl_x;
        private System.Windows.Forms.Label lbl_processlist;
        private System.Windows.Forms.Label lbl_exit;
        private System.Windows.Forms.Label lbl_saverecord;
        private System.Windows.Forms.Label lbl_help;
        private System.Windows.Forms.Label lbl_reset;
        private System.Windows.Forms.Panel panel_record;
        private System.Windows.Forms.ListBox list_record;
        private System.Windows.Forms.Panel panel_processlist;
        private System.Windows.Forms.ListView list_process;
        private System.Windows.Forms.ColumnHeader col_nama;
        private System.Windows.Forms.ColumnHeader col_startat;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}