namespace Session_11 {
    partial class TransactionDetailsF {
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
            this.gridProducts = new DevExpress.XtraGrid.GridControl();
            this.grvProducts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridTransactionLines = new DevExpress.XtraGrid.GridControl();
            this.grvTransactionLines = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.labelCustomer = new DevExpress.XtraEditors.LabelControl();
            this.spinEditQuantity = new DevExpress.XtraEditors.SpinEdit();
            this.lookUpPaymentMethod = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bsProducts = new System.Windows.Forms.BindingSource(this.components);
            this.bsTransactionLines = new System.Windows.Forms.BindingSource(this.components);
            this.bsTransactions = new System.Windows.Forms.BindingSource(this.components);
            this.labelTotalPrice = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransactionLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactionLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPaymentMethod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactionLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // gridProducts
            // 
            this.gridProducts.Location = new System.Drawing.Point(12, 31);
            this.gridProducts.MainView = this.grvProducts;
            this.gridProducts.Name = "gridProducts";
            this.gridProducts.Size = new System.Drawing.Size(276, 366);
            this.gridProducts.TabIndex = 1;
            this.gridProducts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvProducts});
            // 
            // grvProducts
            // 
            this.grvProducts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode,
            this.colDescription,
            this.colPrice});
            this.grvProducts.GridControl = this.gridProducts;
            this.grvProducts.Name = "grvProducts";
            this.grvProducts.OptionsBehavior.Editable = false;
            this.grvProducts.OptionsView.ShowGroupPanel = false;
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
            // gridTransactionLines
            // 
            this.gridTransactionLines.Location = new System.Drawing.Point(294, 79);
            this.gridTransactionLines.MainView = this.grvTransactionLines;
            this.gridTransactionLines.Name = "gridTransactionLines";
            this.gridTransactionLines.Size = new System.Drawing.Size(496, 320);
            this.gridTransactionLines.TabIndex = 5;
            this.gridTransactionLines.UseEmbeddedNavigator = true;
            this.gridTransactionLines.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvTransactionLines});
            // 
            // grvTransactionLines
            // 
            this.grvTransactionLines.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coDescription,
            this.colTotalPrice,
            this.colQuantity,
            this.colDiscount});
            this.grvTransactionLines.GridControl = this.gridTransactionLines;
            this.grvTransactionLines.Name = "grvTransactionLines";
            this.grvTransactionLines.OptionsBehavior.Editable = false;
            this.grvTransactionLines.OptionsView.ShowGroupPanel = false;
            // 
            // coDescription
            // 
            this.coDescription.Caption = "Description";
            this.coDescription.FieldName = "Description";
            this.coDescription.Name = "coDescription";
            this.coDescription.Visible = true;
            this.coDescription.VisibleIndex = 3;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.Caption = "Total";
            this.colTotalPrice.FieldName = "TotalPrice";
            this.colTotalPrice.Name = "colTotalPrice";
            this.colTotalPrice.Visible = true;
            this.colTotalPrice.VisibleIndex = 0;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Quantity";
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 1;
            // 
            // colDiscount
            // 
            this.colDiscount.Caption = "Discount";
            this.colDiscount.FieldName = "Discount";
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.Visible = true;
            this.colDiscount.VisibleIndex = 2;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(402, 424);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(106, 22);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(546, 424);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 22);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(672, 424);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(118, 22);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(477, 41);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 22);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // labelCustomer
            // 
            this.labelCustomer.Location = new System.Drawing.Point(21, 12);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(63, 13);
            this.labelCustomer.TabIndex = 15;
            this.labelCustomer.Text = "labelControl1";
            // 
            // spinEditQuantity
            // 
            this.spinEditQuantity.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditQuantity.Location = new System.Drawing.Point(386, 42);
            this.spinEditQuantity.Name = "spinEditQuantity";
            this.spinEditQuantity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditQuantity.Properties.IsFloatValue = false;
            this.spinEditQuantity.Properties.MaskSettings.Set("mask", "N00");
            this.spinEditQuantity.Properties.MaxValue = new decimal(new int[] {
            90000,
            0,
            0,
            0});
            this.spinEditQuantity.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditQuantity.Properties.NullText = "1";
            this.spinEditQuantity.Size = new System.Drawing.Size(62, 20);
            this.spinEditQuantity.TabIndex = 16;
            // 
            // lookUpPaymentMethod
            // 
            this.lookUpPaymentMethod.Location = new System.Drawing.Point(137, 406);
            this.lookUpPaymentMethod.Name = "lookUpPaymentMethod";
            this.lookUpPaymentMethod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpPaymentMethod.Properties.NullText = "";
            this.lookUpPaymentMethod.Size = new System.Drawing.Size(121, 20);
            this.lookUpPaymentMethod.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "PaymentMethod";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(309, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Amount:";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.Location = new System.Drawing.Point(672, 41);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(63, 13);
            this.labelTotalPrice.TabIndex = 20;
            this.labelTotalPrice.Text = "labelControl1";
            // 
            // TransactionDetailsF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 449);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lookUpPaymentMethod);
            this.Controls.Add(this.spinEditQuantity);
            this.Controls.Add(this.labelCustomer);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gridTransactionLines);
            this.Controls.Add(this.gridProducts);
            this.Name = "TransactionDetailsF";
            this.Text = "TransactionDetailsF";
            this.Load += new System.EventHandler(this.TransactionDetailsF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransactionLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactionLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPaymentMethod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactionLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridProducts;
        private DevExpress.XtraGrid.Views.Grid.GridView grvProducts;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.GridControl gridTransactionLines;
        private DevExpress.XtraGrid.Views.Grid.GridView grvTransactionLines;
        private DevExpress.XtraGrid.Columns.GridColumn coDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscount;
        private DevExpress.XtraEditors.SimpleButton btnRemove;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.LabelControl labelCustomer;
        private DevExpress.XtraEditors.SpinEdit spinEditQuantity;
        private DevExpress.XtraEditors.LookUpEdit lookUpPaymentMethod;
        private Label label1;
        private Label label2;
        private BindingSource bsProducts;
        private BindingSource bsTransactionLines;
        private BindingSource bsTransactions;
        private DevExpress.XtraEditors.LabelControl labelTotalPrice;
    }
}