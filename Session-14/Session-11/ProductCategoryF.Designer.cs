namespace Session_11 {
    partial class ProductCategoryF {
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
            this.gcProductCategory = new DevExpress.XtraGrid.GridControl();
            this.grvProductCategory = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnReloadCategories = new System.Windows.Forms.Button();
            this.btnReloadFromJson = new System.Windows.Forms.Button();
            this.btnExportToJson = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNewProductCategory = new System.Windows.Forms.TextBox();
            this.tboxAddCategory = new System.Windows.Forms.TextBox();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.tboxDescription = new System.Windows.Forms.TextBox();
            this.txtAddDescription = new System.Windows.Forms.TextBox();
            this.txtAddProductType = new System.Windows.Forms.TextBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.txtProductCategories = new System.Windows.Forms.TextBox();
            this.comboProductType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gcProductCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvProductCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // gcProductCategory
            // 
            this.gcProductCategory.Location = new System.Drawing.Point(60, 37);
            this.gcProductCategory.MainView = this.grvProductCategory;
            this.gcProductCategory.Name = "gcProductCategory";
            this.gcProductCategory.Size = new System.Drawing.Size(687, 224);
            this.gcProductCategory.TabIndex = 0;
            this.gcProductCategory.UseEmbeddedNavigator = true;
            this.gcProductCategory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvProductCategory});
            // 
            // grvProductCategory
            // 
            this.grvProductCategory.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode,
            this.colDescription,
            this.colProductType});
            this.grvProductCategory.GridControl = this.gcProductCategory;
            this.grvProductCategory.Name = "grvProductCategory";
            // 
            // colCode
            // 
            this.colCode.Caption = "Code";
            this.colCode.FieldName = "Code";
            this.colCode.MinWidth = 22;
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.FieldName = "Description";
            this.colDescription.MinWidth = 22;
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            // 
            // colProductType
            // 
            this.colProductType.Caption = "Product Type";
            this.colProductType.FieldName = "ProductType";
            this.colProductType.MinWidth = 22;
            this.colProductType.Name = "colProductType";
            this.colProductType.Visible = true;
            this.colProductType.VisibleIndex = 2;
            // 
            // btnReloadCategories
            // 
            this.btnReloadCategories.Location = new System.Drawing.Point(60, 281);
            this.btnReloadCategories.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReloadCategories.Name = "btnReloadCategories";
            this.btnReloadCategories.Size = new System.Drawing.Size(148, 33);
            this.btnReloadCategories.TabIndex = 1;
            this.btnReloadCategories.Text = "Reload Categories";
            this.btnReloadCategories.UseVisualStyleBackColor = true;
            this.btnReloadCategories.Click += new System.EventHandler(this.btnReloadCategories_Click);
            // 
            // btnReloadFromJson
            // 
            this.btnReloadFromJson.Location = new System.Drawing.Point(269, 281);
            this.btnReloadFromJson.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReloadFromJson.Name = "btnReloadFromJson";
            this.btnReloadFromJson.Size = new System.Drawing.Size(118, 33);
            this.btnReloadFromJson.TabIndex = 2;
            this.btnReloadFromJson.Text = "Reload from JSon";
            this.btnReloadFromJson.UseVisualStyleBackColor = true;
            this.btnReloadFromJson.Click += new System.EventHandler(this.btnReloadFromJson_Click);
            // 
            // btnExportToJson
            // 
            this.btnExportToJson.Location = new System.Drawing.Point(439, 281);
            this.btnExportToJson.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExportToJson.Name = "btnExportToJson";
            this.btnExportToJson.Size = new System.Drawing.Size(136, 33);
            this.btnExportToJson.TabIndex = 3;
            this.btnExportToJson.Text = "Export To JSon";
            this.btnExportToJson.UseVisualStyleBackColor = true;
            this.btnExportToJson.Click += new System.EventHandler(this.btnExportToJson_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(615, 281);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Force Default Load ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNewProductCategory
            // 
            this.txtNewProductCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNewProductCategory.Location = new System.Drawing.Point(310, 330);
            this.txtNewProductCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNewProductCategory.Name = "txtNewProductCategory";
            this.txtNewProductCategory.Size = new System.Drawing.Size(202, 29);
            this.txtNewProductCategory.TabIndex = 5;
            this.txtNewProductCategory.Text = "New Product Category";
            // 
            // tboxAddCategory
            // 
            this.tboxAddCategory.Location = new System.Drawing.Point(60, 394);
            this.tboxAddCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboxAddCategory.Name = "tboxAddCategory";
            this.tboxAddCategory.Size = new System.Drawing.Size(148, 23);
            this.tboxAddCategory.TabIndex = 6;
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(102, 370);
            this.txtAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(68, 23);
            this.txtAdd.TabIndex = 7;
            this.txtAdd.Text = "Add Code";
            // 
            // tboxDescription
            // 
            this.tboxDescription.Location = new System.Drawing.Point(250, 394);
            this.tboxDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboxDescription.Name = "tboxDescription";
            this.tboxDescription.Size = new System.Drawing.Size(148, 23);
            this.tboxDescription.TabIndex = 8;
            // 
            // txtAddDescription
            // 
            this.txtAddDescription.Location = new System.Drawing.Point(277, 370);
            this.txtAddDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddDescription.Name = "txtAddDescription";
            this.txtAddDescription.Size = new System.Drawing.Size(110, 23);
            this.txtAddDescription.TabIndex = 10;
            this.txtAddDescription.Text = "Add Description";
            // 
            // txtAddProductType
            // 
            this.txtAddProductType.Location = new System.Drawing.Point(439, 370);
            this.txtAddProductType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddProductType.Name = "txtAddProductType";
            this.txtAddProductType.Size = new System.Drawing.Size(120, 23);
            this.txtAddProductType.TabIndex = 11;
            this.txtAddProductType.Text = "Add Product Type";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(626, 370);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(121, 44);
            this.btnAddCategory.TabIndex = 12;
            this.btnAddCategory.Text = "Add Category";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click_1);
            // 
            // txtProductCategories
            // 
            this.txtProductCategories.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtProductCategories.Location = new System.Drawing.Point(326, 9);
            this.txtProductCategories.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductCategories.Name = "txtProductCategories";
            this.txtProductCategories.Size = new System.Drawing.Size(167, 29);
            this.txtProductCategories.TabIndex = 13;
            this.txtProductCategories.Text = "Product Categories";
            // 
            // comboProductType
            // 
            this.comboProductType.FormattingEnabled = true;
            this.comboProductType.Items.AddRange(new object[] {
            "Coffee",
            "Beverages",
            "Food"});
            this.comboProductType.Location = new System.Drawing.Point(418, 394);
            this.comboProductType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboProductType.Name = "comboProductType";
            this.comboProductType.Size = new System.Drawing.Size(157, 23);
            this.comboProductType.TabIndex = 14;
            // 
            // ProductCategoryF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboProductType);
            this.Controls.Add(this.txtProductCategories);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.txtAddProductType);
            this.Controls.Add(this.txtAddDescription);
            this.Controls.Add(this.tboxDescription);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.tboxAddCategory);
            this.Controls.Add(this.txtNewProductCategory);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExportToJson);
            this.Controls.Add(this.btnReloadFromJson);
            this.Controls.Add(this.btnReloadCategories);
            this.Controls.Add(this.gcProductCategory);
            this.Name = "ProductCategoryF";
            this.Text = "ProductCategoryF";
            this.Load += new System.EventHandler(this.ProductCategoryF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcProductCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvProductCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcProductCategory;
        private DevExpress.XtraGrid.Views.Grid.GridView grvProductCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colProductType;
        private Button btnReloadCategories;
        private Button btnReloadFromJson;
        private Button btnExportToJson;
        private Button button1;
        private TextBox txtNewProductCategory;
        private TextBox tboxAddCategory;
        private TextBox txtAdd;
        private TextBox tboxDescription;
        private TextBox txtAddDescription;
        private TextBox txtAddProductType;
        private Button btnAddCategory;
        private TextBox txtProductCategories;
        private ComboBox comboProductType;
    }
}