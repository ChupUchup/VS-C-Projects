namespace AOCraft
{
    partial class CraftPlan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CraftPlan));
            this.dgv_craft_plan_list = new System.Windows.Forms.DataGridView();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Current = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Target = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Batch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_craft_plan_list)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_craft_plan_list
            // 
            this.dgv_craft_plan_list.AllowUserToAddRows = false;
            this.dgv_craft_plan_list.AllowUserToDeleteRows = false;
            this.dgv_craft_plan_list.AllowUserToOrderColumns = true;
            this.dgv_craft_plan_list.AllowUserToResizeColumns = false;
            this.dgv_craft_plan_list.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_craft_plan_list.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_craft_plan_list.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_craft_plan_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_craft_plan_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_craft_plan_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_craft_plan_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nama,
            this.Current,
            this.Target,
            this.Batch});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_craft_plan_list.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_craft_plan_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_craft_plan_list.Location = new System.Drawing.Point(0, 0);
            this.dgv_craft_plan_list.MultiSelect = false;
            this.dgv_craft_plan_list.Name = "dgv_craft_plan_list";
            this.dgv_craft_plan_list.ReadOnly = true;
            this.dgv_craft_plan_list.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_craft_plan_list.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_craft_plan_list.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_craft_plan_list.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_craft_plan_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_craft_plan_list.Size = new System.Drawing.Size(483, 399);
            this.dgv_craft_plan_list.TabIndex = 9;
            // 
            // Nama
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            this.Nama.DefaultCellStyle = dataGridViewCellStyle3;
            this.Nama.HeaderText = "Craft item";
            this.Nama.Name = "Nama";
            this.Nama.ReadOnly = true;
            this.Nama.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Nama.Width = 200;
            // 
            // Current
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            this.Current.DefaultCellStyle = dataGridViewCellStyle4;
            this.Current.HeaderText = "Level saat ini";
            this.Current.Name = "Current";
            this.Current.ReadOnly = true;
            this.Current.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Current.Width = 90;
            // 
            // Target
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            this.Target.DefaultCellStyle = dataGridViewCellStyle5;
            this.Target.HeaderText = "Level target";
            this.Target.Name = "Target";
            this.Target.ReadOnly = true;
            this.Target.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Target.Width = 90;
            // 
            // Batch
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            this.Batch.DefaultCellStyle = dataGridViewCellStyle6;
            this.Batch.HeaderText = "Total craft";
            this.Batch.Name = "Batch";
            this.Batch.ReadOnly = true;
            this.Batch.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Batch.Width = 90;
            // 
            // CraftPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 399);
            this.Controls.Add(this.dgv_craft_plan_list);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CraftPlan";
            this.Text = "CraftPlan";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_craft_plan_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_craft_plan_list;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Current;
        private System.Windows.Forms.DataGridViewTextBoxColumn Target;
        private System.Windows.Forms.DataGridViewTextBoxColumn Batch;
    }
}