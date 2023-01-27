namespace Session_11 {
    partial class ProductF {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.grdProduct = new DevExpress.XtraGrid.GridControl();
            this.grvProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSaveProduct = new System.Windows.Forms.Button();
            this.btnLoadProduct = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.bsProducts = new System.Windows.Forms.BindingSource(this.components);
            this.tBoxCode = new System.Windows.Forms.TextBox();
            this.tBoxDescription = new System.Windows.Forms.TextBox();
            this.tBoxPrice = new System.Windows.Forms.TextBox();
            this.tBoxCost = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // grdProduct
            // 
            this.grdProduct.Location = new System.Drawing.Point(12, 12);
            this.grdProduct.MainView = this.grvProduct;
            this.grdProduct.Name = "grdProduct";
            this.grdProduct.Size = new System.Drawing.Size(776, 292);
            this.grdProduct.TabIndex = 0;
            this.grdProduct.UseEmbeddedNavigator = true;
            this.grdProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvProduct});
            // 
            // grvProduct
            // 
            this.grvProduct.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode,
            this.colDescription,
            this.colPrice,
            this.colCost});
            this.grvProduct.GridControl = this.grdProduct;
            this.grvProduct.Name = "grvProduct";
            // 
            // colCode
            // 
            this.colCode.Caption = "Code";
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            // 
            // colPrice
            // 
            this.colPrice.Caption = "Price";
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 2;
            // 
            // colCost
            // 
            this.colCost.Caption = "Cost";
            this.colCost.FieldName = "Cost";
            this.colCost.Name = "colCost";
            this.colCost.Visible = true;
            this.colCost.VisibleIndex = 3;
            // 
            // btnSaveProduct
            // 
            this.btnSaveProduct.Location = new System.Drawing.Point(649, 310);
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.Size = new System.Drawing.Size(139, 47);
            this.btnSaveProduct.TabIndex = 1;
            this.btnSaveProduct.Text = "Export to JSON";
            this.btnSaveProduct.UseVisualStyleBackColor = true;
            this.btnSaveProduct.Click += new System.EventHandler(this.btnSaveProduct_Click);
            // 
            // btnLoadProduct
            // 
            this.btnLoadProduct.Location = new System.Drawing.Point(498, 310);
            this.btnLoadProduct.Name = "btnLoadProduct";
            this.btnLoadProduct.Size = new System.Drawing.Size(145, 47);
            this.btnLoadProduct.TabIndex = 2;
            this.btnLoadProduct.Text = "Load from JSON";
            this.btnLoadProduct.UseVisualStyleBackColor = true;
            this.btnLoadProduct.Click += new System.EventHandler(this.btnLoadProduct_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(475, 377);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(145, 47);
            this.btnAddNew.TabIndex = 3;
            this.btnAddNew.Text = "Add New Product";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // bsProducts
            // 
            this.bsProducts.DataSource = typeof(Libs.CoffeeShopHandler);
            // 
            // tBoxCode
            // 
            this.tBoxCode.Location = new System.Drawing.Point(12, 390);
            this.tBoxCode.Name = "tBoxCode";
            this.tBoxCode.Size = new System.Drawing.Size(100, 23);
            this.tBoxCode.TabIndex = 5;
            // 
            // tBoxDescription
            // 
            this.tBoxDescription.Location = new System.Drawing.Point(118, 390);
            this.tBoxDescription.Name = "tBoxDescription";
            this.tBoxDescription.Size = new System.Drawing.Size(100, 23);
            this.tBoxDescription.TabIndex = 6;
            // 
            // tBoxPrice
            // 
            this.tBoxPrice.Location = new System.Drawing.Point(224, 390);
            this.tBoxPrice.Name = "tBoxPrice";
            this.tBoxPrice.Size = new System.Drawing.Size(100, 23);
            this.tBoxPrice.TabIndex = 7;
            // 
            // tBoxCost
            // 
            this.tBoxCost.Location = new System.Drawing.Point(330, 390);
            this.tBoxCost.Name = "tBoxCost";
            this.tBoxCost.Size = new System.Drawing.Size(100, 23);
            this.tBoxCost.TabIndex = 8;
            // 
            // ProductF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tBoxCost);
            this.Controls.Add(this.tBoxPrice);
            this.Controls.Add(this.tBoxDescription);
            this.Controls.Add(this.tBoxCode);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnLoadProduct);
            this.Controls.Add(this.btnSaveProduct);
            this.Controls.Add(this.grdProduct);
            this.Name = "ProductF";
            this.Text = "ProductF";
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView grvProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colCost;
        private Button btnSaveProduct;
        private Button btnLoadProduct;
        private Button btnAddNew;
        private BindingSource bsProducts;
        private TextBox tBoxCode;
        private TextBox tBoxDescription;
        private TextBox tBoxPrice;
        private TextBox tBoxCost;
    }
}