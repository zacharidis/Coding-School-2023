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
            this.btnEmployeeRedirect = new System.Windows.Forms.Button();
            this.btnLoadLedger = new System.Windows.Forms.Button();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnProductCategoryManagement = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmployeeRedirect
            // 
            this.btnEmployeeRedirect.BackColor = System.Drawing.Color.Moccasin;
            this.btnEmployeeRedirect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnEmployeeRedirect.Location = new System.Drawing.Point(0, 460);
            this.btnEmployeeRedirect.Name = "btnEmployeeRedirect";
            this.btnEmployeeRedirect.Size = new System.Drawing.Size(755, 86);
            this.btnEmployeeRedirect.TabIndex = 0;
            this.btnEmployeeRedirect.Text = "Employee Management";
            this.btnEmployeeRedirect.UseVisualStyleBackColor = false;
            this.btnEmployeeRedirect.Click += new System.EventHandler(this.btnEmployeeRedirect_Click);
            // 
            // btnLoadLedger
            // 
            this.btnLoadLedger.BackColor = System.Drawing.Color.SandyBrown;
            this.btnLoadLedger.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLoadLedger.Location = new System.Drawing.Point(664, 0);
            this.btnLoadLedger.Name = "btnLoadLedger";
            this.btnLoadLedger.Size = new System.Drawing.Size(91, 460);
            this.btnLoadLedger.TabIndex = 1;
            this.btnLoadLedger.Text = "Ledger";
            this.btnLoadLedger.UseVisualStyleBackColor = false;
            this.btnLoadLedger.Click += new System.EventHandler(this.btnLoadLedger_Click);
            // 
            // btnTransactions
            // 
            this.btnTransactions.BackColor = System.Drawing.Color.SandyBrown;
            this.btnTransactions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransactions.Location = new System.Drawing.Point(0, 0);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(664, 104);
            this.btnTransactions.TabIndex = 2;
            this.btnTransactions.Text = "Transactions";
            this.btnTransactions.UseVisualStyleBackColor = false;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.Moccasin;
            this.btnProduct.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnProduct.Location = new System.Drawing.Point(0, 374);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(664, 86);
            this.btnProduct.TabIndex = 3;
            this.btnProduct.Text = "Inventory Managment";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnProductCategoryManagement
            // 
            this.btnProductCategoryManagement.BackColor = System.Drawing.Color.Moccasin;
            this.btnProductCategoryManagement.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnProductCategoryManagement.Location = new System.Drawing.Point(0, 292);
            this.btnProductCategoryManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProductCategoryManagement.Name = "btnProductCategoryManagement";
            this.btnProductCategoryManagement.Size = new System.Drawing.Size(664, 82);
            this.btnProductCategoryManagement.TabIndex = 4;
            this.btnProductCategoryManagement.Text = "Product Category Management";
            this.btnProductCategoryManagement.UseVisualStyleBackColor = false;
            this.btnProductCategoryManagement.Click += new System.EventHandler(this.btnProductCategoryManagement_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(252, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fiesta Cafe";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSaveAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSaveAll.Location = new System.Drawing.Point(0, 104);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(108, 188);
            this.btnSaveAll.TabIndex = 6;
            this.btnSaveAll.Text = "Export";
            this.btnSaveAll.UseVisualStyleBackColor = false;
            this.btnSaveAll.Click += new System.EventHandler(this.btnSaveAll_Click);
            // 
            // CoffeeShopF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 546);
            this.Controls.Add(this.btnSaveAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProductCategoryManagement);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.btnTransactions);
            this.Controls.Add(this.btnLoadLedger);
            this.Controls.Add(this.btnEmployeeRedirect);
            this.MaximizeBox = false;
            this.Name = "CoffeeShopF";
            this.Text = "CoffeeShop 1.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEmployeeRedirect;
        private Button btnLoadLedger;
        private Button btnTransactions;
        private Button btnProduct;
        private Button btnProductCategoryManagement;
        private Label label1;
        private Button btnSaveAll;
    }
}