namespace Session_15
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
            groupBox1 = new GroupBox();
            chkPepsi = new CheckBox();
            chkSalad = new CheckBox();
            chkFries = new CheckBox();
            chkStew = new CheckBox();
            btnPrepare = new Button();
            groupBox2 = new GroupBox();
            pbPepsi = new PictureBox();
            pbSalad = new PictureBox();
            pbFries = new PictureBox();
            pbStew = new PictureBox();
            btnAbout = new Button();
            pictureBox1 = new PictureBox();
            progressBar1 = new ProgressBar();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPepsi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSalad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFries).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbStew).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkPepsi);
            groupBox1.Controls.Add(chkSalad);
            groupBox1.Controls.Add(chkFries);
            groupBox1.Controls.Add(chkStew);
            groupBox1.Location = new Point(28, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(163, 139);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menu";
            // 
            // chkPepsi
            // 
            chkPepsi.AutoSize = true;
            chkPepsi.Location = new Point(35, 107);
            chkPepsi.Name = "chkPepsi";
            chkPepsi.Size = new Size(85, 19);
            chkPepsi.TabIndex = 3;
            chkPepsi.Text = "Drink Pepsi";
            chkPepsi.UseVisualStyleBackColor = true;
            chkPepsi.CheckedChanged += chkPepsi_CheckedChanged;
            // 
            // chkSalad
            // 
            chkSalad.AutoSize = true;
            chkSalad.Location = new Point(35, 82);
            chkSalad.Name = "chkSalad";
            chkSalad.Size = new Size(73, 19);
            chkSalad.TabIndex = 2;
            chkSalad.Text = "Eat Salad";
            chkSalad.UseVisualStyleBackColor = true;
            chkSalad.CheckedChanged += chkSalad_CheckedChanged;
            // 
            // chkFries
            // 
            chkFries.AutoSize = true;
            chkFries.Location = new Point(35, 57);
            chkFries.Name = "chkFries";
            chkFries.Size = new Size(69, 19);
            chkFries.TabIndex = 1;
            chkFries.Text = "Eat Fries";
            chkFries.UseVisualStyleBackColor = true;
            chkFries.CheckedChanged += chkFries_CheckedChanged;
            // 
            // chkStew
            // 
            chkStew.AutoSize = true;
            chkStew.Location = new Point(35, 32);
            chkStew.Name = "chkStew";
            chkStew.Size = new Size(70, 19);
            chkStew.TabIndex = 0;
            chkStew.Text = "Eat Stew";
            chkStew.UseVisualStyleBackColor = true;
            chkStew.CheckedChanged += chkStew_CheckedChanged;
            // 
            // btnPrepare
            // 
            btnPrepare.Location = new Point(229, 67);
            btnPrepare.Name = "btnPrepare";
            btnPrepare.Size = new Size(146, 45);
            btnPrepare.TabIndex = 1;
            btnPrepare.Text = "Prepare";
            btnPrepare.UseVisualStyleBackColor = true;
            btnPrepare.Click += btnPrepare_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(progressBar1);
            groupBox2.Controls.Add(pbPepsi);
            groupBox2.Controls.Add(pbSalad);
            groupBox2.Controls.Add(pbFries);
            groupBox2.Controls.Add(pbStew);
            groupBox2.Location = new Point(28, 169);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(770, 635);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Progress";
            // 
            // pbPepsi
            // 
            pbPepsi.Location = new Point(9, 491);
            pbPepsi.Name = "pbPepsi";
            pbPepsi.Size = new Size(153, 122);
            pbPepsi.TabIndex = 3;
            pbPepsi.TabStop = false;
            // 
            // pbSalad
            // 
            pbSalad.Location = new Point(7, 338);
            pbSalad.Name = "pbSalad";
            pbSalad.Size = new Size(156, 137);
            pbSalad.TabIndex = 2;
            pbSalad.TabStop = false;
            // 
            // pbFries
            // 
            pbFries.Location = new Point(6, 186);
            pbFries.Name = "pbFries";
            pbFries.Size = new Size(156, 136);
            pbFries.TabIndex = 1;
            pbFries.TabStop = false;
            // 
            // pbStew
            // 
            pbStew.Location = new Point(6, 34);
            pbStew.Name = "pbStew";
            pbStew.Size = new Size(156, 102);
            pbStew.TabIndex = 0;
            pbStew.TabStop = false;
            // 
            // btnAbout
            // 
            btnAbout.Location = new Point(875, 762);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(68, 42);
            btnAbout.TabIndex = 3;
            btnAbout.Text = "About";
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += btnAbout_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resource1.eat;
            pictureBox1.Location = new Point(816, 303);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 225);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(9, 142);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(723, 23);
            progressBar1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(970, 816);
            Controls.Add(pictureBox1);
            Controls.Add(btnAbout);
            Controls.Add(groupBox2);
            Controls.Add(btnPrepare);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "- E -  Async Kitchen";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbPepsi).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSalad).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFries).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbStew).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox chkPepsi;
        private CheckBox chkSalad;
        private CheckBox chkFries;
        private CheckBox chkStew;
        private Button btnPrepare;
        private GroupBox groupBox2;
        private PictureBox pbPepsi;
        private PictureBox pbSalad;
        private PictureBox pbFries;
        private PictureBox pbStew;
        private Button btnAbout;
        private PictureBox pictureBox1;
        private ProgressBar progressBar1;
    }
}