using Session_11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Libs
{
    [Serializable]
    public class TransactionLine
    {
        public Guid ID { get; set; }
        public Guid ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalPrice { get; set; }
        public Transaction Transaction { get; set; }
        public Product Product { get; set; }
        public string Description { get; set; }

        public TransactionLine ()
        { 
            ID= Guid.NewGuid ();
        }
        
        public TransactionLine(Guid productID, int quantity, decimal price, decimal discount)
        {
            ProductID = productID;
            Quantity = quantity;
            Price = price;
            Discount = discount;
        }

        public void CalculatePriceLine() {
            TotalPrice = Quantity * Price;  
        }


        

    }
}






    
   

