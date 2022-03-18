using StocksManagement.Domain.Entities;

namespace StocksManagement.Application.ServicesInterfaces
{
    public interface IProductService
    {
        public Task<Product> GetProductById(int id);
        public Task<IEnumerable<Product>> GetAllProducts();
        public void Create(Product product);
        public void Update(Product product);
        public void Delete(Product product);
        public void DeleteById(int id);
        public void UpdateById(int id);
    }
}
