namespace aodb
{
    partial class form_recipe
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
            this.combo_name = new SergeUtils.EasyCompletionComboBox();
            this.panel_data = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // combo_name
            // 
            this.combo_name.FormattingEnabled = true;
            this.combo_name.Location = new System.Drawing.Point(12, 12);
            this.combo_name.Name = "combo_name";
            this.combo_name.Size = new System.Drawing.Size(228, 21);
            this.combo_name.TabIndex = 0;
            this.combo_name.Text = "Pilih item";
            this.combo_name.SelectedIndexChanged += new System.EventHandler(this.combo_name_SelectedIndexChanged);
            // 
            // panel_data
            // 
            this.panel_data.Location = new System.Drawing.Point(12, 39);
            this.panel_data.Name = "panel_data";
            this.panel_data.Size = new System.Drawing.Size(331, 410);
            this.panel_data.TabIndex = 1;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(240, 11);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(104, 23);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // form_recipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 461);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.panel_data);
            this.Controls.Add(this.combo_name);
            this.MinimizeBox = false;
            this.Name = "form_recipe";
            this.Text = "Craft Recipe";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_recipe_FormClosed);
            this.Shown += new System.EventHandler(this.form_recipe_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private SergeUtils.EasyCompletionComboBox combo_name;
        private System.Windows.Forms.Panel panel_data;
        private System.Windows.Forms.Button btn_save;
    }
}