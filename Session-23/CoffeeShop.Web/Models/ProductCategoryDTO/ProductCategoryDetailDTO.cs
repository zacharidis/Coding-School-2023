using CoffeeShop.Model.Enums;

namespace CoffeeShop.Web.Models.ProductCategoryDTO
{
    public class ProductCategoryDetailDTO
    {
        public int Id { get; set; }
        public string? Code { get; set; }
        public string? Description { get; set; }
        public ProductType ProductType { get; set; }
    }
}
