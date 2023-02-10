using CoffeeShop.EF.Context;
using CoffeeShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.EF.Repository
{
    internal class ProductCategoryRepo : IEntityRepo<ProductCategory>


    {
        public void Add(ProductCategory entity)
        {
            using var context = new CoffeeShopDbContext();
            context.ProductCategories.Add(entity);
            context.SaveChanges();
            // maybe i shall add the 3 product category limitation here. 
            // to be reevaluated :/ 

        }

        public void Delete(int id, ProductCategory entity)
        {
            using var context = new CoffeeShopDbContext();
            var selectedProductCategory = context.ProductCategories.FirstOrDefault(pc => pc.Id == id);
            if (selectedProductCategory != null)
            {
                context.ProductCategories.Remove(selectedProductCategory);
                context.SaveChanges();

            } else
            {
                throw new Exception("Product cateogry not found");
            }
        }

        public IEnumerable<ProductCategory> GetAll()
        {
            using var context = new CoffeeShopDbContext();
            return context.ProductCategories.ToList();

        }

        public ProductCategory? GetById(int id)
        {
            using var context = new CoffeeShopDbContext();
            return context.ProductCategories.Where(pc=>pc.Id == id).SingleOrDefault();
        }

        public void Update(int id, ProductCategory entity)
        {
            using var context = new CoffeeShopDbContext();
            var selectedProductCategory = context.ProductCategories.SingleOrDefault(pc => pc.Id == id); 
            if (selectedProductCategory != null)
            {
                selectedProductCategory.ProductType = entity.ProductType;
                selectedProductCategory.Description = entity.Description;
                selectedProductCategory.Code = entity.Code;
                context.SaveChanges();

            } else
            {
                throw new Exception("Product category not found ");
            }

        }
    }
}
