namespace aodb
{
    partial class form_aodb
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
            this.cmb_name = new SergeUtils.EasyCompletionComboBox();
            this.cmb_type = new SergeUtils.EasyCompletionComboBox();
            this.cmb_craftable = new System.Windows.Forms.ComboBox();
            this.txt_level = new System.Windows.Forms.TextBox();
            this.txt_craft_level = new System.Windows.Forms.TextBox();
            this.txt_craft_exp = new System.Windows.Forms.TextBox();
            this.txt_craft_batch = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.panel_item = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // cmb_name
            // 
            this.cmb_name.FormattingEnabled = true;
            this.cmb_name.Location = new System.Drawing.Point(75, 9);
            this.cmb_name.Name = "cmb_name";
            this.cmb_name.Size = new System.Drawing.Size(175, 21);
            this.cmb_name.TabIndex = 0;
            this.cmb_name.Text = "pilih item";
            this.cmb_name.TextChanged += new System.EventHandler(this.cmb_name_TextChanged);
            // 
            // cmb_type
            // 
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Location = new System.Drawing.Point(75, 36);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(175, 21);
            this.cmb_type.TabIndex = 1;
            this.cmb_type.Text = "pilih type";
            // 
            // cmb_craftable
            // 
            this.cmb_craftable.FormattingEnabled = true;
            this.cmb_craftable.Items.AddRange(new object[] {
            "yes",
            "no"});
            this.cmb_craftable.Location = new System.Drawing.Point(75, 63);
            this.cmb_craftable.Name = "cmb_craftable";
            this.cmb_craftable.Size = new System.Drawing.Size(175, 21);
            this.cmb_craftable.TabIndex = 2;
            this.cmb_craftable.Text = "yes / no";
            // 
            // txt_level
            // 
            this.txt_level.Location = new System.Drawing.Point(75, 90);
            this.txt_level.Name = "txt_level";
            this.txt_level.Size = new System.Drawing.Size(175, 20);
            this.txt_level.TabIndex = 3;
            // 
            // txt_craft_level
            // 
            this.txt_craft_level.Location = new System.Drawing.Point(75, 116);
            this.txt_craft_level.Name = "txt_craft_level";
            this.txt_craft_level.Size = new System.Drawing.Size(175, 20);
            this.txt_craft_level.TabIndex = 4;
            // 
            // txt_craft_exp
            // 
            this.txt_craft_exp.Location = new System.Drawing.Point(75, 142);
            this.txt_craft_exp.Name = "txt_craft_exp";
            this.txt_craft_exp.Size = new System.Drawing.Size(175, 20);
            this.txt_craft_exp.TabIndex = 5;
            // 
            // txt_craft_batch
            // 
            this.txt_craft_batch.Location = new System.Drawing.Point(75, 168);
            this.txt_craft_batch.Name = "txt_craft_batch";
            this.txt_craft_batch.Size = new System.Drawing.Size(175, 20);
            this.txt_craft_batch.TabIndex = 6;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(75, 194);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(175, 20);
            this.txt_price.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nama";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Type";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Bisa di Craft";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Level";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Level Craft";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Exp Craft";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Batch";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Harga";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(175, 220);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 16;
            this.btn_save.Text = "Simpan";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // panel_item
            // 
            this.panel_item.Location = new System.Drawing.Point(0, 262);
            this.panel_item.Name = "panel_item";
            this.panel_item.Size = new System.Drawing.Size(259, 471);
            this.panel_item.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Nama";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(122, 246);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Jumlah";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(195, 246);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Harga";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(8, 227);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(160, 10);
            this.progressBar1.TabIndex = 21;
            // 
            // form_aodb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 247);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel_item);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_craft_batch);
            this.Controls.Add(this.txt_craft_exp);
            this.Controls.Add(this.txt_craft_level);
            this.Controls.Add(this.txt_level);
            this.Controls.Add(this.cmb_craftable);
            this.Controls.Add(this.cmb_type);
            this.Controls.Add(this.cmb_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_aodb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "aodb";
            this.Shown += new System.EventHandler(this.form_aodb_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SergeUtils.EasyCompletionComboBox cmb_name;
        private SergeUtils.EasyCompletionComboBox cmb_type;
        private System.Windows.Forms.ComboBox cmb_craftable;
        private System.Windows.Forms.TextBox txt_level;
        private System.Windows.Forms.TextBox txt_craft_level;
        private System.Windows.Forms.TextBox txt_craft_exp;
        private System.Windows.Forms.TextBox txt_craft_batch;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Panel panel_item;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}