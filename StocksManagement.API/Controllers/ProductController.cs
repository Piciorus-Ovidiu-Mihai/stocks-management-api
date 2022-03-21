using Microsoft.AspNetCore.Mvc;
using StocksManagement.Application.ServicesInterfaces;
using StocksManagement.Domain.Entities;
using StocksManagement.Domain.Models.Product.Request;
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

        [HttpGet("{productId}")]
        public async Task<ActionResult> GetProductById(int productId)
        {
            var result = await productService.GetProductById(productId);
            return Ok(result);
        }

        [HttpDelete("{productId}")]
        public void DeleteProductById(int productId)
        {
            productService.DeleteById(productId);
        }

        [HttpPut]
        public void Update(ProductUpdateRequest product)
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
