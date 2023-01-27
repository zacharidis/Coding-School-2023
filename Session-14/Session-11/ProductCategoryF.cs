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


    

    public partial class ProductCategoryF : Form {

        CoffeeShopHandler ShopCategory { get; set; } = new();

        public ProductCategoryF(CoffeeShopHandler transfer) {

            ShopCategory = transfer;
            InitializeComponent();

            gcProductCategory.DataSource = ShopCategory.ProductCategories;
        }

        private void ProductCategoryF_Load(object sender, EventArgs e)
        {

        }

        private void ProductCategoryF_Load1(object sender, EventArgs e)
        {
            /*private void ProductCategoryF_Load(object sender, EventArgs e) {

                PopulateData();

            }*/
        }

        public void PopulateData() {

            ProductCategory productCategory = new ProductCategory();

        }

        private void btnReloadCategories_Click(object sender, EventArgs e)
        {
            gcProductCategory.DataSource = null;
            gcProductCategory.DataSource = ShopCategory.ProductCategories;
        }

        private void btnReloadFromJson_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Loading Employee File from Json\nIn case of fail it will roll Back To Default Values");
            ShopCategory.CheckAndPopulateProductCategories();
        }

        private void btnExportToJson_Click(object sender, EventArgs e)
        {
            ShopCategory.SerializeProductCategory();
            MessageBox.Show("Exported Successfully!");
        }
        private void ResetProductCategoryGVs()
        {
            gcProductCategory.DataSource = null;
            gcProductCategory.DataSource = ShopCategory.ProductCategories;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ShopCategory.ProductCategories.Clear();
            ShopCategory.SetDefaultProductCategories();
            ResetProductCategoryGVs();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCategory_Click_1(object sender, EventArgs e)
        {
            ProductCategory tmpCateg = new ProductCategory()
            {
                Code = tboxAddCategory.Text,
                Description = tboxDescription.Text,
                ProductType =  (ProductType)Enum.Parse(typeof(ProductType), comboProductType.SelectedItem.ToString())
            };
            ShopCategory.ProductCategories.Add(tmpCateg);
            ResetProductCategoryGVs();
        }


        /* private void btnReloadProductCategories_EditValueChanged(object sender, EventArgs e)
         {
             grdProductCategory.DataSource = null;
             grdProductCategory.DataSource = ShopCategory.ProductCategories;
         }

         private void btnLoadCategoriesJson_EditValueChanged(object sender, EventArgs e)
         {
             MessageBox.Show("Loading Employee File from Json\nIn case of fail it will roll Back To Default Values");
             ShopCategory.CheckAndPopulateProductCategories();
         }*/
    }
}
