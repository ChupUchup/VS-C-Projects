namespace simplescanner
{
    partial class form_process_list
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
            this.list_process = new System.Windows.Forms.ListView();
            this.col_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_hwnd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // list_process
            // 
            this.list_process.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_process.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_name,
            this.col_time,
            this.col_id,
            this.col_hwnd});
            this.list_process.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_process.FullRowSelect = true;
            this.list_process.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.list_process.Location = new System.Drawing.Point(0, 0);
            this.list_process.MultiSelect = false;
            this.list_process.Name = "list_process";
            this.list_process.Size = new System.Drawing.Size(364, 261);
            this.list_process.TabIndex = 0;
            this.list_process.UseCompatibleStateImageBehavior = false;
            this.list_process.View = System.Windows.Forms.View.Details;
            this.list_process.DoubleClick += new System.EventHandler(this.list_process_DoubleClick);
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
            // col_hwnd
            // 
            this.col_hwnd.Text = "Handle";
            this.col_hwnd.Width = 80;
            // 
            // form_process_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 261);
            this.Controls.Add(this.list_process);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_process_list";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Process List";
            this.Shown += new System.EventHandler(this.form_process_list_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView list_process;
        private System.Windows.Forms.ColumnHeader col_name;
        private System.Windows.Forms.ColumnHeader col_time;
        private System.Windows.Forms.ColumnHeader col_id;
        private System.Windows.Forms.ColumnHeader col_hwnd;
    }
}