namespace WindowsFormsApplication1
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
            this.num_interfal = new System.Windows.Forms.NumericUpDown();
            this.lbl_count = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.list_process = new System.Windows.Forms.ListView();
            this.col_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.num_interfal)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_spam
            // 
            this.btn_spam.BackColor = System.Drawing.Color.Lime;
            this.btn_spam.Location = new System.Drawing.Point(76, 83);
            this.btn_spam.Name = "btn_spam";
            this.btn_spam.Size = new System.Drawing.Size(51, 23);
            this.btn_spam.TabIndex = 0;
            this.btn_spam.Text = "Spam G";
            this.btn_spam.UseVisualStyleBackColor = false;
            this.btn_spam.Click += new System.EventHandler(this.btn_spam_Click);
            // 
            // num_interfal
            // 
            this.num_interfal.Location = new System.Drawing.Point(3, 85);
            this.num_interfal.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_interfal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_interfal.Name = "num_interfal";
            this.num_interfal.Size = new System.Drawing.Size(32, 20);
            this.num_interfal.TabIndex = 2;
            this.num_interfal.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.num_interfal.ValueChanged += new System.EventHandler(this.num_interval_ValueChange);
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Location = new System.Drawing.Point(129, 88);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(55, 13);
            this.lbl_count.TabIndex = 3;
            this.lbl_count.Text = "Count : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Detik";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(184, 83);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(57, 23);
            this.btn_refresh.TabIndex = 5;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // list_process
            // 
            this.list_process.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.list_process.CheckBoxes = true;
            this.list_process.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_name,
            this.col_id});
            this.list_process.Dock = System.Windows.Forms.DockStyle.Top;
            this.list_process.FullRowSelect = true;
            this.list_process.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.list_process.Location = new System.Drawing.Point(0, 0);
            this.list_process.Name = "list_process";
            this.list_process.Size = new System.Drawing.Size(243, 81);
            this.list_process.TabIndex = 6;
            this.list_process.UseCompatibleStateImageBehavior = false;
            this.list_process.View = System.Windows.Forms.View.Details;
            this.list_process.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.list_process_ItemChecked);
            // 
            // col_name
            // 
            this.col_name.Text = "Process Name";
            this.col_name.Width = 130;
            // 
            // col_id
            // 
            this.col_id.Text = "Process Id";
            this.col_id.Width = 92;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 108);
            this.Controls.Add(this.list_process);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_count);
            this.Controls.Add(this.num_interfal);
            this.Controls.Add(this.btn_spam);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spam Tombol G";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.num_interfal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_spam;
        private System.Windows.Forms.NumericUpDown num_interfal;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.ListView list_process;
        private System.Windows.Forms.ColumnHeader col_name;
        private System.Windows.Forms.ColumnHeader col_id;
    }
}

