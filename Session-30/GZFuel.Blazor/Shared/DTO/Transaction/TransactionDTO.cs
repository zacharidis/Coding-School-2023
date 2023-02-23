using GZFuel.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GZFuel.Blazor.Shared.DTO.Transaction
{
    public  class TransactionDTO
    {

        public int ID { get; set; }
        public DateTime Date { get; set; }

        public PaymentMethod PaymentMethod { get; set; }
        public decimal TotalValue { get; set; }



        public TransactionDTO() { }
    }
}
