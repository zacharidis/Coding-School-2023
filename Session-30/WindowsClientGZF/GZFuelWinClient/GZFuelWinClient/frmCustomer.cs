﻿using System;
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
				// prohibit simple users from deleting customers without a password 
				MessageBox.Show("Customer Deleted!");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var responce = MessageBox.Show("Are you sure you want to update this customer ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (responce == DialogResult.Yes)
			{
				// prohibit simple users from deleting customers without a password 
				MessageBox.Show("Customer Deleted!");
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
	}
}