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

    public partial class ProductF : Form {

        CoffeeShopHandler ProductData = new();

        public ProductF(CoffeeShopHandler data) {
            ProductData = data;
            InitializeComponent();
            grdProduct.DataSource = ProductData.Products;
        }

        private void btnSaveProduct_Click(object sender, EventArgs e) {
            ProductData.SerializeProduct();
            MessageBox.Show("JSON exported");
        }

        private void btnLoadProduct_Click(object sender, EventArgs e) {
            ProductData.CheckAndPopulateProducts();
            MessageBox.Show("Loading product data from Json\nIn case of fail it will roll Back To Default Values");
        }

        private void btnAddNew_Click(object sender, EventArgs e) {
            try {
                if (tBoxCode.Text != null && tBoxDescription.Text != null && tBoxPrice.Text != null && tBoxCost.Text != null) {
                    Product tmpEmp = new Product() {
                        Code = tBoxCode.Text,
                        Description = tBoxDescription.Text,
                        Price = Convert.ToDecimal(tBoxPrice.Text),
                        Cost = Convert.ToDecimal(tBoxCost.Text)
                    };
                    ProductData.Products.Add(tmpEmp);
                    MessageBox.Show("Added new product!");
                    ResetGVs();
                }
                else {
                    MessageBox.Show("Empty Info fields detected");
                }
            }catch(Exception ex) { MessageBox.Show("Empty Info fields detected"); }
            }
        

    private void btnRemoveProduct_Click(object sender, EventArgs e) {
            
        }
        private void ResetGVs() {
            grdProduct.DataSource = null;
            grdProduct.DataSource = ProductData.Products;
        }


    }

}
