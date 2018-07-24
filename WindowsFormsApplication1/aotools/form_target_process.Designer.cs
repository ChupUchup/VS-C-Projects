namespace aotools
{
    partial class form_target_process
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_target_process));
            this.list_process = new System.Windows.Forms.ListView();
            this.col_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // list_process
            // 
            this.list_process.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.list_process.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list_process.CheckBoxes = true;
            this.list_process.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_name,
            this.col_time,
            this.col_id});
            this.list_process.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_process.FullRowSelect = true;
            this.list_process.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.list_process.Location = new System.Drawing.Point(0, 0);
            this.list_process.MultiSelect = false;
            this.list_process.Name = "list_process";
            this.list_process.ShowItemToolTips = true;
            this.list_process.Size = new System.Drawing.Size(284, 111);
            this.list_process.TabIndex = 0;
            this.list_process.UseCompatibleStateImageBehavior = false;
            this.list_process.View = System.Windows.Forms.View.Details;
            // 
            // col_name
            // 
            this.col_name.Text = "Process Name";
            this.col_name.Width = 100;
            // 
            // col_time
            // 
            this.col_time.Text = "Start Time";
            this.col_time.Width = 80;
            // 
            // col_id
            // 
            this.col_id.Text = "Process Id";
            this.col_id.Width = 80;
            // 
            // form_target_process
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.list_process);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_target_process";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "target process";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_target_process_FormClosing);
            this.Shown += new System.EventHandler(this.form_target_process_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView list_process;
        private System.Windows.Forms.ColumnHeader col_name;
        private System.Windows.Forms.ColumnHeader col_time;
        private System.Windows.Forms.ColumnHeader col_id;
    }
}