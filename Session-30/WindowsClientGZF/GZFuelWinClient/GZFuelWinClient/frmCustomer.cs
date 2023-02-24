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
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace GZFuelWinClient
{

	//TODO async await all server calls
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

		private void dgvCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int row = e.RowIndex;
			txtCustomerId.Text = Convert.ToString(dgvCustomers[0, row].Value);
			txtCustomerName.Text = Convert.ToString(dgvCustomers[1, row].Value);
			txtCustomerSurname.Text = Convert.ToString(dgvCustomers[2, row].Value);
			txtCusCard.Text = Convert.ToString(dgvCustomers[3, row].Value);

			try
			{
				HttpClient client = new HttpClient();
				client.BaseAddress = new Uri("https://localhost:7068/");
				var response = client.GetAsync($"transaction/{txtCustomerId.Text}").Result;
				var transactionlist = response.Content.ReadFromJsonAsync<IEnumerable<Transaction>>().Result;
				dgvTransactions.DataSource = transactionlist;

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message.ToString());
			}


		}

		private void button1_Click(object sender, EventArgs e)
		{
			var responce = MessageBox.Show("Are you sure you want to delete this customer ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (responce == DialogResult.Yes)
			{
				string input = string.Empty;
				if (ShowInputDialog(ref input) == DialogResult.OK)
				{
					if (input == "manager" || input =="cashier")
					{


						    int selectedId = Convert.ToInt32(txtCustomerId.Text);
							DeleteCustomer(selectedId);

					
						

					}
					else
					{
						MessageBox.Show("Invalid Password");
					}
				}



				
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var responce = MessageBox.Show("Are you sure you want to update this customer ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (responce == DialogResult.Yes)
			{
				int selectedId = Convert.ToInt32(txtCustomerId.Text);
				UpdateCustomer(selectedId);
				// prohibit simple users from deleting customers without a password 
				
			}
		}

		private void button1_Click_1(object sender, EventArgs e)
		{

		}

		private void btnAddNewCustomer_Click(object sender, EventArgs e)
		{
			string newCard = CardGenerator();
		}

		private void button1_Click_2(object sender, EventArgs e)
		{
			if (this.Width == 711)
			{
				this.Width = 1200;
			}
			else
			{
				this.Width = 711;
			}
		}

		public string CardGenerator()
		{
			Random random = new Random();
			string cardNumber = 'A' + random.Next(100000000, 999999999).ToString();
			return cardNumber;
		}



		

		private static DialogResult ShowInputDialog(ref string input)
		{
			System.Drawing.Size size = new System.Drawing.Size(200, 70);
		Form inputBox = new Form();

		inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			inputBox.ClientSize = size;
			inputBox.Text = "Password";

			System.Windows.Forms.TextBox textBox = new TextBox();
		textBox.Size = new System.Drawing.Size(size.Width - 10, 23);
			textBox.Location = new System.Drawing.Point(5, 5);
			textBox.Text = input;
			inputBox.Controls.Add(textBox);

			Button okButton = new Button();
		okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			okButton.Name = "okButton";
			okButton.Size = new System.Drawing.Size(75, 23);
			okButton.Text = "&OK";
			okButton.Location = new System.Drawing.Point(size.Width - 80 - 80, 39);
			inputBox.Controls.Add(okButton);

			Button cancelButton = new Button();
		cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			cancelButton.Name = "cancelButton";
			cancelButton.Size = new System.Drawing.Size(75, 23);
			cancelButton.Text = "&Cancel";
			cancelButton.Location = new System.Drawing.Point(size.Width - 80, 39);
			inputBox.Controls.Add(cancelButton);

			inputBox.AcceptButton = okButton;
			inputBox.CancelButton = cancelButton;

			DialogResult result = inputBox.ShowDialog();
		input = textBox.Text;
			return result;
		}


		private void DeleteCustomer(int id)
		{
			try
			{

				HttpClient client = new HttpClient();
				client.BaseAddress = new Uri("https://localhost:7068/");
				var response = client.DeleteAsync($"customer/{id}").Result;
				dgvCustomers.Refresh();
				MessageBox.Show("Customer Deleted!");


			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}


		}


		private void UpdateCustomer(int id)
		{
			Customer customer = new();

			customer.Name= txtNewCusName.Text;
			customer.Surname = txtNewCusSurname.Text;
			customer.CardNumber = txtCusCard.Text;
			customer.Id = id;

			try
			{
				HttpClient client = new HttpClient();
				client.BaseAddress = new Uri("https://localhost:7068/");

				
				//TODO Put not working
				var response = client.PutAsJsonAsync($"Customer",customer).Result;



				
				dgvCustomers.Refresh();
				MessageBox.Show("Customer Updated!");
			} catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}






		}



	}
}
