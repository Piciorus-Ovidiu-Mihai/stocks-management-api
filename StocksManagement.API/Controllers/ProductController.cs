using StocksManagement.Application.ServicesInterfaces;

namespace StocksManagement.API.Controllers
{
    public class ProductController : ApiControllerBase
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }
    }
}
