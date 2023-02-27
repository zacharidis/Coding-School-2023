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
            txtCusCard = new TextBox();
            lblCusCard = new Label();
            btnUpCustomer = new Button();
            btnDelCustomer = new Button();
            lblCustomerSurname = new Label();
            lblCustomerName = new Label();
            txtCustomerSurname = new TextBox();
            txtCustomerName = new TextBox();
            txtCustomerId = new TextBox();
            lblCustomerId = new Label();
            grbNewCustomer = new GroupBox();
            btnAddNewCustomer = new Button();
            lblhint = new Label();
            txtNewCusSurname = new TextBox();
            lblNewCustSurname = new Label();
            txtNewCusName = new TextBox();
            lblNewCustomerName = new Label();
            button1 = new Button();
            gpbTransactions = new GroupBox();
            dgvTransactions = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            grbUserDetails.SuspendLayout();
            grbNewCustomer.SuspendLayout();
            gpbTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
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
            dgvCustomers.Size = new Size(637, 185);
            dgvCustomers.TabIndex = 0;
            dgvCustomers.CellContentClick += dgvCustomers_CellContentClick;
            dgvCustomers.CellDoubleClick += dgvCustomers_CellDoubleClick;
            // 
            // grbUserDetails
            // 
            grbUserDetails.Controls.Add(txtCusCard);
            grbUserDetails.Controls.Add(lblCusCard);
            grbUserDetails.Controls.Add(btnUpCustomer);
            grbUserDetails.Controls.Add(btnDelCustomer);
            grbUserDetails.Controls.Add(lblCustomerSurname);
            grbUserDetails.Controls.Add(lblCustomerName);
            grbUserDetails.Controls.Add(txtCustomerSurname);
            grbUserDetails.Controls.Add(txtCustomerName);
            grbUserDetails.Controls.Add(txtCustomerId);
            grbUserDetails.Controls.Add(lblCustomerId);
            grbUserDetails.Location = new Point(14, 230);
            grbUserDetails.Name = "grbUserDetails";
            grbUserDetails.Size = new Size(327, 224);
            grbUserDetails.TabIndex = 1;
            grbUserDetails.TabStop = false;
            grbUserDetails.Text = "Customer Details";
            // 
            // txtCusCard
            // 
            txtCusCard.Enabled = false;
            txtCusCard.Location = new Point(132, 151);
            txtCusCard.Name = "txtCusCard";
            txtCusCard.Size = new Size(188, 23);
            txtCusCard.TabIndex = 9;
            // 
            // lblCusCard
            // 
            lblCusCard.AutoSize = true;
            lblCusCard.Location = new Point(14, 158);
            lblCusCard.Name = "lblCusCard";
            lblCusCard.Size = new Size(93, 15);
            lblCusCard.TabIndex = 8;
            lblCusCard.Text = "Customer Card :";
            // 
            // btnUpCustomer
            // 
            btnUpCustomer.Location = new Point(178, 186);
            btnUpCustomer.Name = "btnUpCustomer";
            btnUpCustomer.Size = new Size(143, 27);
            btnUpCustomer.TabIndex = 7;
            btnUpCustomer.Text = "Update Customer";
            btnUpCustomer.UseVisualStyleBackColor = true;
            btnUpCustomer.Click += button2_Click;
            // 
            // btnDelCustomer
            // 
            btnDelCustomer.Location = new Point(14, 186);
            btnDelCustomer.Name = "btnDelCustomer";
            btnDelCustomer.Size = new Size(120, 27);
            btnDelCustomer.TabIndex = 6;
            btnDelCustomer.Text = "Delete Customer";
            btnDelCustomer.UseVisualStyleBackColor = true;
            btnDelCustomer.Click += button1_Click;
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
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(15, 71);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(100, 15);
            lblCustomerName.TabIndex = 4;
            lblCustomerName.Text = "Customer Name :";
            // 
            // txtCustomerSurname
            // 
            txtCustomerSurname.Location = new Point(130, 114);
            txtCustomerSurname.Name = "txtCustomerSurname";
            txtCustomerSurname.Size = new Size(190, 23);
            txtCustomerSurname.TabIndex = 3;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(130, 68);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(190, 23);
            txtCustomerName.TabIndex = 2;
            // 
            // txtCustomerId
            // 
            txtCustomerId.Enabled = false;
            txtCustomerId.Location = new Point(130, 26);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.Size = new Size(190, 23);
            txtCustomerId.TabIndex = 1;
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
            // grbNewCustomer
            // 
            grbNewCustomer.Controls.Add(btnAddNewCustomer);
            grbNewCustomer.Controls.Add(lblhint);
            grbNewCustomer.Controls.Add(txtNewCusSurname);
            grbNewCustomer.Controls.Add(lblNewCustSurname);
            grbNewCustomer.Controls.Add(txtNewCusName);
            grbNewCustomer.Controls.Add(lblNewCustomerName);
            grbNewCustomer.Location = new Point(357, 230);
            grbNewCustomer.Name = "grbNewCustomer";
            grbNewCustomer.Size = new Size(294, 224);
            grbNewCustomer.TabIndex = 2;
            grbNewCustomer.TabStop = false;
            grbNewCustomer.Text = "Add New Customer";
            // 
            // btnAddNewCustomer
            // 
            btnAddNewCustomer.Location = new Point(69, 146);
            btnAddNewCustomer.Name = "btnAddNewCustomer";
            btnAddNewCustomer.Size = new Size(140, 37);
            btnAddNewCustomer.TabIndex = 6;
            btnAddNewCustomer.Text = "Add";
            btnAddNewCustomer.UseVisualStyleBackColor = true;
            btnAddNewCustomer.Click += btnAddNewCustomer_Click;
            // 
            // lblhint
            // 
            lblhint.AutoSize = true;
            lblhint.Location = new Point(38, 186);
            lblhint.Name = "lblhint";
            lblhint.Size = new Size(215, 15);
            lblhint.TabIndex = 5;
            lblhint.Text = "Customer's Card will be auto generated";
            // 
            // txtNewCusSurname
            // 
            txtNewCusSurname.Location = new Point(28, 109);
            txtNewCusSurname.Name = "txtNewCusSurname";
            txtNewCusSurname.Size = new Size(241, 23);
            txtNewCusSurname.TabIndex = 3;
            // 
            // lblNewCustSurname
            // 
            lblNewCustSurname.Location = new Point(79, 88);
            lblNewCustSurname.Name = "lblNewCustSurname";
            lblNewCustSurname.Size = new Size(141, 23);
            lblNewCustSurname.TabIndex = 2;
            lblNewCustSurname.Text = "Custumer Surname :";
            // 
            // txtNewCusName
            // 
            txtNewCusName.Location = new Point(26, 50);
            txtNewCusName.Name = "txtNewCusName";
            txtNewCusName.Size = new Size(243, 23);
            txtNewCusName.TabIndex = 1;
            // 
            // lblNewCustomerName
            // 
            lblNewCustomerName.AutoSize = true;
            lblNewCustomerName.Location = new Point(90, 29);
            lblNewCustomerName.Name = "lblNewCustomerName";
            lblNewCustomerName.Size = new Size(100, 15);
            lblNewCustomerName.TabIndex = 0;
            lblNewCustomerName.Text = "Customer Name :";
            // 
            // button1
            // 
            button1.Location = new Point(657, 20);
            button1.Name = "button1";
            button1.Size = new Size(32, 434);
            button1.TabIndex = 3;
            button1.Text = "->";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // gpbTransactions
            // 
            gpbTransactions.Controls.Add(dgvTransactions);
            gpbTransactions.Location = new Point(704, 11);
            gpbTransactions.Name = "gpbTransactions";
            gpbTransactions.Size = new Size(469, 392);
            gpbTransactions.TabIndex = 4;
            gpbTransactions.TabStop = false;
            gpbTransactions.Text = "Customers Transactions";
            // 
            // dgvTransactions
            // 
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactions.Location = new Point(17, 25);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.ReadOnly = true;
            dgvTransactions.RowTemplate.Height = 25;
            dgvTransactions.Size = new Size(436, 352);
            dgvTransactions.TabIndex = 0;
            // 
            // frmCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 594);
            Controls.Add(gpbTransactions);
            Controls.Add(button1);
            Controls.Add(grbNewCustomer);
            Controls.Add(grbUserDetails);
            Controls.Add(dgvCustomers);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmCustomer";
            Text = "Customers";
            Load += frmCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            grbUserDetails.ResumeLayout(false);
            grbUserDetails.PerformLayout();
            grbNewCustomer.ResumeLayout(false);
            grbNewCustomer.PerformLayout();
            gpbTransactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
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
        private Button btnUpCustomer;
        private Button btnDelCustomer;
        private TextBox txtCusCard;
        private Label lblCusCard;
        private GroupBox grbNewCustomer;
        private Label lblNewCustomerName;
        private TextBox txtNewCusSurname;
        private Label lblNewCustSurname;
        private TextBox txtNewCusName;
        private Label lblhint;
        private Button btnAddNewCustomer;
        private Button button1;
        private GroupBox gpbTransactions;
        private DataGridView dgvTransactions;
    }
}