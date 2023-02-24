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
			grbUserDetails = new GroupBox();
			lblCustomerId = new Label();
			txtCustomerId = new TextBox();
			txtCustomerName = new TextBox();
			txtCustomerSurname = new TextBox();
			lblCustomerName = new Label();
			lblCustomerSurname = new Label();
			((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
			grbUserDetails.SuspendLayout();
			SuspendLayout();
			// 
			// dgvCustomers
			// 
			dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvCustomers.Location = new Point(14, 18);
			dgvCustomers.MultiSelect = false;
			dgvCustomers.Name = "dgvCustomers";
			dgvCustomers.ReadOnly = true;
			dgvCustomers.RowTemplate.Height = 25;
			dgvCustomers.Size = new Size(457, 185);
			dgvCustomers.TabIndex = 0;
			dgvCustomers.CellContentClick += dgvCustomers_CellContentClick;
			dgvCustomers.CellDoubleClick += dgvCustomers_CellDoubleClick;
			// 
			// grbUserDetails
			// 
			grbUserDetails.Controls.Add(lblCustomerSurname);
			grbUserDetails.Controls.Add(lblCustomerName);
			grbUserDetails.Controls.Add(txtCustomerSurname);
			grbUserDetails.Controls.Add(txtCustomerName);
			grbUserDetails.Controls.Add(txtCustomerId);
			grbUserDetails.Controls.Add(lblCustomerId);
			grbUserDetails.Location = new Point(494, 12);
			grbUserDetails.Name = "grbUserDetails";
			grbUserDetails.Size = new Size(327, 191);
			grbUserDetails.TabIndex = 1;
			grbUserDetails.TabStop = false;
			grbUserDetails.Text = "Customer Details";
			// 
			// lblCustomerId
			// 
			lblCustomerId.AutoSize = true;
			lblCustomerId.Location = new Point(15, 29);
			lblCustomerId.Name = "lblCustomerId";
			lblCustomerId.Size = new Size(82, 15);
			lblCustomerId.TabIndex = 0;
			lblCustomerId.Text = "Customer ID : ";
			// 
			// txtCustomerId
			// 
			txtCustomerId.Location = new Point(130, 26);
			txtCustomerId.Name = "txtCustomerId";
			txtCustomerId.Size = new Size(190, 23);
			txtCustomerId.TabIndex = 1;
			// 
			// txtCustomerName
			// 
			txtCustomerName.Location = new Point(130, 68);
			txtCustomerName.Name = "txtCustomerName";
			txtCustomerName.Size = new Size(190, 23);
			txtCustomerName.TabIndex = 2;
			// 
			// txtCustomerSurname
			// 
			txtCustomerSurname.Location = new Point(130, 114);
			txtCustomerSurname.Name = "txtCustomerSurname";
			txtCustomerSurname.Size = new Size(190, 23);
			txtCustomerSurname.TabIndex = 3;
			// 
			// lblCustomerName
			// 
			lblCustomerName.AutoSize = true;
			lblCustomerName.Location = new Point(15, 71);
			lblCustomerName.Name = "lblCustomerName";
			lblCustomerName.Size = new Size(100, 15);
			lblCustomerName.TabIndex = 4;
			lblCustomerName.Text = "Customer Name :";
			// 
			// lblCustomerSurname
			// 
			lblCustomerSurname.AutoSize = true;
			lblCustomerSurname.Location = new Point(9, 117);
			lblCustomerSurname.Name = "lblCustomerSurname";
			lblCustomerSurname.Size = new Size(115, 15);
			lblCustomerSurname.TabIndex = 5;
			lblCustomerSurname.Text = "Customer Surname :";
			// 
			// frmCustomer
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(980, 639);
			Controls.Add(grbUserDetails);
			Controls.Add(dgvCustomers);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Name = "frmCustomer";
			Text = "Customers";
			Load += frmCustomer_Load;
			((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
			grbUserDetails.ResumeLayout(false);
			grbUserDetails.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dgvCustomers;
		private GroupBox grbUserDetails;
		private Label lblCustomerSurname;
		private Label lblCustomerName;
		private TextBox txtCustomerSurname;
		private TextBox txtCustomerName;
		private TextBox txtCustomerId;
		private Label lblCustomerId;
	}
}