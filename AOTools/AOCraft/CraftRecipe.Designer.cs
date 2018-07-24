namespace AOCraft
{
    partial class CraftRecipe
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
            this.btn_input_item = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_input_item
            // 
            this.btn_input_item.Location = new System.Drawing.Point(396, 12);
            this.btn_input_item.Name = "btn_input_item";
            this.btn_input_item.Size = new System.Drawing.Size(75, 23);
            this.btn_input_item.TabIndex = 0;
            this.btn_input_item.Text = "Input Item";
            this.btn_input_item.UseVisualStyleBackColor = true;
            this.btn_input_item.Click += new System.EventHandler(this.btn_input_item_Click);
            // 
            // CraftRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 399);
            this.Controls.Add(this.btn_input_item);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CraftRecipe";
            this.Text = "CraftRecipe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_input_item;
    }
}