using StocksManagement.Domain.Entities;
using StocksManagement.Domain.Models.Product.Request;
using StocksManagement.Domain.Models.Storage.Request;

namespace StocksManagement.Application.ServicesInterfaces
{
    public interface IProductService
    {
        public Task<Product> GetProductById(int id);
        public Task<IEnumerable<Product>> GetAllProducts();
        public void Create(ProductCreateRequest productCreateRequest);
        public void Update(ProductUpdateRequest productUpdateRequest);
        public void UpdateById(int id);
        public void Delete(Product product);
        public void DeleteById(int id);
    }
}
