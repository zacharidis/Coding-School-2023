using System.Collections.Specialized;

namespace CoffeeShop.Web.Models.ProductCategoryDTO
{
    public class ProductCategoryDeleteDTO
    {
        public int Id { get; set; }
        public string? Code { get; set; }
        public string? Description { get; set; }

    }
}
