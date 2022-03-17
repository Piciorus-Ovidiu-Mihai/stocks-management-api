using StocksManagement.Domain.Entities;

namespace StocksManagement.Application.ServicesInterfaces
{
    public interface IProductService
    {
        public Task<Product> GetProductById(int id);
        public Task<IEnumerable<Product>> GetAllProducts();
        public void Create(Product storage);
        public void Update(Product storage);
        public void Delete(Product storage);
    }
}
