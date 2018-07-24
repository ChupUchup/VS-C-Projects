namespace Steganography
{
    partial class Form1
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
            this.progressBarExtract = new System.Windows.Forms.ProgressBar();
            this.progressBarEmbed = new System.Windows.Forms.ProgressBar();
            this.lblExtract = new System.Windows.Forms.Label();
            this.lblEmbed = new System.Windows.Forms.Label();
            this.btnExtract = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEmbedMax = new System.Windows.Forms.Label();
            this.lblExtractCount = new System.Windows.Forms.Label();
            this.lblEmbedCount = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnEmbed = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBarExtract
            // 
            this.progressBarExtract.Location = new System.Drawing.Point(384, 455);
            this.progressBarExtract.Name = "progressBarExtract";
            this.progressBarExtract.Size = new System.Drawing.Size(360, 12);
            this.progressBarExtract.Step = 1;
            this.progressBarExtract.TabIndex = 38;
            // 
            // progressBarEmbed
            // 
            this.progressBarEmbed.Location = new System.Drawing.Point(12, 454);
            this.progressBarEmbed.Name = "progressBarEmbed";
            this.progressBarEmbed.Size = new System.Drawing.Size(361, 12);
            this.progressBarEmbed.Step = 1;
            this.progressBarEmbed.TabIndex = 37;
            // 
            // lblExtract
            // 
            this.lblExtract.AutoSize = true;
            this.lblExtract.Location = new System.Drawing.Point(381, 471);
            this.lblExtract.Name = "lblExtract";
            this.lblExtract.Size = new System.Drawing.Size(75, 13);
            this.lblExtract.TabIndex = 36;
            this.lblExtract.Text = "Extract Time : ";
            // 
            // lblEmbed
            // 
            this.lblEmbed.AutoSize = true;
            this.lblEmbed.Location = new System.Drawing.Point(10, 470);
            this.lblEmbed.Name = "lblEmbed";
            this.lblEmbed.Size = new System.Drawing.Size(75, 13);
            this.lblEmbed.TabIndex = 35;
            this.lblEmbed.Text = "Embed Time : ";
            // 
            // btnExtract
            // 
            this.btnExtract.Location = new System.Drawing.Point(668, 119);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(75, 23);
            this.btnExtract.TabIndex = 34;
            this.btnExtract.Text = "Extract";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(384, 13);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(360, 99);
            this.richTextBox2.TabIndex = 33;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(361, 99);
            this.richTextBox1.TabIndex = 32;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(384, 118);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(360, 330);
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(361, 330);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // lblEmbedMax
            // 
            this.lblEmbedMax.AutoSize = true;
            this.lblEmbedMax.Location = new System.Drawing.Point(181, 487);
            this.lblEmbedMax.Name = "lblEmbedMax";
            this.lblEmbedMax.Size = new System.Drawing.Size(78, 13);
            this.lblEmbedMax.TabIndex = 41;
            this.lblEmbedMax.Text = "Max Embed : 0";
            // 
            // lblExtractCount
            // 
            this.lblExtractCount.AutoSize = true;
            this.lblExtractCount.Location = new System.Drawing.Point(381, 488);
            this.lblExtractCount.Name = "lblExtractCount";
            this.lblExtractCount.Size = new System.Drawing.Size(86, 13);
            this.lblExtractCount.TabIndex = 40;
            this.lblExtractCount.Text = "Extract Count : 0";
            // 
            // lblEmbedCount
            // 
            this.lblEmbedCount.AutoSize = true;
            this.lblEmbedCount.Location = new System.Drawing.Point(10, 487);
            this.lblEmbedCount.Name = "lblEmbedCount";
            this.lblEmbedCount.Size = new System.Drawing.Size(86, 13);
            this.lblEmbedCount.TabIndex = 39;
            this.lblEmbedCount.Text = "Embed Count : 0";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(13, 119);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 42;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnEmbed
            // 
            this.btnEmbed.Location = new System.Drawing.Point(297, 119);
            this.btnEmbed.Name = "btnEmbed";
            this.btnEmbed.Size = new System.Drawing.Size(75, 23);
            this.btnEmbed.TabIndex = 43;
            this.btnEmbed.Text = "Embed";
            this.btnEmbed.UseVisualStyleBackColor = true;
            this.btnEmbed.Click += new System.EventHandler(this.btnEmbed_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 513);
            this.Controls.Add(this.btnEmbed);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.progressBarExtract);
            this.Controls.Add(this.progressBarEmbed);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblExtract);
            this.Controls.Add(this.lblEmbedCount);
            this.Controls.Add(this.lblEmbed);
            this.Controls.Add(this.lblExtractCount);
            this.Controls.Add(this.btnExtract);
            this.Controls.Add(this.lblEmbedMax);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Least Significant Bit";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarExtract;
        private System.Windows.Forms.ProgressBar progressBarEmbed;
        private System.Windows.Forms.Label lblExtract;
        private System.Windows.Forms.Label lblEmbed;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEmbedMax;
        private System.Windows.Forms.Label lblExtractCount;
        private System.Windows.Forms.Label lblEmbedCount;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnEmbed;

    }
}

