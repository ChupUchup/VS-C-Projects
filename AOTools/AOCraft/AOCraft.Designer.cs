namespace AOCraft
{
    partial class AOCraft
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AOCraft));
            this.combo_craft_type = new System.Windows.Forms.ComboBox();
            this.list_craft_item = new System.Windows.Forms.ListBox();
            this.combo_current = new System.Windows.Forms.ComboBox();
            this.combo_target = new System.Windows.Forms.ComboBox();
            this.text_current = new System.Windows.Forms.TextBox();
            this.text_target = new System.Windows.Forms.TextBox();
            this.panel_detail = new System.Windows.Forms.Panel();
            this.text_batch = new System.Windows.Forms.TextBox();
            this.text_exp_craft = new System.Windows.Forms.TextBox();
            this.text_level_craft = new System.Windows.Forms.TextBox();
            this.label_batch = new System.Windows.Forms.Label();
            this.text_nama = new System.Windows.Forms.TextBox();
            this.label_exp_craft = new System.Windows.Forms.Label();
            this.label_level_craft = new System.Windows.Forms.Label();
            this.label_nama = new System.Windows.Forms.Label();
            this.text_type = new System.Windows.Forms.TextBox();
            this.label_type = new System.Windows.Forms.Label();
            this.panel_hitung = new System.Windows.Forms.Panel();
            this.btn_save_plan = new System.Windows.Forms.Button();
            this.text_t_final = new System.Windows.Forms.TextBox();
            this.label_t_final = new System.Windows.Forms.Label();
            this.text_t_craft = new System.Windows.Forms.TextBox();
            this.label_t_craft = new System.Windows.Forms.Label();
            this.text_t_exp = new System.Windows.Forms.TextBox();
            this.label_t_exp = new System.Windows.Forms.Label();
            this.label_copyright = new System.Windows.Forms.Label();
            this.dgv_craft_plan = new System.Windows.Forms.DataGridView();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Current = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Target = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Batch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_craft_plan = new System.Windows.Forms.Button();
            this.btn_recipe = new System.Windows.Forms.Button();
            this.panel_detail.SuspendLayout();
            this.panel_hitung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_craft_plan)).BeginInit();
            this.SuspendLayout();
            // 
            // combo_craft_type
            // 
            this.combo_craft_type.FormattingEnabled = true;
            this.combo_craft_type.Location = new System.Drawing.Point(12, 12);
            this.combo_craft_type.Name = "combo_craft_type";
            this.combo_craft_type.Size = new System.Drawing.Size(200, 21);
            this.combo_craft_type.TabIndex = 0;
            this.combo_craft_type.Text = "Pilih jenis craft";
            // 
            // list_craft_item
            // 
            this.list_craft_item.FormattingEnabled = true;
            this.list_craft_item.Location = new System.Drawing.Point(12, 39);
            this.list_craft_item.Name = "list_craft_item";
            this.list_craft_item.Size = new System.Drawing.Size(200, 238);
            this.list_craft_item.TabIndex = 1;
            // 
            // combo_current
            // 
            this.combo_current.FormattingEnabled = true;
            this.combo_current.Location = new System.Drawing.Point(224, 135);
            this.combo_current.Name = "combo_current";
            this.combo_current.Size = new System.Drawing.Size(121, 21);
            this.combo_current.TabIndex = 3;
            this.combo_current.Text = "Level saat ini";
            // 
            // combo_target
            // 
            this.combo_target.FormattingEnabled = true;
            this.combo_target.Location = new System.Drawing.Point(351, 135);
            this.combo_target.Name = "combo_target";
            this.combo_target.Size = new System.Drawing.Size(121, 21);
            this.combo_target.TabIndex = 3;
            this.combo_target.Text = "Level target";
            // 
            // text_current
            // 
            this.text_current.Location = new System.Drawing.Point(224, 159);
            this.text_current.Name = "text_current";
            this.text_current.Size = new System.Drawing.Size(121, 20);
            this.text_current.TabIndex = 4;
            // 
            // text_target
            // 
            this.text_target.Enabled = false;
            this.text_target.Location = new System.Drawing.Point(351, 159);
            this.text_target.Name = "text_target";
            this.text_target.Size = new System.Drawing.Size(121, 20);
            this.text_target.TabIndex = 4;
            // 
            // panel_detail
            // 
            this.panel_detail.Controls.Add(this.text_batch);
            this.panel_detail.Controls.Add(this.text_exp_craft);
            this.panel_detail.Controls.Add(this.text_level_craft);
            this.panel_detail.Controls.Add(this.label_batch);
            this.panel_detail.Controls.Add(this.text_nama);
            this.panel_detail.Controls.Add(this.label_exp_craft);
            this.panel_detail.Controls.Add(this.label_level_craft);
            this.panel_detail.Controls.Add(this.label_nama);
            this.panel_detail.Location = new System.Drawing.Point(218, 39);
            this.panel_detail.Name = "panel_detail";
            this.panel_detail.Size = new System.Drawing.Size(261, 95);
            this.panel_detail.TabIndex = 5;
            // 
            // text_batch
            // 
            this.text_batch.Enabled = false;
            this.text_batch.Location = new System.Drawing.Point(78, 72);
            this.text_batch.Name = "text_batch";
            this.text_batch.Size = new System.Drawing.Size(176, 20);
            this.text_batch.TabIndex = 15;
            // 
            // text_exp_craft
            // 
            this.text_exp_craft.Enabled = false;
            this.text_exp_craft.Location = new System.Drawing.Point(78, 49);
            this.text_exp_craft.Name = "text_exp_craft";
            this.text_exp_craft.Size = new System.Drawing.Size(176, 20);
            this.text_exp_craft.TabIndex = 16;
            // 
            // text_level_craft
            // 
            this.text_level_craft.Enabled = false;
            this.text_level_craft.Location = new System.Drawing.Point(78, 26);
            this.text_level_craft.Name = "text_level_craft";
            this.text_level_craft.Size = new System.Drawing.Size(176, 20);
            this.text_level_craft.TabIndex = 17;
            // 
            // label_batch
            // 
            this.label_batch.AutoSize = true;
            this.label_batch.Location = new System.Drawing.Point(3, 75);
            this.label_batch.Name = "label_batch";
            this.label_batch.Size = new System.Drawing.Size(35, 13);
            this.label_batch.TabIndex = 8;
            this.label_batch.Text = "Batch";
            // 
            // text_nama
            // 
            this.text_nama.Enabled = false;
            this.text_nama.Location = new System.Drawing.Point(78, 3);
            this.text_nama.Name = "text_nama";
            this.text_nama.Size = new System.Drawing.Size(176, 20);
            this.text_nama.TabIndex = 20;
            // 
            // label_exp_craft
            // 
            this.label_exp_craft.AutoSize = true;
            this.label_exp_craft.Location = new System.Drawing.Point(3, 52);
            this.label_exp_craft.Name = "label_exp_craft";
            this.label_exp_craft.Size = new System.Drawing.Size(50, 13);
            this.label_exp_craft.TabIndex = 9;
            this.label_exp_craft.Text = "Exp Craft";
            // 
            // label_level_craft
            // 
            this.label_level_craft.AutoSize = true;
            this.label_level_craft.Location = new System.Drawing.Point(3, 29);
            this.label_level_craft.Name = "label_level_craft";
            this.label_level_craft.Size = new System.Drawing.Size(58, 13);
            this.label_level_craft.TabIndex = 10;
            this.label_level_craft.Text = "Level Craft";
            // 
            // label_nama
            // 
            this.label_nama.AutoSize = true;
            this.label_nama.Location = new System.Drawing.Point(3, 6);
            this.label_nama.Name = "label_nama";
            this.label_nama.Size = new System.Drawing.Size(35, 13);
            this.label_nama.TabIndex = 13;
            this.label_nama.Text = "Nama";
            // 
            // text_type
            // 
            this.text_type.Enabled = false;
            this.text_type.Location = new System.Drawing.Point(671, 305);
            this.text_type.Name = "text_type";
            this.text_type.Size = new System.Drawing.Size(139, 20);
            this.text_type.TabIndex = 19;
            this.text_type.Visible = false;
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Location = new System.Drawing.Point(596, 308);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(31, 13);
            this.label_type.TabIndex = 12;
            this.label_type.Text = "Type";
            this.label_type.Visible = false;
            // 
            // panel_hitung
            // 
            this.panel_hitung.Controls.Add(this.btn_save_plan);
            this.panel_hitung.Controls.Add(this.text_t_final);
            this.panel_hitung.Controls.Add(this.label_t_final);
            this.panel_hitung.Controls.Add(this.text_t_craft);
            this.panel_hitung.Controls.Add(this.label_t_craft);
            this.panel_hitung.Controls.Add(this.text_t_exp);
            this.panel_hitung.Controls.Add(this.label_t_exp);
            this.panel_hitung.Location = new System.Drawing.Point(218, 180);
            this.panel_hitung.Name = "panel_hitung";
            this.panel_hitung.Size = new System.Drawing.Size(261, 94);
            this.panel_hitung.TabIndex = 6;
            // 
            // btn_save_plan
            // 
            this.btn_save_plan.Location = new System.Drawing.Point(179, 71);
            this.btn_save_plan.Name = "btn_save_plan";
            this.btn_save_plan.Size = new System.Drawing.Size(75, 23);
            this.btn_save_plan.TabIndex = 17;
            this.btn_save_plan.Text = "Simpan";
            this.btn_save_plan.UseVisualStyleBackColor = true;
            this.btn_save_plan.Click += new System.EventHandler(this.btn_save_plan_Click);
            // 
            // text_t_final
            // 
            this.text_t_final.Enabled = false;
            this.text_t_final.Location = new System.Drawing.Point(78, 49);
            this.text_t_final.Name = "text_t_final";
            this.text_t_final.Size = new System.Drawing.Size(176, 20);
            this.text_t_final.TabIndex = 16;
            // 
            // label_t_final
            // 
            this.label_t_final.AutoSize = true;
            this.label_t_final.Location = new System.Drawing.Point(3, 52);
            this.label_t_final.Name = "label_t_final";
            this.label_t_final.Size = new System.Drawing.Size(52, 13);
            this.label_t_final.TabIndex = 15;
            this.label_t_final.Text = "Total Exp";
            // 
            // text_t_craft
            // 
            this.text_t_craft.Enabled = false;
            this.text_t_craft.Location = new System.Drawing.Point(78, 26);
            this.text_t_craft.Name = "text_t_craft";
            this.text_t_craft.Size = new System.Drawing.Size(176, 20);
            this.text_t_craft.TabIndex = 16;
            // 
            // label_t_craft
            // 
            this.label_t_craft.AutoSize = true;
            this.label_t_craft.Location = new System.Drawing.Point(3, 29);
            this.label_t_craft.Name = "label_t_craft";
            this.label_t_craft.Size = new System.Drawing.Size(63, 13);
            this.label_t_craft.TabIndex = 15;
            this.label_t_craft.Text = "Target Craft";
            // 
            // text_t_exp
            // 
            this.text_t_exp.Enabled = false;
            this.text_t_exp.Location = new System.Drawing.Point(78, 3);
            this.text_t_exp.Name = "text_t_exp";
            this.text_t_exp.Size = new System.Drawing.Size(176, 20);
            this.text_t_exp.TabIndex = 16;
            // 
            // label_t_exp
            // 
            this.label_t_exp.AutoSize = true;
            this.label_t_exp.Location = new System.Drawing.Point(3, 6);
            this.label_t_exp.Name = "label_t_exp";
            this.label_t_exp.Size = new System.Drawing.Size(59, 13);
            this.label_t_exp.TabIndex = 15;
            this.label_t_exp.Text = "Target Exp";
            // 
            // label_copyright
            // 
            this.label_copyright.AutoSize = true;
            this.label_copyright.Location = new System.Drawing.Point(413, 12);
            this.label_copyright.Name = "label_copyright";
            this.label_copyright.Size = new System.Drawing.Size(58, 13);
            this.label_copyright.TabIndex = 7;
            this.label_copyright.Text = "By : Chupy";
            // 
            // dgv_craft_plan
            // 
            this.dgv_craft_plan.AllowUserToAddRows = false;
            this.dgv_craft_plan.AllowUserToDeleteRows = false;
            this.dgv_craft_plan.AllowUserToOrderColumns = true;
            this.dgv_craft_plan.AllowUserToResizeColumns = false;
            this.dgv_craft_plan.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_craft_plan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_craft_plan.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_craft_plan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_craft_plan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_craft_plan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_craft_plan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgv_craft_plan.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_craft_plan.Location = new System.Drawing.Point(12, 280);
            this.dgv_craft_plan.MultiSelect = false;
            this.dgv_craft_plan.Name = "dgv_craft_plan";
            this.dgv_craft_plan.ReadOnly = true;
            this.dgv_craft_plan.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_craft_plan.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_craft_plan.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_craft_plan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_craft_plan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_craft_plan.Size = new System.Drawing.Size(460, 109);
            this.dgv_craft_plan.TabIndex = 8;
            this.dgv_craft_plan.Visible = false;
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
            this.Nama.Width = 170;
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
            // btn_craft_plan
            // 
            this.btn_craft_plan.Location = new System.Drawing.Point(11, 279);
            this.btn_craft_plan.Name = "btn_craft_plan";
            this.btn_craft_plan.Size = new System.Drawing.Size(42, 23);
            this.btn_craft_plan.TabIndex = 20;
            this.btn_craft_plan.Text = "Detail";
            this.btn_craft_plan.UseVisualStyleBackColor = true;
            this.btn_craft_plan.Visible = false;
            this.btn_craft_plan.Click += new System.EventHandler(this.btn_craft_plan_Click);
            // 
            // btn_recipe
            // 
            this.btn_recipe.Location = new System.Drawing.Point(332, 7);
            this.btn_recipe.Name = "btn_recipe";
            this.btn_recipe.Size = new System.Drawing.Size(75, 23);
            this.btn_recipe.TabIndex = 21;
            this.btn_recipe.Text = "Recipe";
            this.btn_recipe.UseVisualStyleBackColor = true;
            this.btn_recipe.Click += new System.EventHandler(this.btn_recipe_Click);
            // 
            // AOCraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 399);
            this.Controls.Add(this.btn_recipe);
            this.Controls.Add(this.btn_craft_plan);
            this.Controls.Add(this.dgv_craft_plan);
            this.Controls.Add(this.label_copyright);
            this.Controls.Add(this.panel_hitung);
            this.Controls.Add(this.text_type);
            this.Controls.Add(this.panel_detail);
            this.Controls.Add(this.text_target);
            this.Controls.Add(this.text_current);
            this.Controls.Add(this.combo_target);
            this.Controls.Add(this.label_type);
            this.Controls.Add(this.combo_current);
            this.Controls.Add(this.list_craft_item);
            this.Controls.Add(this.combo_craft_type);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AOCraft";
            this.Text = "AOCraft";
            this.panel_detail.ResumeLayout(false);
            this.panel_detail.PerformLayout();
            this.panel_hitung.ResumeLayout(false);
            this.panel_hitung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_craft_plan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_craft_type;
        private System.Windows.Forms.ListBox list_craft_item;
        private System.Windows.Forms.ComboBox combo_current;
        private System.Windows.Forms.ComboBox combo_target;
        private System.Windows.Forms.TextBox text_current;
        private System.Windows.Forms.TextBox text_target;
        private System.Windows.Forms.Panel panel_detail;
        private System.Windows.Forms.TextBox text_batch;
        private System.Windows.Forms.TextBox text_exp_craft;
        private System.Windows.Forms.TextBox text_level_craft;
        private System.Windows.Forms.TextBox text_type;
        private System.Windows.Forms.Label label_batch;
        private System.Windows.Forms.TextBox text_nama;
        private System.Windows.Forms.Label label_exp_craft;
        private System.Windows.Forms.Label label_level_craft;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.Label label_nama;
        private System.Windows.Forms.Panel panel_hitung;
        private System.Windows.Forms.TextBox text_t_exp;
        private System.Windows.Forms.Label label_t_exp;
        private System.Windows.Forms.TextBox text_t_final;
        private System.Windows.Forms.Label label_t_final;
        private System.Windows.Forms.TextBox text_t_craft;
        private System.Windows.Forms.Label label_t_craft;
        private System.Windows.Forms.Label label_copyright;
        private System.Windows.Forms.Button btn_save_plan;
        private System.Windows.Forms.DataGridView dgv_craft_plan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Current;
        private System.Windows.Forms.DataGridViewTextBoxColumn Target;
        private System.Windows.Forms.DataGridViewTextBoxColumn Batch;
        private System.Windows.Forms.Button btn_craft_plan;
        private System.Windows.Forms.Button btn_recipe;

    }
}