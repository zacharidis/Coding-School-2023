namespace GZFuelWinClient
{
    partial class frmItems
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
            dgvItems = new DataGridView();
            groupBox1 = new GroupBox();
            gbxItemDetails = new GroupBox();
            btnDeleteItem = new Button();
            cmbItemType = new ComboBox();
            txtItemCost = new TextBox();
            txtItemPrice = new TextBox();
            txtItemDescription = new TextBox();
            txtItemCode = new TextBox();
            txtItemId = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            lblItemDescription = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnClearNewItemFields = new Button();
            cmbNewItemType = new ComboBox();
            txtNewItemCost = new TextBox();
            txtNewItemPrice = new TextBox();
            txtNewItemDescription = new TextBox();
            txtNewItemCode = new TextBox();
            btnAddNewItem = new Button();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            groupBox3 = new GroupBox();
            lblStatus = new Label();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label7 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            groupBox1.SuspendLayout();
            gbxItemDetails.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dgvItems
            // 
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Location = new Point(16, 22);
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.RowTemplate.Height = 25;
            dgvItems.Size = new Size(617, 340);
            dgvItems.TabIndex = 0;
            dgvItems.CellContentClick += dgvItems_CellContentClick;
            dgvItems.CellDoubleClick += dgvItems_CellDoubleClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(gbxItemDetails);
            groupBox1.Controls.Add(dgvItems);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1059, 382);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Inventory";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // gbxItemDetails
            // 
            gbxItemDetails.Controls.Add(btnDeleteItem);
            gbxItemDetails.Controls.Add(cmbItemType);
            gbxItemDetails.Controls.Add(txtItemCost);
            gbxItemDetails.Controls.Add(txtItemPrice);
            gbxItemDetails.Controls.Add(txtItemDescription);
            gbxItemDetails.Controls.Add(txtItemCode);
            gbxItemDetails.Controls.Add(txtItemId);
            gbxItemDetails.Controls.Add(label6);
            gbxItemDetails.Controls.Add(label5);
            gbxItemDetails.Controls.Add(label4);
            gbxItemDetails.Controls.Add(lblItemDescription);
            gbxItemDetails.Controls.Add(label2);
            gbxItemDetails.Controls.Add(label1);
            gbxItemDetails.Location = new Point(657, 15);
            gbxItemDetails.Name = "gbxItemDetails";
            gbxItemDetails.Size = new Size(396, 347);
            gbxItemDetails.TabIndex = 1;
            gbxItemDetails.TabStop = false;
            gbxItemDetails.Text = "Item Details";
            // 
            // btnDeleteItem
            // 
            btnDeleteItem.Location = new Point(266, 303);
            btnDeleteItem.Name = "btnDeleteItem";
            btnDeleteItem.Size = new Size(111, 28);
            btnDeleteItem.TabIndex = 13;
            btnDeleteItem.Text = "Delete Item";
            btnDeleteItem.UseVisualStyleBackColor = true;
            btnDeleteItem.Click += btnDeleteItem_Click;
            // 
            // cmbItemType
            // 
            cmbItemType.FormattingEnabled = true;
            cmbItemType.Location = new Point(95, 160);
            cmbItemType.Name = "cmbItemType";
            cmbItemType.Size = new Size(284, 23);
            cmbItemType.TabIndex = 12;
            // 
            // txtItemCost
            // 
            txtItemCost.Location = new Point(92, 245);
            txtItemCost.Name = "txtItemCost";
            txtItemCost.Size = new Size(287, 23);
            txtItemCost.TabIndex = 11;
            // 
            // txtItemPrice
            // 
            txtItemPrice.Location = new Point(92, 198);
            txtItemPrice.Name = "txtItemPrice";
            txtItemPrice.Size = new Size(285, 23);
            txtItemPrice.TabIndex = 10;
            // 
            // txtItemDescription
            // 
            txtItemDescription.Location = new Point(94, 111);
            txtItemDescription.Name = "txtItemDescription";
            txtItemDescription.Size = new Size(285, 23);
            txtItemDescription.TabIndex = 8;
            // 
            // txtItemCode
            // 
            txtItemCode.Location = new Point(91, 71);
            txtItemCode.Name = "txtItemCode";
            txtItemCode.ReadOnly = true;
            txtItemCode.Size = new Size(288, 23);
            txtItemCode.TabIndex = 7;
            // 
            // txtItemId
            // 
            txtItemId.Location = new Point(91, 29);
            txtItemId.Name = "txtItemId";
            txtItemId.ReadOnly = true;
            txtItemId.Size = new Size(288, 23);
            txtItemId.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 251);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 5;
            label6.Text = "Item Cost :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 206);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 4;
            label5.Text = "Item Price :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 162);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 3;
            label4.Text = "ItemType :";
            // 
            // lblItemDescription
            // 
            lblItemDescription.AutoSize = true;
            lblItemDescription.Location = new Point(14, 111);
            lblItemDescription.Name = "lblItemDescription";
            lblItemDescription.Size = new Size(73, 15);
            lblItemDescription.TabIndex = 2;
            lblItemDescription.Text = "Description :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 74);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 1;
            label2.Text = "Item Code : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 29);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Item ID : ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnClearNewItemFields);
            groupBox2.Controls.Add(cmbNewItemType);
            groupBox2.Controls.Add(txtNewItemCost);
            groupBox2.Controls.Add(txtNewItemPrice);
            groupBox2.Controls.Add(txtNewItemDescription);
            groupBox2.Controls.Add(txtNewItemCode);
            groupBox2.Controls.Add(btnAddNewItem);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(9, 407);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(641, 137);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add New Item";
            // 
            // btnClearNewItemFields
            // 
            btnClearNewItemFields.Location = new Point(513, 97);
            btnClearNewItemFields.Name = "btnClearNewItemFields";
            btnClearNewItemFields.Size = new Size(109, 28);
            btnClearNewItemFields.TabIndex = 11;
            btnClearNewItemFields.Text = "Clear All Fields";
            btnClearNewItemFields.UseVisualStyleBackColor = true;
            btnClearNewItemFields.Click += btnClearNewItemFields_Click;
            // 
            // cmbNewItemType
            // 
            cmbNewItemType.FormattingEnabled = true;
            cmbNewItemType.Items.AddRange(new object[] { "Fuel", "Product", "Service" });
            cmbNewItemType.Location = new Point(94, 67);
            cmbNewItemType.Name = "cmbNewItemType";
            cmbNewItemType.Size = new Size(169, 23);
            cmbNewItemType.TabIndex = 10;
            // 
            // txtNewItemCost
            // 
            txtNewItemCost.Location = new Point(344, 70);
            txtNewItemCost.Name = "txtNewItemCost";
            txtNewItemCost.Size = new Size(149, 23);
            txtNewItemCost.TabIndex = 9;
            // 
            // txtNewItemPrice
            // 
            txtNewItemPrice.Location = new Point(344, 28);
            txtNewItemPrice.Name = "txtNewItemPrice";
            txtNewItemPrice.Size = new Size(147, 23);
            txtNewItemPrice.TabIndex = 8;
            // 
            // txtNewItemDescription
            // 
            txtNewItemDescription.Location = new Point(111, 99);
            txtNewItemDescription.Name = "txtNewItemDescription";
            txtNewItemDescription.Size = new Size(380, 23);
            txtNewItemDescription.TabIndex = 7;
            // 
            // txtNewItemCode
            // 
            txtNewItemCode.Location = new Point(91, 29);
            txtNewItemCode.Name = "txtNewItemCode";
            txtNewItemCode.ReadOnly = true;
            txtNewItemCode.Size = new Size(172, 23);
            txtNewItemCode.TabIndex = 6;
            txtNewItemCode.Text = "Will Be Added by The System";
            // 
            // btnAddNewItem
            // 
            btnAddNewItem.Location = new Point(508, 29);
            btnAddNewItem.Name = "btnAddNewItem";
            btnAddNewItem.Size = new Size(118, 31);
            btnAddNewItem.TabIndex = 5;
            btnAddNewItem.Text = "Add New Item";
            btnAddNewItem.UseVisualStyleBackColor = true;
            btnAddNewItem.Click += btnAddNewItem_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(271, 67);
            label12.Name = "label12";
            label12.Size = new Size(67, 15);
            label12.TabIndex = 4;
            label12.Text = "Item Cost : ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(269, 31);
            label11.Name = "label11";
            label11.Size = new Size(69, 15);
            label11.TabIndex = 3;
            label11.Text = "Item Price : ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(10, 67);
            label10.Name = "label10";
            label10.Size = new Size(67, 15);
            label10.TabIndex = 2;
            label10.Text = "Item Type : ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 107);
            label9.Name = "label9";
            label9.Size = new Size(94, 15);
            label9.TabIndex = 1;
            label9.Text = "Item Description";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 30);
            label8.Name = "label8";
            label8.Size = new Size(71, 15);
            label8.TabIndex = 0;
            label8.Text = "Item Code : ";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblStatus);
            groupBox3.Controls.Add(btnLogin);
            groupBox3.Controls.Add(txtPassword);
            groupBox3.Controls.Add(txtUsername);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(669, 407);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(402, 137);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Security Panel";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatus.Location = new Point(19, 99);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(119, 25);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "NO ACCESS ";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(247, 30);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(141, 57);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Get Access";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(90, 63);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(134, 23);
            txtPassword.TabIndex = 3;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(89, 30);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(135, 23);
            txtUsername.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 63);
            label7.Name = "label7";
            label7.Size = new Size(66, 15);
            label7.TabIndex = 1;
            label7.Text = "Password : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 31);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 0;
            label3.Text = "Username : ";
            // 
            // frmItems
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 561);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmItems";
            Text = "Inventory";
            Load += frmItems_Load;
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            groupBox1.ResumeLayout(false);
            gbxItemDetails.ResumeLayout(false);
            gbxItemDetails.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvItems;
        private GroupBox groupBox1;
        private GroupBox gbxItemDetails;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label lblItemDescription;
        private Label label2;
        private Label label1;
        private TextBox txtItemDescription;
        private TextBox txtItemCode;
        private TextBox txtItemId;
        private ComboBox cmbItemType;
        private TextBox txtItemCost;
        private TextBox txtItemPrice;
        private Button btnDeleteItem;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label7;
        private Label label3;
        private Button btnLogin;
        private Label lblStatus;
        private Button btnClearNewItemFields;
        private ComboBox cmbNewItemType;
        private TextBox txtNewItemCost;
        private TextBox txtNewItemPrice;
        private TextBox txtNewItemDescription;
        private TextBox txtNewItemCode;
        private Button btnAddNewItem;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
    }
}