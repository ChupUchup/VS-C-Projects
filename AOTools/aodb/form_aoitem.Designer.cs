namespace aodb
{
    partial class form_aoitem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_aoitem));
            this.combo_jenis = new System.Windows.Forms.ComboBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.list_search = new System.Windows.Forms.ListView();
            this.col_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_craft_level = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_nama_adv = new System.Windows.Forms.TextBox();
            this.combo_jenis_adv = new System.Windows.Forms.ComboBox();
            this.combo_c_able = new System.Windows.Forms.ComboBox();
            this.txt_level = new System.Windows.Forms.TextBox();
            this.txt_harga_adv = new System.Windows.Forms.TextBox();
            this.txt_c_level = new System.Windows.Forms.TextBox();
            this.txt_tree = new System.Windows.Forms.TextBox();
            this.txt_c_batch = new System.Windows.Forms.TextBox();
            this.txt_c_exp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.panel_craft = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // combo_jenis
            // 
            this.combo_jenis.DropDownHeight = 224;
            this.combo_jenis.FormattingEnabled = true;
            this.combo_jenis.IntegralHeight = false;
            this.combo_jenis.Location = new System.Drawing.Point(51, 2);
            this.combo_jenis.Name = "combo_jenis";
            this.combo_jenis.Size = new System.Drawing.Size(202, 21);
            this.combo_jenis.TabIndex = 0;
            this.combo_jenis.SelectedIndexChanged += new System.EventHandler(this.combo_jenis_SelectedIndexChanged);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(51, 25);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(202, 20);
            this.txt_search.TabIndex = 1;
            this.txt_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_search_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Jenis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search";
            // 
            // list_search
            // 
            this.list_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list_search.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_name,
            this.col_craft_level});
            this.list_search.FullRowSelect = true;
            this.list_search.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.list_search.Location = new System.Drawing.Point(6, 47);
            this.list_search.MultiSelect = false;
            this.list_search.Name = "list_search";
            this.list_search.Size = new System.Drawing.Size(247, 87);
            this.list_search.TabIndex = 4;
            this.list_search.UseCompatibleStateImageBehavior = false;
            this.list_search.View = System.Windows.Forms.View.Details;
            this.list_search.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.list_search_ItemSelectionChanged);
            // 
            // col_name
            // 
            this.col_name.Text = "";
            this.col_name.Width = 184;
            // 
            // col_craft_level
            // 
            this.col_craft_level.Text = "";
            this.col_craft_level.Width = 38;
            // 
            // txt_nama_adv
            // 
            this.txt_nama_adv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_nama_adv.Location = new System.Drawing.Point(51, 136);
            this.txt_nama_adv.Name = "txt_nama_adv";
            this.txt_nama_adv.Size = new System.Drawing.Size(127, 20);
            this.txt_nama_adv.TabIndex = 5;
            this.txt_nama_adv.TextChanged += new System.EventHandler(this.txt_nama_TextChanged);
            // 
            // combo_jenis_adv
            // 
            this.combo_jenis_adv.DropDownHeight = 224;
            this.combo_jenis_adv.DropDownWidth = 202;
            this.combo_jenis_adv.FormattingEnabled = true;
            this.combo_jenis_adv.IntegralHeight = false;
            this.combo_jenis_adv.Location = new System.Drawing.Point(51, 158);
            this.combo_jenis_adv.Name = "combo_jenis_adv";
            this.combo_jenis_adv.Size = new System.Drawing.Size(75, 21);
            this.combo_jenis_adv.TabIndex = 6;
            // 
            // combo_c_able
            // 
            this.combo_c_able.FormattingEnabled = true;
            this.combo_c_able.Items.AddRange(new object[] {
            "yes",
            "no"});
            this.combo_c_able.Location = new System.Drawing.Point(178, 158);
            this.combo_c_able.Name = "combo_c_able";
            this.combo_c_able.Size = new System.Drawing.Size(75, 21);
            this.combo_c_able.TabIndex = 7;
            this.combo_c_able.SelectedIndexChanged += new System.EventHandler(this.combo_c_able_SelectedIndexChanged);
            // 
            // txt_level
            // 
            this.txt_level.Location = new System.Drawing.Point(51, 180);
            this.txt_level.Name = "txt_level";
            this.txt_level.Size = new System.Drawing.Size(75, 20);
            this.txt_level.TabIndex = 8;
            this.txt_level.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Edit_KeyPress);
            // 
            // txt_harga_adv
            // 
            this.txt_harga_adv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_harga_adv.Location = new System.Drawing.Point(51, 202);
            this.txt_harga_adv.Name = "txt_harga_adv";
            this.txt_harga_adv.Size = new System.Drawing.Size(75, 20);
            this.txt_harga_adv.TabIndex = 9;
            this.txt_harga_adv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Edit_KeyPress);
            // 
            // txt_c_level
            // 
            this.txt_c_level.Location = new System.Drawing.Point(178, 180);
            this.txt_c_level.Name = "txt_c_level";
            this.txt_c_level.Size = new System.Drawing.Size(75, 20);
            this.txt_c_level.TabIndex = 11;
            this.txt_c_level.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Edit_KeyPress);
            // 
            // txt_tree
            // 
            this.txt_tree.Location = new System.Drawing.Point(51, 224);
            this.txt_tree.Name = "txt_tree";
            this.txt_tree.Size = new System.Drawing.Size(75, 20);
            this.txt_tree.TabIndex = 10;
            this.txt_tree.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Edit_KeyPress);
            // 
            // txt_c_batch
            // 
            this.txt_c_batch.Location = new System.Drawing.Point(178, 224);
            this.txt_c_batch.Name = "txt_c_batch";
            this.txt_c_batch.Size = new System.Drawing.Size(75, 20);
            this.txt_c_batch.TabIndex = 13;
            this.txt_c_batch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Edit_KeyPress);
            // 
            // txt_c_exp
            // 
            this.txt_c_exp.Location = new System.Drawing.Point(178, 202);
            this.txt_c_exp.Name = "txt_c_exp";
            this.txt_c_exp.Size = new System.Drawing.Size(75, 20);
            this.txt_c_exp.TabIndex = 12;
            this.txt_c_exp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Edit_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Jenis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tree";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Level";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Harga";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(129, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "C Batch";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(129, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "C Exp";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(129, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "C Level";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(129, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "C Able";
            // 
            // btn_simpan
            // 
            this.btn_simpan.Location = new System.Drawing.Point(178, 135);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(76, 22);
            this.btn_simpan.TabIndex = 23;
            this.btn_simpan.Text = "Simpan";
            this.btn_simpan.UseVisualStyleBackColor = true;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // panel_craft
            // 
            this.panel_craft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel_craft.Location = new System.Drawing.Point(0, 245);
            this.panel_craft.Name = "panel_craft";
            this.panel_craft.Size = new System.Drawing.Size(259, 440);
            this.panel_craft.TabIndex = 24;
            // 
            // form_aoitem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(259, 269);
            this.Controls.Add(this.panel_craft);
            this.Controls.Add(this.btn_simpan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_c_batch);
            this.Controls.Add(this.txt_c_exp);
            this.Controls.Add(this.txt_c_level);
            this.Controls.Add(this.txt_tree);
            this.Controls.Add(this.txt_harga_adv);
            this.Controls.Add(this.txt_level);
            this.Controls.Add(this.combo_c_able);
            this.Controls.Add(this.combo_jenis_adv);
            this.Controls.Add(this.txt_nama_adv);
            this.Controls.Add(this.list_search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.combo_jenis);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "form_aoitem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "aodb";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.form_aoitem_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_jenis;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView list_search;
        private System.Windows.Forms.ColumnHeader col_name;
        private System.Windows.Forms.ColumnHeader col_craft_level;
        private System.Windows.Forms.TextBox txt_nama_adv;
        private System.Windows.Forms.ComboBox combo_jenis_adv;
        private System.Windows.Forms.ComboBox combo_c_able;
        private System.Windows.Forms.TextBox txt_level;
        private System.Windows.Forms.TextBox txt_harga_adv;
        private System.Windows.Forms.TextBox txt_c_level;
        private System.Windows.Forms.TextBox txt_tree;
        private System.Windows.Forms.TextBox txt_c_batch;
        private System.Windows.Forms.TextBox txt_c_exp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.Panel panel_craft;

    }
}