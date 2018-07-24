namespace WMIClass
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
            this.cmb_processor = new System.Windows.Forms.ComboBox();
            this.cmb_diskdrive = new System.Windows.Forms.ComboBox();
            this.cmb_networkadapter = new System.Windows.Forms.ComboBox();
            this.txt_procid = new System.Windows.Forms.TextBox();
            this.txt_diskserial = new System.Windows.Forms.TextBox();
            this.txt_networkguid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_mac = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txt_md5 = new System.Windows.Forms.TextBox();
            this.btn_generatehwid = new System.Windows.Forms.Button();
            this.txt_sha256 = new System.Windows.Forms.TextBox();
            this.txt_sha512 = new System.Windows.Forms.TextBox();
            this.lbl_md5 = new System.Windows.Forms.Label();
            this.lbl_sha256 = new System.Windows.Forms.Label();
            this.lbl_sha512 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_processor
            // 
            this.cmb_processor.FormattingEnabled = true;
            this.cmb_processor.Location = new System.Drawing.Point(119, 6);
            this.cmb_processor.Name = "cmb_processor";
            this.cmb_processor.Size = new System.Drawing.Size(877, 21);
            this.cmb_processor.TabIndex = 0;
            this.cmb_processor.Text = "Pilih Processor";
            this.cmb_processor.SelectedIndexChanged += new System.EventHandler(this.cmb_processor_SelectedIndexChanged);
            // 
            // cmb_diskdrive
            // 
            this.cmb_diskdrive.FormattingEnabled = true;
            this.cmb_diskdrive.Location = new System.Drawing.Point(119, 59);
            this.cmb_diskdrive.Name = "cmb_diskdrive";
            this.cmb_diskdrive.Size = new System.Drawing.Size(877, 21);
            this.cmb_diskdrive.TabIndex = 1;
            this.cmb_diskdrive.Text = "Pilih Harddisk";
            this.cmb_diskdrive.SelectedIndexChanged += new System.EventHandler(this.cmb_diskdrive_SelectedIndexChanged);
            // 
            // cmb_networkadapter
            // 
            this.cmb_networkadapter.FormattingEnabled = true;
            this.cmb_networkadapter.Location = new System.Drawing.Point(119, 112);
            this.cmb_networkadapter.Name = "cmb_networkadapter";
            this.cmb_networkadapter.Size = new System.Drawing.Size(877, 21);
            this.cmb_networkadapter.TabIndex = 2;
            this.cmb_networkadapter.Text = "Pilih Network Adapter";
            this.cmb_networkadapter.SelectedIndexChanged += new System.EventHandler(this.cmb_networkadapter_SelectedIndexChanged);
            // 
            // txt_procid
            // 
            this.txt_procid.Enabled = false;
            this.txt_procid.Location = new System.Drawing.Point(119, 33);
            this.txt_procid.Name = "txt_procid";
            this.txt_procid.Size = new System.Drawing.Size(877, 20);
            this.txt_procid.TabIndex = 2;
            this.txt_procid.TextChanged += new System.EventHandler(this.txt_input_TextChanged);
            // 
            // txt_diskserial
            // 
            this.txt_diskserial.Enabled = false;
            this.txt_diskserial.Location = new System.Drawing.Point(119, 86);
            this.txt_diskserial.Name = "txt_diskserial";
            this.txt_diskserial.Size = new System.Drawing.Size(877, 20);
            this.txt_diskserial.TabIndex = 2;
            this.txt_diskserial.TextChanged += new System.EventHandler(this.txt_input_TextChanged);
            // 
            // txt_networkguid
            // 
            this.txt_networkguid.Enabled = false;
            this.txt_networkguid.Location = new System.Drawing.Point(119, 139);
            this.txt_networkguid.Name = "txt_networkguid";
            this.txt_networkguid.Size = new System.Drawing.Size(877, 20);
            this.txt_networkguid.TabIndex = 2;
            this.txt_networkguid.TextChanged += new System.EventHandler(this.txt_input_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Processor Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Diskdrive Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Network Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Processor Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Diskdrive Serial";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Network GUID";
            // 
            // txt_mac
            // 
            this.txt_mac.Enabled = false;
            this.txt_mac.Location = new System.Drawing.Point(119, 165);
            this.txt_mac.Name = "txt_mac";
            this.txt_mac.Size = new System.Drawing.Size(877, 20);
            this.txt_mac.TabIndex = 2;
            this.txt_mac.TextChanged += new System.EventHandler(this.txt_input_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Network MAC";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(119, 191);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(877, 11);
            this.progressBar1.TabIndex = 4;
            // 
            // txt_md5
            // 
            this.txt_md5.Location = new System.Drawing.Point(119, 208);
            this.txt_md5.Name = "txt_md5";
            this.txt_md5.Size = new System.Drawing.Size(877, 20);
            this.txt_md5.TabIndex = 2;
            // 
            // btn_generatehwid
            // 
            this.btn_generatehwid.Location = new System.Drawing.Point(12, 184);
            this.btn_generatehwid.Name = "btn_generatehwid";
            this.btn_generatehwid.Size = new System.Drawing.Size(98, 23);
            this.btn_generatehwid.TabIndex = 5;
            this.btn_generatehwid.Text = "Generate HWID";
            this.btn_generatehwid.UseVisualStyleBackColor = true;
            this.btn_generatehwid.Click += new System.EventHandler(this.btn_generatehwid_Click);
            // 
            // txt_sha256
            // 
            this.txt_sha256.Location = new System.Drawing.Point(119, 234);
            this.txt_sha256.Name = "txt_sha256";
            this.txt_sha256.Size = new System.Drawing.Size(877, 20);
            this.txt_sha256.TabIndex = 2;
            // 
            // txt_sha512
            // 
            this.txt_sha512.Location = new System.Drawing.Point(119, 260);
            this.txt_sha512.Name = "txt_sha512";
            this.txt_sha512.Size = new System.Drawing.Size(877, 20);
            this.txt_sha512.TabIndex = 2;
            // 
            // lbl_md5
            // 
            this.lbl_md5.AutoSize = true;
            this.lbl_md5.Location = new System.Drawing.Point(61, 211);
            this.lbl_md5.Name = "lbl_md5";
            this.lbl_md5.Size = new System.Drawing.Size(37, 13);
            this.lbl_md5.TabIndex = 3;
            this.lbl_md5.Text = "Digit";
            // 
            // lbl_sha256
            // 
            this.lbl_sha256.AutoSize = true;
            this.lbl_sha256.Location = new System.Drawing.Point(61, 237);
            this.lbl_sha256.Name = "lbl_sha256";
            this.lbl_sha256.Size = new System.Drawing.Size(37, 13);
            this.lbl_sha256.TabIndex = 3;
            this.lbl_sha256.Text = "Digit";
            // 
            // lbl_sha512
            // 
            this.lbl_sha512.AutoSize = true;
            this.lbl_sha512.Location = new System.Drawing.Point(61, 263);
            this.lbl_sha512.Name = "lbl_sha512";
            this.lbl_sha512.Size = new System.Drawing.Size(37, 13);
            this.lbl_sha512.TabIndex = 3;
            this.lbl_sha512.Text = "Digit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 286);
            this.Controls.Add(this.btn_generatehwid);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbl_sha512);
            this.Controls.Add(this.lbl_sha256);
            this.Controls.Add(this.lbl_md5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_sha512);
            this.Controls.Add(this.txt_sha256);
            this.Controls.Add(this.txt_md5);
            this.Controls.Add(this.txt_mac);
            this.Controls.Add(this.txt_networkguid);
            this.Controls.Add(this.txt_diskserial);
            this.Controls.Add(this.txt_procid);
            this.Controls.Add(this.cmb_networkadapter);
            this.Controls.Add(this.cmb_diskdrive);
            this.Controls.Add(this.cmb_processor);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "HWID Generator";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_processor;
        private System.Windows.Forms.ComboBox cmb_diskdrive;
        private System.Windows.Forms.ComboBox cmb_networkadapter;
        private System.Windows.Forms.TextBox txt_procid;
        private System.Windows.Forms.TextBox txt_diskserial;
        private System.Windows.Forms.TextBox txt_networkguid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_mac;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txt_md5;
        private System.Windows.Forms.Button btn_generatehwid;
        private System.Windows.Forms.TextBox txt_sha256;
        private System.Windows.Forms.TextBox txt_sha512;
        private System.Windows.Forms.Label lbl_md5;
        private System.Windows.Forms.Label lbl_sha256;
        private System.Windows.Forms.Label lbl_sha512;
    }
}

