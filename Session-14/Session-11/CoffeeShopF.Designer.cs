namespace Session_11
{
    partial class CoffeeShopF
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
            btnEmployeeRedirect = new Button();
            btnLoadLedger = new Button();
            btnTransactions = new Button();
            btnProduct = new Button();
            btnProductCategoryManagement = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnEmployeeRedirect
            // 
            btnEmployeeRedirect.BackColor = Color.Moccasin;
            btnEmployeeRedirect.Dock = DockStyle.Bottom;
            btnEmployeeRedirect.Location = new Point(0, 460);
            btnEmployeeRedirect.Name = "btnEmployeeRedirect";
            btnEmployeeRedirect.Size = new Size(836, 86);
            btnEmployeeRedirect.TabIndex = 0;
            btnEmployeeRedirect.Text = "Employee Management";
            btnEmployeeRedirect.UseVisualStyleBackColor = false;
            btnEmployeeRedirect.Click += btnEmployeeRedirect_Click;
            // 
            // btnLoadLedger
            // 
            btnLoadLedger.BackColor = Color.SandyBrown;
            btnLoadLedger.Dock = DockStyle.Right;
            btnLoadLedger.Location = new Point(760, 0);
            btnLoadLedger.Name = "btnLoadLedger";
            btnLoadLedger.Size = new Size(76, 460);
            btnLoadLedger.TabIndex = 1;
            btnLoadLedger.Text = "Ledger";
            btnLoadLedger.UseVisualStyleBackColor = false;
            btnLoadLedger.Click += btnLoadLedger_Click;
            // 
            // btnTransactions
            // 
            btnTransactions.BackColor = Color.SandyBrown;
            btnTransactions.Dock = DockStyle.Top;
            btnTransactions.Location = new Point(0, 0);
            btnTransactions.Name = "btnTransactions";
            btnTransactions.Size = new Size(760, 140);
            btnTransactions.TabIndex = 2;
            btnTransactions.Text = "Transactions";
            btnTransactions.UseVisualStyleBackColor = false;
            btnTransactions.Click += btnTransactions_Click;
            // 
            // btnProduct
            // 
            btnProduct.BackColor = Color.Moccasin;
            btnProduct.Dock = DockStyle.Bottom;
            btnProduct.Location = new Point(0, 374);
            btnProduct.Margin = new Padding(3, 2, 3, 2);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(760, 86);
            btnProduct.TabIndex = 3;
            btnProduct.Text = "Inventory Managment";
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnProductCategoryManagement
            // 
            btnProductCategoryManagement.BackColor = Color.Moccasin;
            btnProductCategoryManagement.Dock = DockStyle.Bottom;
            btnProductCategoryManagement.Location = new Point(0, 292);
            btnProductCategoryManagement.Margin = new Padding(3, 2, 3, 2);
            btnProductCategoryManagement.Name = "btnProductCategoryManagement";
            btnProductCategoryManagement.Size = new Size(760, 82);
            btnProductCategoryManagement.TabIndex = 4;
            btnProductCategoryManagement.Text = "Product Category Management";
            btnProductCategoryManagement.UseVisualStyleBackColor = false;
            btnProductCategoryManagement.Click += btnProductCategoryManagement_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 201);
            label1.Name = "label1";
            label1.Size = new Size(653, 30);
            label1.TabIndex = 5;
            label1.Text = "CoffeeShop Management Suite 1.1 (Epsilon Coding School 2023)";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CoffeeShopF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 546);
            Controls.Add(label1);
            Controls.Add(btnProductCategoryManagement);
            Controls.Add(btnProduct);
            Controls.Add(btnTransactions);
            Controls.Add(btnLoadLedger);
            Controls.Add(btnEmployeeRedirect);
            MaximizeBox = false;
            Name = "CoffeeShopF";
            Text = "CoffeeShop 1.1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEmployeeRedirect;
        private Button btnLoadLedger;
        private Button btnTransactions;
        private Button btnProduct;
        private Button btnProductCategoryManagement;
        private Label label1;
    }
}