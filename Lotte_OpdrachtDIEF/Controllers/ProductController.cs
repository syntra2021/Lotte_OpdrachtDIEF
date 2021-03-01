using Lotte_OpdrachtDIEF.Db;
using Lotte_OpdrachtDIEF.Models;
using Lotte_OpdrachtDIEF.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lotte_OpdrachtDIEF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        //data beschikbaar stellen - http calls

        //methode 
        
        [HttpGet("Many")]
        public ActionResult<List<Product>> GetAllProducts()
        {
            return Ok(_productService.GetProduct());
        }

        [HttpGet("One")]
        public ActionResult<Product> GetProduct(string productName)
        {

            var product = _productService.GetProduct(productName);
            if (product == null)
            {
                return NotFound();
            }
                return Ok(product);    
        }


        [HttpPost]
        public ActionResult CreateNewProduct(Product newProduct)
        {
            _productService.addProduct(newProduct);
            return Ok();
        }

        [HttpDelete]
        public ActionResult DeleteProductById(int productId)
        {
            _productService.DeleteProductById(productId);
            return Ok();

        }

        [HttpPut]
        public ActionResult<Product> UpdateProductById(int productIdToEdit, Product productEditValues)
        {
            var updatedHouse = _productService.UpdateProductById(productIdToEdit,  productEditValues);
            return Ok(updatedHouse);
        }
    }

}
