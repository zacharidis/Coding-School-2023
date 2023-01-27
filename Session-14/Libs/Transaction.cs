using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libs
{
    public class Transaction
    {
        public Guid ID { get; set; }
        public DateTime Date { get; set; }
        public Guid CustomerID { get; set; }
        public Guid EmployeeID { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public List<TransactionLine> TransactionLines { get; set; }
        public decimal TotalPrice { get; set; }

        public PaymentMethod PaymentMean { get; set; }
    
        public Transaction()
        {
            ID= Guid.NewGuid();
            TransactionLines= new List<TransactionLine>();

        }
        public Transaction( DateTime date, Guid customerID, Guid employeeID)
        {
            Date = date;
            CustomerID = customerID;
            EmployeeID = employeeID;
            TransactionLines = new List<TransactionLine>();
        }   
    }
}
