using Lotte_OpdrachtDIEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lotte_OpdrachtDIEF.Services
{
    public interface IProductService
    { 
        Product GetProduct(string productName);
        List<Product> GetProduct();
        void addProduct(Product product);
        void DeleteProductById(int productId);
        Product UpdateProductById(int productIdToEdit, Product productEditValues);

    }
}
