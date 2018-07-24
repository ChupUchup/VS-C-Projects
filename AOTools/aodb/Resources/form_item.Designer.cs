namespace aodb
{
    partial class form_item
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_item));
            this.cmb_name = new SergeUtils.EasyCompletionComboBox();
            this.cmb_craftable = new System.Windows.Forms.ComboBox();
            this.txt_level = new System.Windows.Forms.TextBox();
            this.txt_craft_level = new System.Windows.Forms.TextBox();
            this.txt_craft_exp = new System.Windows.Forms.TextBox();
            this.txt_craft_batch = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_craft = new System.Windows.Forms.Button();
            this.cmb_type = new SergeUtils.EasyCompletionComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_name
            // 
            this.cmb_name.FormattingEnabled = true;
            this.cmb_name.Location = new System.Drawing.Point(98, 37);
            this.cmb_name.Name = "cmb_name";
            this.cmb_name.Size = new System.Drawing.Size(173, 21);
            this.cmb_name.TabIndex = 0;
            this.cmb_name.Text = "pilih item";
            this.cmb_name.TextChanged += new System.EventHandler(this.cmb_name_TextChanged);
            // 
            // cmb_craftable
            // 
            this.cmb_craftable.FormattingEnabled = true;
            this.cmb_craftable.Items.AddRange(new object[] {
            "no",
            "yes"});
            this.cmb_craftable.Location = new System.Drawing.Point(98, 66);
            this.cmb_craftable.Name = "cmb_craftable";
            this.cmb_craftable.Size = new System.Drawing.Size(92, 21);
            this.cmb_craftable.TabIndex = 2;
            this.cmb_craftable.Text = "yes / no";
            // 
            // txt_level
            // 
            this.txt_level.Location = new System.Drawing.Point(98, 93);
            this.txt_level.Name = "txt_level";
            this.txt_level.Size = new System.Drawing.Size(173, 20);
            this.txt_level.TabIndex = 3;
            this.txt_level.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_KeyPress);
            // 
            // txt_craft_level
            // 
            this.txt_craft_level.Location = new System.Drawing.Point(98, 119);
            this.txt_craft_level.Name = "txt_craft_level";
            this.txt_craft_level.Size = new System.Drawing.Size(173, 20);
            this.txt_craft_level.TabIndex = 4;
            this.txt_craft_level.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_KeyPress);
            // 
            // txt_craft_exp
            // 
            this.txt_craft_exp.Location = new System.Drawing.Point(98, 145);
            this.txt_craft_exp.Name = "txt_craft_exp";
            this.txt_craft_exp.Size = new System.Drawing.Size(173, 20);
            this.txt_craft_exp.TabIndex = 5;
            this.txt_craft_exp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_KeyPress);
            // 
            // txt_craft_batch
            // 
            this.txt_craft_batch.Location = new System.Drawing.Point(98, 171);
            this.txt_craft_batch.Name = "txt_craft_batch";
            this.txt_craft_batch.Size = new System.Drawing.Size(173, 20);
            this.txt_craft_batch.TabIndex = 6;
            this.txt_craft_batch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_KeyPress);
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(98, 197);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(173, 20);
            this.txt_price.TabIndex = 7;
            this.txt_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Item Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Item Craftable";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Item Level";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Item Craft Level";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Item Craft Exp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Item Craft Batch";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Item Price";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(196, 226);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(14, 232);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(176, 10);
            this.progressBar1.TabIndex = 18;
            // 
            // btn_craft
            // 
            this.btn_craft.Enabled = false;
            this.btn_craft.Location = new System.Drawing.Point(196, 64);
            this.btn_craft.Name = "btn_craft";
            this.btn_craft.Size = new System.Drawing.Size(75, 23);
            this.btn_craft.TabIndex = 19;
            this.btn_craft.Text = "Edit Craft";
            this.btn_craft.UseVisualStyleBackColor = true;
            this.btn_craft.Click += new System.EventHandler(this.btn_craft_Click);
            // 
            // cmb_type
            // 
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Location = new System.Drawing.Point(99, 10);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(173, 21);
            this.cmb_type.TabIndex = 20;
            this.cmb_type.Text = "pilih type";
            this.cmb_type.SelectedIndexChanged += new System.EventHandler(this.cmb_type_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Item Type";
            // 
            // form_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cmb_type);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_craft);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_craft_batch);
            this.Controls.Add(this.txt_craft_exp);
            this.Controls.Add(this.txt_craft_level);
            this.Controls.Add(this.txt_level);
            this.Controls.Add(this.cmb_craftable);
            this.Controls.Add(this.cmb_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_item";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form item";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.form_item_Shown);
            this.LocationChanged += new System.EventHandler(this.form_item_LocationChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SergeUtils.EasyCompletionComboBox cmb_name;
        private System.Windows.Forms.ComboBox cmb_craftable;
        private System.Windows.Forms.TextBox txt_level;
        private System.Windows.Forms.TextBox txt_craft_level;
        private System.Windows.Forms.TextBox txt_craft_exp;
        private System.Windows.Forms.TextBox txt_craft_batch;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.Button btn_craft;
        private SergeUtils.EasyCompletionComboBox cmb_type;
        private System.Windows.Forms.Label label2;
    }
}