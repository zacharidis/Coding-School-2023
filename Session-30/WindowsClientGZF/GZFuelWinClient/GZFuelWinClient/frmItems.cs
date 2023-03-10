using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GZFuelWinClient
{
    public partial class frmItems : Form
    {

        public Boolean isManager { get; set; }
        public Boolean isStaff { get; set; }


        public frmItems()
        {
            InitializeComponent();
        }

        private void frmItems_Load(object sender, EventArgs e)
        {

            isManager = false; isStaff = false;
            txtPassword.PasswordChar = '*';
            LoadItems();
        }





        public void LoadItems()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:7068/");
                var response = client.GetAsync("item").Result;
                var trans = response.Content.ReadFromJsonAsync<IEnumerable<Item>>().Result;
                dgvItems.DataSource = trans;
                dgvItems.Refresh();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void dgvItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            txtItemId.Text = Convert.ToString(dgvItems[0, row].Value);

            txtItemCode.Text = Convert.ToString(dgvItems[1, row].Value);

            txtItemDescription.Text = Convert.ToString(dgvItems[2, row].Value);

            cmbItemType.Text = Convert.ToString(dgvItems[3, row].Value);

            txtItemPrice.Text = Convert.ToString(dgvItems[4, row].Value);

            txtItemCost.Text = Convert.ToString(dgvItems[5, row].Value);
        }

        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (isStaff || isManager)
            {
                if (txtItemId.Text == "")
                {
                    MessageBox.Show("No item selected");
                }
                else
                {
                    DeleteItem(Convert.ToInt32(txtItemId.Text));
                }



            }
            else
            {
                MessageBox.Show("ACCESS DENIED , PLEASE LOGIN", "AUTHENTICATION ERROR",MessageBoxButtons.OK);
            }


        }

        private void DeleteItem(int id)
        {
            try
            {

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:7068/");
                var response = client.DeleteAsync($"item/{id}").Result;

                MessageBox.Show("Item Deleted!");
                LoadItems();
                dgvItems.Refresh();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Manager" && txtPassword.Text == "Manager")
            {
                MessageBox.Show("Login Successful!");
                isManager = true;
                lblStatus.Text = "Logged in as Manager";
                txtUsername.Text = "";
                txtPassword.Text = "";
                return;
            }
            else
            {
                lblStatus.Text = "Login Failed";
            }

            if (txtUsername.Text == "Staff" && txtPassword.Text == "Staff")
            {
                MessageBox.Show("Login Successful!");
                isStaff = true;
                lblStatus.Text = "Logged in as Staff";
                txtPassword.Text = "";
                txtUsername.Text = "";
                return;
            }
            else
            {
                lblStatus.Text = "Login Failed";
            }







        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnClearNewItemFields_Click(object sender, EventArgs e)
        {

            txtNewItemDescription.Text = "";
            txtNewItemPrice.Text = "";
            txtNewItemCost.Text = "";


        }

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            if (isManager || isStaff)
            {
                CreateItem();
            } else
            {
                MessageBox.Show("ACCESS DENIED , PLEASE LOGIN", "ERROR", MessageBoxButtons.OK);
            }
        }


        private void CreateItem()
        {
            Item item = new Item();

            item.Code = CreateCode();
            item.Description = txtNewItemDescription.Text;
            item.Cost = (Decimal.Parse(txtNewItemCost.Text));    
            item.Price= (Decimal.Parse(txtNewItemPrice.Text));
            try
            {
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri("https://localhost:7068");
                var response = httpClient.PostAsJsonAsync("Item", item).Result;
                LoadItems();
                dgvItems.Refresh();
                MessageBox.Show("Item Added!");
            } catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }

  
        }

        // thanks chatGPT for this code
        private string CreateCode()
        {

            Random random = new Random();
            int randomNumber = random.Next(10000, 99999);
            string randomLetters = new string(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ", 2)
                                            .Select(s => s[random.Next(s.Length)]).ToArray());
            return randomLetters + randomNumber.ToString();

        }


    }
}
