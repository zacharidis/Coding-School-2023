using CoffeeShop.EF.Context;
using CoffeeShop.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.EF.Repository
{
    internal class ProductRepo : IEntityRepo<Product>

    {
        public void Add(Product entity)
        {
            using var context = new CoffeeShopDbContext();
            context.Products.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id, Product entity)
        {
            using var context = new CoffeeShopDbContext();
            var foundProduct = context.Products.SingleOrDefault(p => p.Id == id);   
            if (foundProduct != null)
            {
                context.Products.Remove(foundProduct);
                context.SaveChanges();
            } else
            {
                throw new Exception("Product not found !");
            }

            
        }

        public IEnumerable<Product> GetAll()
        {
            using var context = new CoffeeShopDbContext();
            return context.Products.ToList();
        }


        public Product? GetById(int id)
        {
            using var context = new CoffeeShopDbContext();

            var selectedProduct = context.Products.Include(p => p.ProductCategory)
                .Where(p => p.Id == id)
                .SingleOrDefault();
            if (selectedProduct != null)
            {
                return selectedProduct;
            }
            else

            { return null; } 

        }

        public void Update(int id, Product entity)
        {
            using var context = new CoffeeShopDbContext();
            var selectedProduct = context.Products.SingleOrDefault(p=>p.Id == id);
            if (selectedProduct != null)
            {
                selectedProduct.Price = entity.Price;
                selectedProduct.Description = entity.Description;
                selectedProduct.Cost = entity.Cost;
                selectedProduct.Code = entity.Code;
                selectedProduct.ProductCategory = entity.ProductCategory;
                selectedProduct.ProductCategoryId= entity.ProductCategoryId;
                context.SaveChanges();
            } else
            {
                throw new Exception("Product failed to be updated");
            }
        }
    }
}
