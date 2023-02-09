using CoffeeShop.Model.Enums;

namespace CoffeeShop.Model
{
    public class Transaction
    {
        public Transaction(decimal totalPrice, PaymentMethod paymentMethod)
        {
            Date = DateTime.Now;
            TotalPrice = totalPrice;
            PaymentMethod = paymentMethod;

            TransactionLines = new List<TransactionLine>();
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalPrice { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

        // Relations
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; } = null!;

        public List<TransactionLine> TransactionLines { get; set; }
    }
}
