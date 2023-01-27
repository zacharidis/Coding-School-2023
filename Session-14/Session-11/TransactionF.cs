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

namespace Session_11 {

    
    public partial class TransactionF : Form {
        CoffeeShopHandler CoffeeData { get; set; } = new();
        TransactionHandler trans { get; set; } = new();
        public TransactionF(CoffeeShopHandler data , TransactionHandler tr) {
            CoffeeData = data;
            trans = tr;
            InitializeComponent();
        }

        private void TransactionF_Load(object sender, EventArgs e) {
            bsTransactions.DataSource = trans._transactions;
            gridTransactions.DataSource = bsTransactions;
            bsEmployees.DataSource = CoffeeData.Employees;
            gridEmployees.DataSource = bsEmployees;
        }

        private void btnOrder_Click(object sender, EventArgs e) {
            var employee = bsEmployees.Current as Employee;
            var transactionDetailForm = new TransactionDetailsF(CoffeeData, employee , trans);
            transactionDetailForm.ShowDialog();
            grvTransactions.RefreshData();
            

        }
    }
}
