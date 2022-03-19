using Microsoft.AspNetCore.Mvc;
using StocksManagement.Application.ServicesInterfaces;
using StocksManagement.Domain.Entities;
using StocksManagement.Domain.Models.Storage.Request;

namespace StocksManagement.API.Controllers
{
    public class ProductController : ApiControllerBase
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet("GetAllProducts")]
        public async Task<ActionResult> GetAllProducts()
        {
            var result = await productService.GetAllProducts();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetProductById(int userId)
        {
            var result = await productService.GetProductById(userId);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public void DeleteProductById(int userId)
        {
            productService.DeleteById(userId);
        }

        [HttpPut]
        public void Update(Product product)
        {
            productService.Update(product);
        }

        [HttpPost]
        public void Create(ProductCreateRequest productCreateRequest)
        {
            productService.Create(productCreateRequest);
        }
    }
}
