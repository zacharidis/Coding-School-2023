using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GZFuelWinClient
{
    public partial class frmItems : Form
    {
        public frmItems()
        {
            InitializeComponent();
        }

        private void frmItems_Load(object sender, EventArgs e)
        {
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
           DeleteItem(Convert.ToInt32(txtItemId.Text));
        }

        private void DeleteItem(int id)
        {

        }


    }
}
