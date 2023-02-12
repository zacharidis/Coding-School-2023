using CoffeeShop.Model.Enums;

namespace CoffeeShop.Web.Models.ProductCategoryDTO
{
    public class ProductCategoryEditDTO
    {
        public int Id { get; set; }
        public string? Code { get; set; } 
        public string? Name { get; set; }

        public ProductType ProductType { get; set; }
    }
}
