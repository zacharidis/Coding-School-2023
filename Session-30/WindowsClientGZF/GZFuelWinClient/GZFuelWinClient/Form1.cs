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
			btnCustomers.Enabled = false;
			btnInventory.Enabled = false;
			btnTransactions.Enabled = false;
		}

		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.Capture = false;
				Message msg = Message.Create(this.Handle, 0XA1, new IntPtr(2), IntPtr.Zero);
				this.WndProc(ref msg);
			}
		}

		private void lblExit_Click(object sender, EventArgs e)
		{
			var responce = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (responce == DialogResult.Yes)
			{
				
				Application.Exit();
			}
		}
	}
}