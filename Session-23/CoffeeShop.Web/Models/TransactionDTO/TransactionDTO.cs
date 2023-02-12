using CoffeeShop.Model.Enums;

namespace CoffeeShop.Web.Models.TransactionDTO
{
    public class TransactionDTO
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalPrice { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
    }
}
