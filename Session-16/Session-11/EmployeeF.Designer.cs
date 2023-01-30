namespace Session_11
{
    partial class EmployeeF
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
            this.gcEmployee = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcEmployeeType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcSalary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnRefreshList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxName = new System.Windows.Forms.TextBox();
            this.tboxSurname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboRole = new System.Windows.Forms.ComboBox();
            this.Role = new System.Windows.Forms.Label();
            this.tboxSalary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnLoadJson = new System.Windows.Forms.Button();
            this.btnSaveEmp = new System.Windows.Forms.Button();
            this.btnForceLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gcEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcEmployee
            // 
            this.gcEmployee.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcEmployee.Location = new System.Drawing.Point(111, 97);
            this.gcEmployee.MainView = this.gridView1;
            this.gcEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcEmployee.Name = "gcEmployee";
            this.gcEmployee.Size = new System.Drawing.Size(593, 288);
            this.gcEmployee.TabIndex = 0;
            this.gcEmployee.UseEmbeddedNavigator = true;
            this.gcEmployee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcEmployee.Click += new System.EventHandler(this.gcEmployee_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcName,
            this.gcSurname,
            this.gcEmployeeType,
            this.gcSalary});
            this.gridView1.DetailHeight = 467;
            this.gridView1.GridControl = this.gcEmployee;
            this.gridView1.Name = "gridView1";
            // 
            // gcName
            // 
            this.gcName.Caption = "Name";
            this.gcName.FieldName = "Name";
            this.gcName.MinWidth = 23;
            this.gcName.Name = "gcName";
            this.gcName.Visible = true;
            this.gcName.VisibleIndex = 0;
            this.gcName.Width = 86;
            // 
            // gcSurname
            // 
            this.gcSurname.Caption = "Surname";
            this.gcSurname.FieldName = "Surname";
            this.gcSurname.MinWidth = 23;
            this.gcSurname.Name = "gcSurname";
            this.gcSurname.Visible = true;
            this.gcSurname.VisibleIndex = 1;
            this.gcSurname.Width = 86;
            // 
            // gcEmployeeType
            // 
            this.gcEmployeeType.Caption = "Role";
            this.gcEmployeeType.FieldName = "EmployeeType";
            this.gcEmployeeType.MinWidth = 23;
            this.gcEmployeeType.Name = "gcEmployeeType";
            this.gcEmployeeType.Visible = true;
            this.gcEmployeeType.VisibleIndex = 2;
            this.gcEmployeeType.Width = 86;
            // 
            // gcSalary
            // 
            this.gcSalary.Caption = "Salary";
            this.gcSalary.FieldName = "Salary";
            this.gcSalary.MinWidth = 23;
            this.gcSalary.Name = "gcSalary";
            this.gcSalary.Visible = true;
            this.gcSalary.VisibleIndex = 3;
            this.gcSalary.Width = 86;
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.Location = new System.Drawing.Point(111, 393);
            this.btnRefreshList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefreshList.Name = "btnRefreshList";
            this.btnRefreshList.Size = new System.Drawing.Size(155, 60);
            this.btnRefreshList.TabIndex = 1;
            this.btnRefreshList.Text = "Reload";
            this.btnRefreshList.UseVisualStyleBackColor = true;
            this.btnRefreshList.Click += new System.EventHandler(this.btnRefreshList_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(261, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Employee Roster";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(272, 473);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "New Employee Registration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 537);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // tboxName
            // 
            this.tboxName.Location = new System.Drawing.Point(51, 561);
            this.tboxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxName.Name = "tboxName";
            this.tboxName.Size = new System.Drawing.Size(114, 27);
            this.tboxName.TabIndex = 5;
            // 
            // tboxSurname
            // 
            this.tboxSurname.Location = new System.Drawing.Point(191, 561);
            this.tboxSurname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxSurname.Name = "tboxSurname";
            this.tboxSurname.Size = new System.Drawing.Size(114, 27);
            this.tboxSurname.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 537);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Surname";
            // 
            // comboRole
            // 
            this.comboRole.FormattingEnabled = true;
            this.comboRole.Items.AddRange(new object[] {
            "Manager",
            "Cashier",
            "Barista",
            "Waiter"});
            this.comboRole.Location = new System.Drawing.Point(331, 561);
            this.comboRole.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboRole.Name = "comboRole";
            this.comboRole.Size = new System.Drawing.Size(138, 28);
            this.comboRole.TabIndex = 8;
            // 
            // Role
            // 
            this.Role.AutoSize = true;
            this.Role.Location = new System.Drawing.Point(369, 537);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(39, 20);
            this.Role.TabIndex = 9;
            this.Role.Text = "Role";
            // 
            // tboxSalary
            // 
            this.tboxSalary.Location = new System.Drawing.Point(505, 561);
            this.tboxSalary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxSalary.Name = "tboxSalary";
            this.tboxSalary.Size = new System.Drawing.Size(114, 27);
            this.tboxSalary.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(534, 537);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Salary";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(662, 551);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 48);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnLoadJson
            // 
            this.btnLoadJson.Location = new System.Drawing.Point(273, 393);
            this.btnLoadJson.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoadJson.Name = "btnLoadJson";
            this.btnLoadJson.Size = new System.Drawing.Size(137, 60);
            this.btnLoadJson.TabIndex = 13;
            this.btnLoadJson.Text = "Load From Json";
            this.btnLoadJson.UseVisualStyleBackColor = true;
            // 
            // btnSaveEmp
            // 
            this.btnSaveEmp.Location = new System.Drawing.Point(417, 393);
            this.btnSaveEmp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveEmp.Name = "btnSaveEmp";
            this.btnSaveEmp.Size = new System.Drawing.Size(137, 60);
            this.btnSaveEmp.TabIndex = 14;
            this.btnSaveEmp.Text = "Export To Json";
            this.btnSaveEmp.UseVisualStyleBackColor = true;
            // 
            // btnForceLoad
            // 
            this.btnForceLoad.Location = new System.Drawing.Point(561, 393);
            this.btnForceLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnForceLoad.Name = "btnForceLoad";
            this.btnForceLoad.Size = new System.Drawing.Size(143, 60);
            this.btnForceLoad.TabIndex = 15;
            this.btnForceLoad.Text = "Force Load Default";
            this.btnForceLoad.UseVisualStyleBackColor = true;
            this.btnForceLoad.Click += new System.EventHandler(this.btnForceLoad_Click);
            // 
            // EmployeeF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 648);
            this.Controls.Add(this.btnForceLoad);
            this.Controls.Add(this.btnSaveEmp);
            this.Controls.Add(this.btnLoadJson);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tboxSalary);
            this.Controls.Add(this.Role);
            this.Controls.Add(this.comboRole);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tboxSurname);
            this.Controls.Add(this.tboxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRefreshList);
            this.Controls.Add(this.gcEmployee);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EmployeeF";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.EmployeeF_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.gcEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcEmployee;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gcName;
        private DevExpress.XtraGrid.Columns.GridColumn gcSurname;
        private DevExpress.XtraGrid.Columns.GridColumn gcEmployeeType;
        private DevExpress.XtraGrid.Columns.GridColumn gcSalary;
        private Button btnRefreshList;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tboxName;
        private TextBox tboxSurname;
        private Label label4;
        private ComboBox comboRole;
        private Label Role;
        private TextBox tboxSalary;
        private Label label5;
        private Button btnAdd;
        private Button btnLoadJson;
        private Button btnSaveEmp;
        private Button btnLoadDefault;
        private Button btnForceLoad;
    }
}