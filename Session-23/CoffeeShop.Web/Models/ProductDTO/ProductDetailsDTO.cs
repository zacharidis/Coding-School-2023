using CoffeeShop.Model;

namespace CoffeeShop.Web.Models.ProductDTO
{
    public class ProductDetailsDTO
    {
        public int Id { get; set; }
        public string? Code { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }

        public int ProductCategoryId { get; set; }

        public ProductCategory? productCategory { get; set; }

        // something is wrong here !

    }
}
