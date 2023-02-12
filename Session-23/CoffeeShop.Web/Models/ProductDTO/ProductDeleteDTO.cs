namespace CoffeeShop.Web.Models.ProductDTO
{
    public class ProductDeleteDTO
    {

        public int Id { get; set; }
        public string? Code { get; set; }   
        public string? Description { get; set; }

        // do i need more details for the delete action ?

    }
}
