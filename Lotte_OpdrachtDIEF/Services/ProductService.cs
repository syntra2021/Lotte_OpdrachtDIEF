using Lotte_OpdrachtDIEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lotte_OpdrachtDIEF.Services
{
    public class ProductService : IProductService
    {
        List<Product> productList = new List<Product>();

        public ProductService()
        {
            if (productList.Count == 0)
            {
                var product1 = new Product();
                product1.Name = "Red Bull 25cl";
                product1.Price = 2.25;
                productList.Add(product1);
            }
        }

        
        public  Product GetProduct(string productName)
        {
            var product = productList.FirstOrDefault(x => x.Name == productName);
            return product;
        }

        public List<Product> GetProduct()
        {
            return productList;
        }

        public void addProduct(Product product)
        {
            productList.Add(product);
        }

        public void DeleteProductById(int productId)
        {
            throw new NotImplementedException();
        }

        public Product UpdateProductById(int productIdToEdit, Product productEditValues)
        {
            throw new NotImplementedException();
        }
    }
}
