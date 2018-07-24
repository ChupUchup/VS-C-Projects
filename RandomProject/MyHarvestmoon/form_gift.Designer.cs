namespace MyHarvestmoon
{
    partial class form_gift
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_gift));
            this.txt_gift = new System.Windows.Forms.RichTextBox();
            this.list_gift = new System.Windows.Forms.ListBox();
            this.context_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menu_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.lbl_total = new System.Windows.Forms.Label();
            this.context_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_gift
            // 
            this.txt_gift.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_gift.Location = new System.Drawing.Point(0, 0);
            this.txt_gift.Name = "txt_gift";
            this.txt_gift.Size = new System.Drawing.Size(667, 305);
            this.txt_gift.TabIndex = 0;
            this.txt_gift.Text = "";
            this.txt_gift.TextChanged += new System.EventHandler(this.txt_gift_TextChanged);
            // 
            // list_gift
            // 
            this.list_gift.ContextMenuStrip = this.context_menu;
            this.list_gift.Dock = System.Windows.Forms.DockStyle.Left;
            this.list_gift.FormattingEnabled = true;
            this.list_gift.Location = new System.Drawing.Point(0, 305);
            this.list_gift.Name = "list_gift";
            this.list_gift.Size = new System.Drawing.Size(563, 306);
            this.list_gift.TabIndex = 1;
            // 
            // context_menu
            // 
            this.context_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_edit,
            this.menu_delete});
            this.context_menu.Name = "context_menu";
            this.context_menu.Size = new System.Drawing.Size(182, 48);
            // 
            // menu_edit
            // 
            this.menu_edit.Name = "menu_edit";
            this.menu_edit.Size = new System.Drawing.Size(181, 22);
            this.menu_edit.Text = "Edit Selected Item";
            this.menu_edit.Visible = false;
            // 
            // menu_delete
            // 
            this.menu_delete.Name = "menu_delete";
            this.menu_delete.Size = new System.Drawing.Size(181, 22);
            this.menu_delete.Text = "Delete Selected Item";
            this.menu_delete.Click += new System.EventHandler(this.menu_delete_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(579, 311);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 75);
            this.btn_insert.TabIndex = 2;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(579, 473);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 75);
            this.btn_clear.TabIndex = 3;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(579, 392);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 75);
            this.btn_load.TabIndex = 4;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(576, 589);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(40, 13);
            this.lbl_total.TabIndex = 5;
            this.lbl_total.Text = "Total : ";
            // 
            // form_gift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 611);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.list_gift);
            this.Controls.Add(this.txt_gift);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_gift";
            this.Text = "form_gift";
            this.Load += new System.EventHandler(this.form_gift_Load);
            this.context_menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txt_gift;
        private System.Windows.Forms.ListBox list_gift;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.ContextMenuStrip context_menu;
        private System.Windows.Forms.ToolStripMenuItem menu_delete;
        private System.Windows.Forms.ToolStripMenuItem menu_edit;
    }
}