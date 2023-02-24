using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GZFuelWinClient
{
	public partial class Form1 : Form
	{
		public const string BaseUrl = "https://localhost:7068/";
		public const string username = "admin";
		public const string password = "admin";
		public Form1()
		{
			InitializeComponent();
		}

		//private void button1_Click(object sender, EventArgs e)
		//{

		//	try
		//	{
		//		HttpClient client = new HttpClient();
		//		client.BaseAddress = new Uri("https://localhost:7068/");
		//		var response = client.GetAsync("customer").Result;
		//		var emp = response.Content.ReadFromJsonAsync<IEnumerable<Customer>>().Result;
		//		dgvCustomers.DataSource = emp;

		//	}
		//	catch (Exception ex)
		//	{

		//		MessageBox.Show(ex.Message.ToString());
		//	}

		//}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}