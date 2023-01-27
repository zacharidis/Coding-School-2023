namespace Session_11 {
    partial class TransactionF {
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
            this.btnOrder = new System.Windows.Forms.Button();
            this.bsEmployees = new System.Windows.Forms.BindingSource(this.components);
            this.bsTransactions = new System.Windows.Forms.BindingSource(this.components);
            this.gridTransactions = new DevExpress.XtraGrid.GridControl();
            this.grvTransactions = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmployeeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentMethod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridEmployees = new DevExpress.XtraGrid.GridControl();
            this.grvEmployees = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(676, 458);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(97, 47);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "Add New Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // gridTransactions
            // 
            this.gridTransactions.Location = new System.Drawing.Point(2, 12);
            this.gridTransactions.MainView = this.grvTransactions;
            this.gridTransactions.Name = "gridTransactions";
            this.gridTransactions.Size = new System.Drawing.Size(840, 214);
            this.gridTransactions.TabIndex = 3;
            this.gridTransactions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvTransactions});
            // 
            // grvTransactions
            // 
            this.grvTransactions.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmployeeName,
            this.colDate,
            this.colPaymentMethod,
            this.colTotalPrice});
            this.grvTransactions.GridControl = this.gridTransactions;
            this.grvTransactions.Name = "grvTransactions";
            this.grvTransactions.OptionsBehavior.Editable = false;
            this.grvTransactions.OptionsView.ShowGroupPanel = false;
            // 
            // colEmployeeName
            // 
            this.colEmployeeName.Caption = "Employee Name";
            this.colEmployeeName.FieldName = "EmployeeName";
            this.colEmployeeName.Name = "colEmployeeName";
            this.colEmployeeName.Visible = true;
            this.colEmployeeName.VisibleIndex = 3;
            // 
            // colDate
            // 
            this.colDate.Caption = "Date";
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 0;
            this.colDate.Width = 66;
            // 
            // colPaymentMethod
            // 
            this.colPaymentMethod.Caption = "Payment Method";
            this.colPaymentMethod.FieldName = "PaymentMethod";
            this.colPaymentMethod.Name = "colPaymentMethod";
            this.colPaymentMethod.Visible = true;
            this.colPaymentMethod.VisibleIndex = 1;
            this.colPaymentMethod.Width = 66;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.Caption = "Total Price";
            this.colTotalPrice.FieldName = "TotalPrice";
            this.colTotalPrice.Name = "colTotalPrice";
            this.colTotalPrice.Visible = true;
            this.colTotalPrice.VisibleIndex = 2;
            this.colTotalPrice.Width = 66;
            // 
            // gridEmployees
            // 
            this.gridEmployees.Location = new System.Drawing.Point(2, 246);
            this.gridEmployees.MainView = this.grvEmployees;
            this.gridEmployees.Name = "gridEmployees";
            this.gridEmployees.Size = new System.Drawing.Size(840, 182);
            this.gridEmployees.TabIndex = 6;
            this.gridEmployees.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvEmployees});
            // 
            // grvEmployees
            // 
            this.grvEmployees.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colSurname,
            this.colType});
            this.grvEmployees.GridControl = this.gridEmployees;
            this.grvEmployees.Name = "grvEmployees";
            this.grvEmployees.OptionsBehavior.Editable = false;
            this.grvEmployees.OptionsView.ShowGroupPanel = false;
            // 
            // colName
            // 
            this.colName.Caption = "Name";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colSurname
            // 
            this.colSurname.Caption = "Surname";
            this.colSurname.FieldName = "Surname";
            this.colSurname.Name = "colSurname";
            this.colSurname.Visible = true;
            this.colSurname.VisibleIndex = 1;
            // 
            // colType
            // 
            this.colType.Caption = "Type";
            this.colType.FieldName = "EmployeeType";
            this.colType.Name = "colType";
            this.colType.Visible = true;
            this.colType.VisibleIndex = 2;
            // 
            // TransactionF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 507);
            this.Controls.Add(this.gridEmployees);
            this.Controls.Add(this.gridTransactions);
            this.Controls.Add(this.btnOrder);
            this.Name = "TransactionF";
            this.Text = "TransactionF";
            this.Load += new System.EventHandler(this.TransactionF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnOrder;
        private BindingSource bsEmployees;
        private BindingSource bsTransactions;
        private DevExpress.XtraGrid.GridControl gridTransactions;
        private DevExpress.XtraGrid.Views.Grid.GridView grvTransactions;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeName;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentMethod;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPrice;
        private DevExpress.XtraGrid.GridControl gridEmployees;
        private DevExpress.XtraGrid.Views.Grid.GridView grvEmployees;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colSurname;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
    }
}