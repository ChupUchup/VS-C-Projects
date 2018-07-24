namespace MyHarvestmoon
{
    partial class form_data
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_data));
            this.btn_insert = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_likes = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_neutral = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_dislikes = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_hates = new System.Windows.Forms.RichTextBox();
            this.txt_loves = new System.Windows.Forms.RichTextBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(162, 71);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(51, 23);
            this.btn_insert.TabIndex = 22;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(59, 73);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(97, 20);
            this.txt_name.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Loves :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Likes :";
            // 
            // txt_likes
            // 
            this.txt_likes.Location = new System.Drawing.Point(58, 202);
            this.txt_likes.Name = "txt_likes";
            this.txt_likes.Size = new System.Drawing.Size(214, 95);
            this.txt_likes.TabIndex = 34;
            this.txt_likes.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Neutral :";
            // 
            // txt_neutral
            // 
            this.txt_neutral.Location = new System.Drawing.Point(58, 303);
            this.txt_neutral.Name = "txt_neutral";
            this.txt_neutral.Size = new System.Drawing.Size(214, 95);
            this.txt_neutral.TabIndex = 36;
            this.txt_neutral.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 440);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Dislikes :";
            // 
            // txt_dislikes
            // 
            this.txt_dislikes.Location = new System.Drawing.Point(58, 404);
            this.txt_dislikes.Name = "txt_dislikes";
            this.txt_dislikes.Size = new System.Drawing.Size(214, 95);
            this.txt_dislikes.TabIndex = 38;
            this.txt_dislikes.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 541);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Hates :";
            // 
            // txt_hates
            // 
            this.txt_hates.Location = new System.Drawing.Point(58, 505);
            this.txt_hates.Name = "txt_hates";
            this.txt_hates.Size = new System.Drawing.Size(214, 95);
            this.txt_hates.TabIndex = 40;
            this.txt_hates.Text = "";
            // 
            // txt_loves
            // 
            this.txt_loves.Location = new System.Drawing.Point(59, 101);
            this.txt_loves.Name = "txt_loves";
            this.txt_loves.Size = new System.Drawing.Size(214, 95);
            this.txt_loves.TabIndex = 30;
            this.txt_loves.Text = "";
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(222, 71);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(51, 23);
            this.btn_reset.TabIndex = 42;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // form_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 611);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_hates);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_dislikes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_neutral);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_likes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_loves);
            this.Controls.Add(this.btn_insert);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_data";
            this.Text = "form_data";
            this.Load += new System.EventHandler(this.form_data_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txt_likes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txt_neutral;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txt_dislikes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txt_hates;
        private System.Windows.Forms.RichTextBox txt_loves;
        private System.Windows.Forms.Button btn_reset;
    }
}