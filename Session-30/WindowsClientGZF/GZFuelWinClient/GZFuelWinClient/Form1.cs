using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GZFuelWinClient
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			HttpClient client = new HttpClient();
			client.BaseAddress = new Uri("https://localhost:7068/");
			var response = client.GetAsync("customer").Result;
			var emp = response.Content.ReadFromJsonAsync<IEnumerable<Customer>>().Result;
			dataGridView1.DataSource = emp;
		}
	}
}