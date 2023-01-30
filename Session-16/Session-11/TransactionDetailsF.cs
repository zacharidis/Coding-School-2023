using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
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
    public partial class TransactionDetailsF : Form {
        public CoffeeShopHandler CoffeeData = new();
        public Transaction NewTransaction { get; set; } = new();
        public TransactionHandler THandler { get; set; } = new();
        public Employee Employee { get; set; } = new();
        public Customer Customer = new();

        public TransactionDetailsF(CoffeeShopHandler data, Employee emp, TransactionHandler trans) {
            THandler = trans;
            CoffeeData = data;
            Employee = emp;
            NewTransaction = new Transaction() {
                CustomerID = Customer.ID,
                EmployeeID = emp.ID,
                Date = DateTime.Now,
            };
            InitializeComponent();
            bsProducts.DataSource = CoffeeData.Products;
            gridProducts.DataSource = bsProducts;
            bsTransactions.DataSource = THandler._transaction;
            bsTransactionLines.DataSource = THandler._transaction.TransactionLines;
            gridTransactionLines.DataSource = bsTransactionLines;
            lookUpPaymentMethod.DataBindings.Add(new Binding("EditValue", bsTransactions, "PaymentMethod", true));
        }

        private void TransactionDetailsF_Load(object sender, EventArgs e) {
            UpdateLabelTotalPrice();
            PopulatePaymentMethod(lookUpPaymentMethod.Properties);
            

        }
        private void RefreshGv() {
            bsTransactionLines.DataSource = null;
            gridTransactionLines.DataSource = null;
            bsTransactionLines.DataSource = THandler._transaction.TransactionLines;
            gridTransactionLines.DataSource = bsTransactionLines;

        }

        private void UpdateLabelTotalPrice() {
            labelTotalPrice.Text = "Total: " + THandler._transaction.TotalPrice.ToString();
        }

        private void AddNewLine(Product selectedProduct) {
            var newTransactionLine = new TransactionLine() {
                ProductID = selectedProduct.ProductID,
                Description = selectedProduct.Description,
                Quantity = Convert.ToInt32(spinEditQuantity.Text),
                Price = selectedProduct.Price,
                TotalPrice = Convert.ToInt32(spinEditQuantity.Text) * selectedProduct.Price,
            };
            THandler.AddTransactionLines(newTransactionLine);
            THandler.CalculateTransaction();
        }
        private void ResetQuantity() {
            spinEditQuantity.Text = "1";
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            var selectedProduct = bsProducts.Current as Product;
            if (selectedProduct != null) {
                AddNewLine(selectedProduct);
                ResetQuantity();
                RefreshGv();
                UpdateLabelTotalPrice();
            }

        }
        private void btnSave_Click(object sender, EventArgs e) {
            string errorMessage = THandler.FinalizeTransaction();
            if (errorMessage != string.Empty) {
                MessageBox.Show(errorMessage);
                return;
            }
            THandler.SaveTransactionToJson();
            THandler.Addnew();
            MessageBox.Show("Reciept Printed!");
        }
        private void btnRemove_Click(object sender, EventArgs e) {
            var selectedLine = bsTransactionLines.Current as TransactionLine;
            if (selectedLine != null) {

                THandler._transaction.TransactionLines.Remove(selectedLine);
                THandler.CalculateTransaction();
                UpdateLabelTotalPrice();
                RefreshGv();
                grvTransactionLines.RefreshData();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e) {
            THandler._transaction.TransactionLines.Clear();
            this.Close();
        }

        public static void PopulatePaymentMethod(RepositoryItemLookUpEdit lookup) {
            var types = new Dictionary<PaymentMethod, string>()
            {
            { PaymentMethod.Cash, "Cash" },
            { PaymentMethod.CreditCard, "Credit Card" }
        };

            lookup.DataSource = types;
            lookup.Columns.Add(new LookUpColumnInfo("Value"));
            lookup.DisplayMember = "Value";
            lookup.ValueMember = "Key";
            lookup.ShowHeader = false;
        }
    }
}
