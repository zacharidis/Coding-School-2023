using DevExpress.XtraBars.Docking.Helpers;
using DevExpress.XtraScheduler.Commands;
using Libs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_11
{
    public partial class CoffeeShopF : Form
    {
        TransactionHandler Transaction;
        CoffeeShopHandler CoffeeShop;
        MonthlyLedger LedgerOfTheMonth;
        CoffeeShopWrapper CoffeeShopWrapper;
        bool tmp = false;

        public CoffeeShopF()
        {

            CoffeeShop = new CoffeeShopHandler();
            Transaction = new TransactionHandler();

            InitializeComponent();
            CoffeeShop.Init();
            LedgerOfTheMonth = new MonthlyLedger(CoffeeShop.Employees);
            CoffeeShopWrapper = new CoffeeShopWrapper(CoffeeShop, Transaction, LedgerOfTheMonth);
        }

        private void ExportAll()
        {
            Serializer serializer = new Serializer();
            serializer.SerializeToFile(CoffeeShopWrapper, "GenericSaving.json");
        }

        private void btnEmployeeRedirect_Click(object sender, EventArgs e)
        {
            EmployeeF formEmp = new EmployeeF(CoffeeShop);
            formEmp.ShowDialog();
        }

        private void btnLoadLedger_Click(object sender, EventArgs e)
        {
            LedgerForm ledgerForm = new LedgerForm(LedgerOfTheMonth);
            ledgerForm.ShowDialog();
        }

        private void btnTransactions_Click(object sender, EventArgs e) {
           TransactionF f1 = new TransactionF(CoffeeShop,Transaction);
           f1.ShowDialog();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ProductF f2 = new ProductF(CoffeeShop);
            f2.ShowDialog();
        }

        private void btnProductCategoryManagement_Click(object sender, EventArgs e)
        {
            ProductCategoryF productCategoryF = new ProductCategoryF(CoffeeShop);
            productCategoryF.ShowDialog();
        }

        private void btnSaveAll_Click(object sender, EventArgs e) {
            string json = JsonConvert.SerializeObject(CoffeeShopWrapper, Formatting.Indented);
            File.WriteAllText("GenericSaving.json", json);
            MessageBox.Show("Exported Exerything!");
        }
    }
}