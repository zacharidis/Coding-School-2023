using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoffeeShop.Web.Models.ProductDTO
{
    public class ProductEditDTO
    {
        public int Id { get; set; }
        public string? Code { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public int ProductCategoryId { get; set; }
        public List<SelectListItem> ProductCategories { get; set; } = new List<SelectListItem>();
    }
}
