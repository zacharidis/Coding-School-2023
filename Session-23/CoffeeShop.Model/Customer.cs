namespace CoffeeShop.Model
{
    public class Customer
    {
        public Customer(string code, string description)
        {
            Code = code;
            Description = description;

            Transactions = new List<Transaction>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        // Relations
        public List<Transaction> Transactions { get; set; }
    }
}
