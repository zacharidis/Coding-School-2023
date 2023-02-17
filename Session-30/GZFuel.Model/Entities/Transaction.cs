using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GZFuel.Model.Entities
{
    public class Transaction
    {
        // properties
        // ID, TransactionID, ItemID, Quantity, 
       //  ItemPrice, NetValue, DiscountPercent, DiscountValue, 
       //  TotalValue 

        public int ID { get; set; }
        public int TransactionID { get; set; }
        public int ItemID { get; set; }
        public int Quantity { get; set; }
        public decimal ItemPrice { get; set; }
        public decimal NetValue { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal DiscountValue { get; set; }
        public decimal TotalValue { get; set; }

        // constructor
        public Transaction()
        {
        
            // Net Value , Discount Percent, Discount Value, Total Value will be calculated in the constructor ! 
            // Net Value = Quantity * Item Price
            // Discount Value = Net Value * Discount Percent
            // Total Value = Net Value - Discount Value


        
        }


   

    }
}
