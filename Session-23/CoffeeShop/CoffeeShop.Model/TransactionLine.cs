namespace CoffeeShop.Model
{
    public class TransactionLine
    {
        public TransactionLine(int quantity, decimal discount, decimal price, decimal totalPrice)
        {
            Quantity = quantity;
            Discount = discount;
            Price = price;
            TotalPrice = totalPrice;
        }

        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }

        // Relations
        public int TransactionId { get; set; }
        public Transaction Transaction { get; set; } = null!;

        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
    }
}
