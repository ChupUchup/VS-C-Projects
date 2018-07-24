namespace MyHarvestmoon
{
    partial class MyHarvestmoonApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyHarvestmoonApp));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_data = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.btn_add_gift = new System.Windows.Forms.Button();
            this.list_name = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 100);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(261, 95);
            this.listBox1.TabIndex = 0;
            // 
            // btn_data
            // 
            this.btn_data.Location = new System.Drawing.Point(12, 71);
            this.btn_data.Name = "btn_data";
            this.btn_data.Size = new System.Drawing.Size(75, 23);
            this.btn_data.TabIndex = 16;
            this.btn_data.Text = "Add Char";
            this.btn_data.UseVisualStyleBackColor = true;
            this.btn_data.Click += new System.EventHandler(this.btn_data_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(12, 201);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(261, 95);
            this.listBox2.TabIndex = 17;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(12, 302);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(261, 95);
            this.listBox3.TabIndex = 18;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(12, 403);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(261, 95);
            this.listBox4.TabIndex = 19;
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.Location = new System.Drawing.Point(12, 504);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(261, 95);
            this.listBox5.TabIndex = 20;
            // 
            // btn_add_gift
            // 
            this.btn_add_gift.Location = new System.Drawing.Point(197, 70);
            this.btn_add_gift.Name = "btn_add_gift";
            this.btn_add_gift.Size = new System.Drawing.Size(75, 23);
            this.btn_add_gift.TabIndex = 21;
            this.btn_add_gift.Text = "Add Gift";
            this.btn_add_gift.UseVisualStyleBackColor = true;
            this.btn_add_gift.Click += new System.EventHandler(this.btn_add_gift_Click);
            // 
            // list_name
            // 
            this.list_name.FormattingEnabled = true;
            this.list_name.Location = new System.Drawing.Point(93, 72);
            this.list_name.Name = "list_name";
            this.list_name.Size = new System.Drawing.Size(98, 21);
            this.list_name.TabIndex = 22;
            this.list_name.Text = "Select Name";
            this.list_name.SelectedValueChanged += new System.EventHandler(this.list_name_SelectedValueChanged);
            // 
            // MyHarvestmoonApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 611);
            this.Controls.Add(this.list_name);
            this.Controls.Add(this.btn_add_gift);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btn_data);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyHarvestmoonApp";
            this.Text = "MyHarvestmoonApp";
            this.Load += new System.EventHandler(this.MyHarvestmoonApp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_data;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.Button btn_add_gift;
        private System.Windows.Forms.ComboBox list_name;


    }
}