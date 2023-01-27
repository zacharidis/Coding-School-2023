using Libs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_11
{
    public partial class EmployeeF : Form
    {
        CoffeeShopHandler ShopData { get; set; } = new();
        public EmployeeF(CoffeeShopHandler transfer)
        {

            ShopData = transfer;

            InitializeComponent();
            gcEmployee.DataSource = ShopData.Employees;
        }

        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            gcEmployee.DataSource = null;
            gcEmployee.DataSource = ShopData.Employees;
        }
        private void ResetGVs() {
            gcEmployee.DataSource = null;
            gcEmployee.DataSource = ShopData.Employees;
        }

        private void btnLoadJson_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Loading Employee File from Json\nIn case of fail it will roll Back To Default Values");
            ShopData.CheckAndPopulateEmployees();
        }

        private void btnSaveEmp_Click(object sender, EventArgs e)
        {
            ShopData.SerializeEmployee();
            MessageBox.Show("Exported Successfully!");

        }

        private void EmployeeF_Load(object sender, EventArgs e)
        {
            ResetGVs();

        }

        private void btnLoadDefault_Click(object sender, EventArgs e) {
            ShopData.Employees.Clear();
            ShopData.SetDefaultEmployees();
            ResetGVs();
        }

        private void btnAdd_Click_1(object sender, EventArgs e) {
            Employee tmpEmp = new Employee() {
                Name = tboxName.Text,
                Surname = tboxSurname.Text,
                EmployeeType = (EmployeeType)Enum.Parse(typeof(EmployeeType), comboRole.SelectedItem.ToString()),
                Salary = Convert.ToDecimal(tboxSalary.Text)
            };
            ShopData.Employees.Add(tmpEmp);
            if (ShopData.CheckLimitsForm()) {


                MessageBox.Show("New Employee Successfully added to Roster!\nPress Reload To See.");
            }
            else {
                ShopData.Employees.Remove(tmpEmp);
                MessageBox.Show("Error on the Roster Limits\nPress Reload To See.");
            }
            ResetGVs();
        }

        

        

        private void btnForceLoad_Click(object sender, EventArgs e) {
            ShopData.Employees.Clear();
            ShopData.SetDefaultEmployees();
            MessageBox.Show("Wiped all Entries\nForced Default Values.");
            ResetGVs();

        }

        private void btnRefreshList_Click_1(object sender, EventArgs e)
        {

        }

        private void EmployeeF_Load_1(object sender, EventArgs e)
        {

        }

        private void gcEmployee_Click(object sender, EventArgs e)
        {

        }
    }
}
