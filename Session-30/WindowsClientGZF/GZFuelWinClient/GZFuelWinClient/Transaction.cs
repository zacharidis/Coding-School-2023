using GZFuelWinClient.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GZFuelWinClient
{
	public class Transaction
	{
		public int ID { get; set; }
		public DateTime Date { get; set; }

		public int EmployeeID { get; set; }
		public int CustomerID { get; set; }

		public PaymentMethod PaymentMethod { get; set; }
		public decimal TotalValue { get; set; }

	}
}
