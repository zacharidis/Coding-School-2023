namespace Session_09
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrlGrougBoxResults = new System.Windows.Forms.GroupBox();
            this.ctrlTxtResults = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ctrlGrougBoxResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlGrougBoxResults
            // 
            this.ctrlGrougBoxResults.Controls.Add(this.ctrlTxtResults);
            this.ctrlGrougBoxResults.ForeColor = System.Drawing.Color.White;
            this.ctrlGrougBoxResults.Location = new System.Drawing.Point(22, 12);
            this.ctrlGrougBoxResults.Name = "ctrlGrougBoxResults";
            this.ctrlGrougBoxResults.Size = new System.Drawing.Size(446, 111);
            this.ctrlGrougBoxResults.TabIndex = 0;
            this.ctrlGrougBoxResults.TabStop = false;
            this.ctrlGrougBoxResults.Text = "Results :";
            // 
            // ctrlTxtResults
            // 
            this.ctrlTxtResults.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ctrlTxtResults.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ctrlTxtResults.ForeColor = System.Drawing.Color.White;
            this.ctrlTxtResults.Location = new System.Drawing.Point(16, 22);
            this.ctrlTxtResults.Name = "ctrlTxtResults";
            this.ctrlTxtResults.Size = new System.Drawing.Size(415, 71);
            this.ctrlTxtResults.TabIndex = 0;
            this.ctrlTxtResults.Text = "RESULTS";
            this.ctrlTxtResults.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(22, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 280);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(492, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctrlGrougBoxResults);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ctrlGrougBoxResults.ResumeLayout(false);
            this.ctrlGrougBoxResults.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox ctrlGrougBoxResults;
        private TextBox ctrlTxtResults;
        private GroupBox groupBox1;
    }
}