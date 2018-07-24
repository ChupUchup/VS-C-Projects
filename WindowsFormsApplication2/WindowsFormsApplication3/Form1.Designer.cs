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
            this.txt_min = new System.Windows.Forms.TextBox();
            this.txt_max = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.list_scan = new System.Windows.Forms.ListView();
            this.btn_fscan = new System.Windows.Forms.Button();
            this.btn_nscan = new System.Windows.Forms.Button();
            this.col_address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txt_min
            // 
            this.txt_min.Location = new System.Drawing.Point(82, 11);
            this.txt_min.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_min.Name = "txt_min";
            this.txt_min.Size = new System.Drawing.Size(190, 20);
            this.txt_min.TabIndex = 0;
            // 
            // txt_max
            // 
            this.txt_max.Location = new System.Drawing.Point(82, 39);
            this.txt_max.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_max.Name = "txt_max";
            this.txt_max.Size = new System.Drawing.Size(190, 20);
            this.txt_max.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Min Memory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Max Memory";
            // 
            // list_scan
            // 
            this.list_scan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list_scan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_address,
            this.col_value});
            this.list_scan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.list_scan.FullRowSelect = true;
            this.list_scan.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.list_scan.Location = new System.Drawing.Point(0, 95);
            this.list_scan.MultiSelect = false;
            this.list_scan.Name = "list_scan";
            this.list_scan.Size = new System.Drawing.Size(284, 466);
            this.list_scan.TabIndex = 3;
            this.list_scan.UseCompatibleStateImageBehavior = false;
            this.list_scan.View = System.Windows.Forms.View.Details;
            // 
            // btn_fscan
            // 
            this.btn_fscan.Location = new System.Drawing.Point(82, 66);
            this.btn_fscan.Name = "btn_fscan";
            this.btn_fscan.Size = new System.Drawing.Size(75, 23);
            this.btn_fscan.TabIndex = 4;
            this.btn_fscan.Text = "First Scan";
            this.btn_fscan.UseVisualStyleBackColor = true;
            this.btn_fscan.Click += new System.EventHandler(this.btn_fscan_Click);
            // 
            // btn_nscan
            // 
            this.btn_nscan.Location = new System.Drawing.Point(197, 66);
            this.btn_nscan.Name = "btn_nscan";
            this.btn_nscan.Size = new System.Drawing.Size(75, 23);
            this.btn_nscan.TabIndex = 5;
            this.btn_nscan.Text = "Next Scan";
            this.btn_nscan.UseVisualStyleBackColor = true;
            // 
            // col_address
            // 
            this.col_address.Text = "Address";
            this.col_address.Width = 125;
            // 
            // col_value
            // 
            this.col_value.Text = "Value";
            this.col_value.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 561);
            this.Controls.Add(this.btn_nscan);
            this.Controls.Add(this.btn_fscan);
            this.Controls.Add(this.list_scan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_max);
            this.Controls.Add(this.txt_min);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_min;
        private System.Windows.Forms.TextBox txt_max;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView list_scan;
        private System.Windows.Forms.Button btn_fscan;
        private System.Windows.Forms.Button btn_nscan;
        private System.Windows.Forms.ColumnHeader col_address;
        private System.Windows.Forms.ColumnHeader col_value;
    }
}

