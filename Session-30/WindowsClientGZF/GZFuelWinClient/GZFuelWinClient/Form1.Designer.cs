namespace GZFuelWinClient
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			groupBox1 = new GroupBox();
			btnTransactions = new Button();
			btnInventory = new Button();
			btnCustomers = new Button();
			lblAbout = new Label();
			lblUnlock = new Label();
			pictureBox1 = new PictureBox();
			lblExit = new Label();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(btnTransactions);
			groupBox1.Controls.Add(btnInventory);
			groupBox1.Controls.Add(btnCustomers);
			groupBox1.Location = new Point(12, 79);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(446, 367);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			// 
			// btnTransactions
			// 
			btnTransactions.Location = new Point(19, 172);
			btnTransactions.Name = "btnTransactions";
			btnTransactions.Size = new Size(394, 40);
			btnTransactions.TabIndex = 2;
			btnTransactions.Text = "Transactions";
			btnTransactions.UseVisualStyleBackColor = true;
			// 
			// btnInventory
			// 
			btnInventory.Location = new Point(20, 108);
			btnInventory.Name = "btnInventory";
			btnInventory.Size = new Size(397, 43);
			btnInventory.TabIndex = 1;
			btnInventory.Text = "Inventory (Items)";
			btnInventory.UseVisualStyleBackColor = true;
			// 
			// btnCustomers
			// 
			btnCustomers.Location = new Point(20, 44);
			btnCustomers.Name = "btnCustomers";
			btnCustomers.Size = new Size(398, 44);
			btnCustomers.TabIndex = 0;
			btnCustomers.Text = "Customers";
			btnCustomers.UseVisualStyleBackColor = true;
			btnCustomers.Click += btnCustomers_Click;
			// 
			// lblAbout
			// 
			lblAbout.AutoSize = true;
			lblAbout.BorderStyle = BorderStyle.FixedSingle;
			lblAbout.Cursor = Cursors.Hand;
			lblAbout.Location = new Point(418, 61);
			lblAbout.Name = "lblAbout";
			lblAbout.Size = new Size(42, 17);
			lblAbout.TabIndex = 1;
			lblAbout.Text = "About";
			// 
			// lblUnlock
			// 
			lblUnlock.AutoSize = true;
			lblUnlock.BorderStyle = BorderStyle.FixedSingle;
			lblUnlock.Cursor = Cursors.Hand;
			lblUnlock.Location = new Point(12, 61);
			lblUnlock.Name = "lblUnlock";
			lblUnlock.Size = new Size(46, 17);
			lblUnlock.TabIndex = 2;
			lblUnlock.Text = "Unlock";
			lblUnlock.Click += lblUnlock_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(12, 452);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(190, 154);
			pictureBox1.TabIndex = 3;
			pictureBox1.TabStop = false;
			// 
			// lblExit
			// 
			lblExit.AutoSize = true;
			lblExit.BorderStyle = BorderStyle.FixedSingle;
			lblExit.Location = new Point(430, 589);
			lblExit.Name = "lblExit";
			lblExit.Size = new Size(28, 17);
			lblExit.TabIndex = 4;
			lblExit.Text = "Exit";
			lblExit.Click += lblExit_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(471, 618);
			Controls.Add(lblExit);
			Controls.Add(pictureBox1);
			Controls.Add(lblUnlock);
			Controls.Add(lblAbout);
			Controls.Add(groupBox1);
			Cursor = Cursors.Hand;
			FormBorderStyle = FormBorderStyle.None;
			Name = "Form1";
			Text = "GZFuel  Made For Epsilon Net Coding School 2023";
			Load += Form1_Load;
			MouseDown += Form1_MouseDown;
			groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private GroupBox groupBox1;
		private Label lblAbout;
		private Label lblUnlock;
		private Button btnTransactions;
		private Button btnInventory;
		private Button btnCustomers;
		private PictureBox pictureBox1;
		private Label lblExit;
	}
}