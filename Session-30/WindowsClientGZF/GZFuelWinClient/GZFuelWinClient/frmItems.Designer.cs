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
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            groupBox1.SuspendLayout();
            gbxItemDetails.SuspendLayout();
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
            // 
            // gbxItemDetails
            // 
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
            // frmItems
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 587);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmItems";
            Text = "frmItems";
            Load += frmItems_Load;
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            groupBox1.ResumeLayout(false);
            gbxItemDetails.ResumeLayout(false);
            gbxItemDetails.PerformLayout();
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
    }
}