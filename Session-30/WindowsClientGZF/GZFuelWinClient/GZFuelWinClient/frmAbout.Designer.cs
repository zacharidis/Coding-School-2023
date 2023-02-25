namespace GZFuelWinClient
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            lblAbout = new Label();
            SuspendLayout();
            // 
            // lblAbout
            // 
            lblAbout.BorderStyle = BorderStyle.Fixed3D;
            lblAbout.FlatStyle = FlatStyle.Flat;
            lblAbout.Location = new Point(14, 10);
            lblAbout.Name = "lblAbout";
            lblAbout.Size = new Size(590, 402);
            lblAbout.TabIndex = 0;
            lblAbout.Text = resources.GetString("lblAbout.Text");
            lblAbout.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 428);
            Controls.Add(lblAbout);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmAbout";
            Text = "GZFuel Windows Client v 0.1";
            ResumeLayout(false);
        }

        #endregion

        private Label lblAbout;
    }
}