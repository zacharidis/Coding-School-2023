using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Json;

namespace GZFuelWinClient
{
	public partial class frmCustomer : Form
	{
		public frmCustomer()
		{
			InitializeComponent();
		}

		private void frmCustomer_Load(object sender, EventArgs e)
		{
			try
			{
				HttpClient client = new HttpClient();
				client.BaseAddress = new Uri("https://localhost:7068/");
				var response = client.GetAsync("customer").Result;
				var emp = response.Content.ReadFromJsonAsync<IEnumerable<Customer>>().Result;
				dgvCustomers.DataSource = emp;

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message.ToString());
			}
		}

		private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
