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
            lblAbout.Location = new Point(12, 9);
            lblAbout.Name = "lblAbout";
            lblAbout.Size = new Size(516, 355);
            lblAbout.TabIndex = 0;
            lblAbout.Text = resources.GetString("lblAbout.Text");
            // 
            // frmAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 396);
            Controls.Add(lblAbout);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmAbout";
            Text = "frmAbout";
            ResumeLayout(false);
        }

        #endregion

        private Label lblAbout;
    }
}