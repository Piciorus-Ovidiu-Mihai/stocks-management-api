using Microsoft.AspNetCore.Mvc;
using StocksManagement.Application.ServicesInterfaces;
using StocksManagement.Domain.Entities;

namespace StocksManagement.API.Controllers
{
    public class ProductController : ApiControllerBase
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        public async Task<ActionResult> GetAllProducts()
        {
            var result = await productService.GetAllProducts();
            return Ok(result);
        }

        public async Task<ActionResult> GetProductById(int userId)
        {
            var result = await productService.GetProductById(userId);
            return Ok(result);
        }

        public void DeleteProductById(int userId)
        {
            productService.DeleteById(userId);
        }

        public void UpdateById(int userId)
        {
            productService.UpdateById(userId);
        }

        public void Create(Product product)
        {
            productService.Create(product);
        }
    }
}
