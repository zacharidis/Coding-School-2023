using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GZFuel.Model.Entities
{
    public  class TransactionLine
    {
        //properties 
        public int ID { get; set; }
        public int Quantity { get; set; }
        public decimal ItemPrice { get; set; }
        public decimal TotalValue { get; set; }
        public decimal DiscountPercent { get; set; }

        public decimal NetValue { get; set; }
        public decimal DiscountValue { get; set; }


     



}
