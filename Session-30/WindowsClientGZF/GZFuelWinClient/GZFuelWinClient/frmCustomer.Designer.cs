namespace GZFuelWinClient
{
	partial class frmCustomer
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
			dgvCustomers = new DataGridView();
			((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
			SuspendLayout();
			// 
			// dgvCustomers
			// 
			dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvCustomers.Location = new Point(14, 18);
			dgvCustomers.Name = "dgvCustomers";
			dgvCustomers.RowTemplate.Height = 25;
			dgvCustomers.Size = new Size(810, 308);
			dgvCustomers.TabIndex = 0;
			// 
			// frmCustomer
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(836, 611);
			Controls.Add(dgvCustomers);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Name = "frmCustomer";
			Text = "Customers";
			Load += frmCustomer_Load;
			((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dgvCustomers;
	}
}