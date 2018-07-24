namespace AOCraft
{
    partial class InputItem
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
            this.txt_nama = new System.Windows.Forms.TextBox();
            this.lbl_nama = new System.Windows.Forms.Label();
            this.lbl_harga = new System.Windows.Forms.Label();
            this.txt_harga = new System.Windows.Forms.TextBox();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.list_item = new System.Windows.Forms.ListBox();
            this.lbl_type = new System.Windows.Forms.Label();
            this.combo_type = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txt_nama
            // 
            this.txt_nama.Location = new System.Drawing.Point(56, 34);
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.Size = new System.Drawing.Size(100, 20);
            this.txt_nama.TabIndex = 1;
            // 
            // lbl_nama
            // 
            this.lbl_nama.AutoSize = true;
            this.lbl_nama.Location = new System.Drawing.Point(15, 37);
            this.lbl_nama.Name = "lbl_nama";
            this.lbl_nama.Size = new System.Drawing.Size(35, 13);
            this.lbl_nama.TabIndex = 1;
            this.lbl_nama.Text = "Nama";
            // 
            // lbl_harga
            // 
            this.lbl_harga.AutoSize = true;
            this.lbl_harga.Location = new System.Drawing.Point(15, 63);
            this.lbl_harga.Name = "lbl_harga";
            this.lbl_harga.Size = new System.Drawing.Size(36, 13);
            this.lbl_harga.TabIndex = 3;
            this.lbl_harga.Text = "Harga";
            // 
            // txt_harga
            // 
            this.txt_harga.Location = new System.Drawing.Point(56, 60);
            this.txt_harga.Name = "txt_harga";
            this.txt_harga.Size = new System.Drawing.Size(100, 20);
            this.txt_harga.TabIndex = 2;
            // 
            // btn_simpan
            // 
            this.btn_simpan.Location = new System.Drawing.Point(81, 86);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(75, 23);
            this.btn_simpan.TabIndex = 4;
            this.btn_simpan.Text = "Simpan";
            this.btn_simpan.UseVisualStyleBackColor = true;
            // 
            // list_item
            // 
            this.list_item.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.list_item.FormattingEnabled = true;
            this.list_item.Location = new System.Drawing.Point(0, 117);
            this.list_item.Name = "list_item";
            this.list_item.Size = new System.Drawing.Size(174, 121);
            this.list_item.TabIndex = 5;
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Location = new System.Drawing.Point(15, 11);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(31, 13);
            this.lbl_type.TabIndex = 7;
            this.lbl_type.Text = "Type";
            // 
            // combo_type
            // 
            this.combo_type.FormattingEnabled = true;
            this.combo_type.Location = new System.Drawing.Point(56, 8);
            this.combo_type.Name = "combo_type";
            this.combo_type.Size = new System.Drawing.Size(100, 21);
            this.combo_type.TabIndex = 0;
            // 
            // InputItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(174, 238);
            this.Controls.Add(this.combo_type);
            this.Controls.Add(this.lbl_type);
            this.Controls.Add(this.list_item);
            this.Controls.Add(this.btn_simpan);
            this.Controls.Add(this.lbl_harga);
            this.Controls.Add(this.txt_harga);
            this.Controls.Add(this.lbl_nama);
            this.Controls.Add(this.txt_nama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputItem";
            this.Text = "InputItem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nama;
        private System.Windows.Forms.Label lbl_nama;
        private System.Windows.Forms.Label lbl_harga;
        private System.Windows.Forms.TextBox txt_harga;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.ListBox list_item;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.ComboBox combo_type;
    }
}