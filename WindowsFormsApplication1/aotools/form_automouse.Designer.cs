namespace aotools
{
    partial class form_automouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_automouse));
            this.label5 = new System.Windows.Forms.Label();
            this.txt_c_y = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_c_x = new System.Windows.Forms.TextBox();
            this.btn_hook = new System.Windows.Forms.Button();
            this.list_pos = new System.Windows.Forms.ListView();
            this.col_x = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pos_y = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.radio_left = new System.Windows.Forms.RadioButton();
            this.radio_right = new System.Windows.Forms.RadioButton();
            this.num_delay = new System.Windows.Forms.NumericUpDown();
            this.txt_counter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_help = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_target = new System.Windows.Forms.Button();
            this.btn_run = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_delay)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Y";
            // 
            // txt_c_y
            // 
            this.txt_c_y.Enabled = false;
            this.txt_c_y.Location = new System.Drawing.Point(63, 6);
            this.txt_c_y.Name = "txt_c_y";
            this.txt_c_y.Size = new System.Drawing.Size(35, 20);
            this.txt_c_y.TabIndex = 10;
            this.txt_c_y.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "X";
            // 
            // txt_c_x
            // 
            this.txt_c_x.Enabled = false;
            this.txt_c_x.Location = new System.Drawing.Point(15, 6);
            this.txt_c_x.Name = "txt_c_x";
            this.txt_c_x.Size = new System.Drawing.Size(35, 20);
            this.txt_c_x.TabIndex = 8;
            this.txt_c_x.Text = "0";
            // 
            // btn_hook
            // 
            this.btn_hook.BackColor = System.Drawing.Color.Lime;
            this.btn_hook.Location = new System.Drawing.Point(102, 4);
            this.btn_hook.Name = "btn_hook";
            this.btn_hook.Size = new System.Drawing.Size(23, 23);
            this.btn_hook.TabIndex = 12;
            this.btn_hook.Text = "H";
            this.btn_hook.UseVisualStyleBackColor = false;
            this.btn_hook.Click += new System.EventHandler(this.btn_hook_Click);
            // 
            // list_pos
            // 
            this.list_pos.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.list_pos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_x,
            this.pos_y});
            this.list_pos.FullRowSelect = true;
            this.list_pos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.list_pos.Location = new System.Drawing.Point(5, 32);
            this.list_pos.MultiSelect = false;
            this.list_pos.Name = "list_pos";
            this.list_pos.ShowItemToolTips = true;
            this.list_pos.Size = new System.Drawing.Size(143, 76);
            this.list_pos.TabIndex = 13;
            this.list_pos.UseCompatibleStateImageBehavior = false;
            this.list_pos.View = System.Windows.Forms.View.Details;
            // 
            // col_x
            // 
            this.col_x.Text = "Posisi X";
            // 
            // pos_y
            // 
            this.pos_y.Text = "Posisi Y";
            // 
            // radio_left
            // 
            this.radio_left.AutoSize = true;
            this.radio_left.Checked = true;
            this.radio_left.Location = new System.Drawing.Point(153, 39);
            this.radio_left.Name = "radio_left";
            this.radio_left.Size = new System.Drawing.Size(31, 17);
            this.radio_left.TabIndex = 14;
            this.radio_left.TabStop = true;
            this.radio_left.Text = "L";
            this.radio_left.UseVisualStyleBackColor = true;
            // 
            // radio_right
            // 
            this.radio_right.AutoSize = true;
            this.radio_right.Location = new System.Drawing.Point(198, 39);
            this.radio_right.Name = "radio_right";
            this.radio_right.Size = new System.Drawing.Size(31, 17);
            this.radio_right.TabIndex = 15;
            this.radio_right.TabStop = true;
            this.radio_right.Text = "R";
            this.radio_right.UseVisualStyleBackColor = true;
            // 
            // num_delay
            // 
            this.num_delay.DecimalPlaces = 1;
            this.num_delay.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_delay.Location = new System.Drawing.Point(187, 62);
            this.num_delay.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.num_delay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_delay.Name = "num_delay";
            this.num_delay.Size = new System.Drawing.Size(42, 20);
            this.num_delay.TabIndex = 16;
            this.num_delay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txt_counter
            // 
            this.txt_counter.Location = new System.Drawing.Point(187, 88);
            this.txt_counter.Name = "txt_counter";
            this.txt_counter.Size = new System.Drawing.Size(42, 20);
            this.txt_counter.TabIndex = 17;
            this.txt_counter.Text = "1";
            this.txt_counter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ulang_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Delay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ulang";
            // 
            // btn_help
            // 
            this.btn_help.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_help.Location = new System.Drawing.Point(206, 4);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(23, 23);
            this.btn_help.TabIndex = 20;
            this.btn_help.Text = "?";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Image = global::aotools.Properties.Resources.reset;
            this.btn_reset.Location = new System.Drawing.Point(180, 4);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(23, 23);
            this.btn_reset.TabIndex = 24;
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_target
            // 
            this.btn_target.Image = global::aotools.Properties.Resources.gear;
            this.btn_target.Location = new System.Drawing.Point(128, 4);
            this.btn_target.Name = "btn_target";
            this.btn_target.Size = new System.Drawing.Size(23, 23);
            this.btn_target.TabIndex = 23;
            this.btn_target.UseVisualStyleBackColor = true;
            this.btn_target.Click += new System.EventHandler(this.btn_target_Click);
            // 
            // btn_run
            // 
            this.btn_run.Image = global::aotools.Properties.Resources.start;
            this.btn_run.Location = new System.Drawing.Point(154, 4);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(23, 23);
            this.btn_run.TabIndex = 22;
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // form_automouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 112);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_target);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_counter);
            this.Controls.Add(this.num_delay);
            this.Controls.Add(this.radio_right);
            this.Controls.Add(this.radio_left);
            this.Controls.Add(this.list_pos);
            this.Controls.Add(this.btn_hook);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_c_y);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_c_x);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "form_automouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "automouse";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.form_automouse_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.num_delay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_c_y;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_c_x;
        private System.Windows.Forms.Button btn_hook;
        private System.Windows.Forms.ListView list_pos;
        private System.Windows.Forms.ColumnHeader col_x;
        private System.Windows.Forms.ColumnHeader pos_y;
        private System.Windows.Forms.RadioButton radio_left;
        private System.Windows.Forms.RadioButton radio_right;
        private System.Windows.Forms.NumericUpDown num_delay;
        private System.Windows.Forms.TextBox txt_counter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.Button btn_target;
        private System.Windows.Forms.Button btn_reset;
    }
}