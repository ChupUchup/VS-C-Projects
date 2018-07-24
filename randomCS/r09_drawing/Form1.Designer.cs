namespace r09_drawing
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
            this.numStart1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numSweep1 = new System.Windows.Forms.NumericUpDown();
            this.numStart2 = new System.Windows.Forms.NumericUpDown();
            this.numSweep2 = new System.Windows.Forms.NumericUpDown();
            this.numStart3 = new System.Windows.Forms.NumericUpDown();
            this.numSweep3 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numStart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSweep1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSweep2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSweep3)).BeginInit();
            this.SuspendLayout();
            // 
            // numStart1
            // 
            this.numStart1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numStart1.Location = new System.Drawing.Point(88, 7);
            this.numStart1.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numStart1.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.numStart1.Name = "numStart1";
            this.numStart1.Size = new System.Drawing.Size(47, 20);
            this.numStart1.TabIndex = 0;
            this.numStart1.ValueChanged += new System.EventHandler(this.numStartSweep_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start Angle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sweep Angle";
            // 
            // numSweep1
            // 
            this.numSweep1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSweep1.Location = new System.Drawing.Point(88, 33);
            this.numSweep1.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numSweep1.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.numSweep1.Name = "numSweep1";
            this.numSweep1.Size = new System.Drawing.Size(47, 20);
            this.numSweep1.TabIndex = 2;
            this.numSweep1.ValueChanged += new System.EventHandler(this.numStartSweep_ValueChanged);
            // 
            // numStart2
            // 
            this.numStart2.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numStart2.Location = new System.Drawing.Point(141, 7);
            this.numStart2.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numStart2.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.numStart2.Name = "numStart2";
            this.numStart2.Size = new System.Drawing.Size(47, 20);
            this.numStart2.TabIndex = 0;
            this.numStart2.ValueChanged += new System.EventHandler(this.numStartSweep_ValueChanged);
            // 
            // numSweep2
            // 
            this.numSweep2.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSweep2.Location = new System.Drawing.Point(141, 33);
            this.numSweep2.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numSweep2.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.numSweep2.Name = "numSweep2";
            this.numSweep2.Size = new System.Drawing.Size(47, 20);
            this.numSweep2.TabIndex = 2;
            this.numSweep2.ValueChanged += new System.EventHandler(this.numStartSweep_ValueChanged);
            // 
            // numStart3
            // 
            this.numStart3.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numStart3.Location = new System.Drawing.Point(194, 7);
            this.numStart3.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numStart3.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.numStart3.Name = "numStart3";
            this.numStart3.Size = new System.Drawing.Size(47, 20);
            this.numStart3.TabIndex = 0;
            this.numStart3.ValueChanged += new System.EventHandler(this.numStartSweep_ValueChanged);
            // 
            // numSweep3
            // 
            this.numSweep3.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSweep3.Location = new System.Drawing.Point(194, 33);
            this.numSweep3.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numSweep3.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.numSweep3.Name = "numSweep3";
            this.numSweep3.Size = new System.Drawing.Size(47, 20);
            this.numSweep3.TabIndex = 2;
            this.numSweep3.ValueChanged += new System.EventHandler(this.numStartSweep_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numSweep3);
            this.Controls.Add(this.numSweep2);
            this.Controls.Add(this.numSweep1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numStart3);
            this.Controls.Add(this.numStart2);
            this.Controls.Add(this.numStart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numStart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSweep1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSweep2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSweep3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numStart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numSweep1;
        private System.Windows.Forms.NumericUpDown numStart2;
        private System.Windows.Forms.NumericUpDown numSweep2;
        private System.Windows.Forms.NumericUpDown numStart3;
        private System.Windows.Forms.NumericUpDown numSweep3;
    }
}

