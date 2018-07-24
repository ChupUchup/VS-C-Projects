namespace SimulateKeyboard
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
            this.panel_control = new System.Windows.Forms.Panel();
            this.lbl_counter = new System.Windows.Forms.Label();
            this.lbl_detik = new System.Windows.Forms.Label();
            this.check_pick = new System.Windows.Forms.CheckBox();
            this.num_delay = new System.Windows.Forms.NumericUpDown();
            this.btn_help = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel_control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_delay)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_control
            // 
            this.panel_control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel_control.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_control.Controls.Add(this.lbl_counter);
            this.panel_control.Controls.Add(this.lbl_detik);
            this.panel_control.Controls.Add(this.check_pick);
            this.panel_control.Controls.Add(this.num_delay);
            this.panel_control.Controls.Add(this.btn_help);
            this.panel_control.Controls.Add(this.btn_exit);
            this.panel_control.Location = new System.Drawing.Point(0, 0);
            this.panel_control.Name = "panel_control";
            this.panel_control.Size = new System.Drawing.Size(200, 20);
            this.panel_control.TabIndex = 0;
            this.panel_control.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_control_MouseDown);
            // 
            // lbl_counter
            // 
            this.lbl_counter.AutoSize = true;
            this.lbl_counter.Location = new System.Drawing.Point(112, 2);
            this.lbl_counter.Name = "lbl_counter";
            this.lbl_counter.Size = new System.Drawing.Size(49, 13);
            this.lbl_counter.TabIndex = 5;
            this.lbl_counter.Text = "Counter";
            // 
            // lbl_detik
            // 
            this.lbl_detik.AutoSize = true;
            this.lbl_detik.Enabled = false;
            this.lbl_detik.Location = new System.Drawing.Point(40, 2);
            this.lbl_detik.Name = "lbl_detik";
            this.lbl_detik.Size = new System.Drawing.Size(25, 13);
            this.lbl_detik.TabIndex = 4;
            this.lbl_detik.Text = "dtk";
            // 
            // check_pick
            // 
            this.check_pick.AutoSize = true;
            this.check_pick.Enabled = false;
            this.check_pick.Location = new System.Drawing.Point(65, 1);
            this.check_pick.Name = "check_pick";
            this.check_pick.Size = new System.Drawing.Size(50, 17);
            this.check_pick.TabIndex = 3;
            this.check_pick.Text = "Pick";
            this.check_pick.UseVisualStyleBackColor = true;
            // 
            // num_delay
            // 
            this.num_delay.DecimalPlaces = 1;
            this.num_delay.Enabled = false;
            this.num_delay.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_delay.Location = new System.Drawing.Point(0, 0);
            this.num_delay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_delay.Name = "num_delay";
            this.num_delay.Size = new System.Drawing.Size(40, 20);
            this.num_delay.TabIndex = 2;
            this.num_delay.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.num_delay.ValueChanged += new System.EventHandler(this.num_delay_ValueChanged);
            // 
            // btn_help
            // 
            this.btn_help.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_help.Location = new System.Drawing.Point(160, -1);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(20, 20);
            this.btn_help.TabIndex = 0;
            this.btn_help.Text = "?";
            this.btn_help.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(179, -1);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(20, 20);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 50);
            this.Controls.Add(this.panel_control);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_main";
            this.TopMost = true;
            this.panel_control.ResumeLayout(false);
            this.panel_control.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_delay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_control;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.NumericUpDown num_delay;
        private System.Windows.Forms.CheckBox check_pick;
        private System.Windows.Forms.Label lbl_detik;
        private System.Windows.Forms.Label lbl_counter;
    }
}