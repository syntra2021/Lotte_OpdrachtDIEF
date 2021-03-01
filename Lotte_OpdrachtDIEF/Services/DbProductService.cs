using Lotte_OpdrachtDIEF.Db;
using Lotte_OpdrachtDIEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lotte_OpdrachtDIEF.Services
{
    public class DbProductService : IProductService
    {
        public void addProduct(Product product)
        {
            using (var db = new ProductDbContext())
            {
                db.Add(product);
                db.SaveChanges();
            }
        }

        public Product GetProduct(string productName)
        {
            using (var db = new ProductDbContext())
            {
                var product = db.Products.FirstOrDefault(product => product.Name == productName);
                return product;
            }
        }

        public List<Product> GetProduct()
        {
            using (var db = new ProductDbContext())
            {
                return db.Products.ToList();
            }
        }

        public void DeleteProductById(int productId)
        {
            using (var db = new ProductDbContext())
            {
                var productToDelete = db.Products.Find(productId);
                db.Products.Remove(productToDelete);
                db.SaveChanges();
            }
        }

        public Product UpdateProductById(int productIdToEdit, Product productEditValues)
        {
            using (var db = new ProductDbContext())
            {
                var productToEdit = db.Products.First(product => product.ProductId == productIdToEdit);
                productToEdit.Price = productEditValues.Price;
                productToEdit.Name = productEditValues.Name;
                db.Products.Update(productToEdit);
                db.SaveChanges();
                return productToEdit;
            }
        }
        

    }
}
