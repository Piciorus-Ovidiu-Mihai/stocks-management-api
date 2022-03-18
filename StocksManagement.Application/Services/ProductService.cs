using StocksManagement.Application.ServicesInterfaces;
using StocksManagement.Domain.Entities;
using StocksManagement.Domain.RepositoryInterfaces.Repositories;

namespace StocksManagement.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public void Create(Product product)
        {
            productRepository.Add(product);
        }

        public void Delete(Product product)
        {
            productRepository.Delete(product);
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await productRepository.GetAllAsync();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await productRepository.GetById(id);
        }

        public void Update(Product product)
        {
            productRepository.Edit(product);
        }

        public void UpdateById(int id)
        {
            productRepository.DeleteById(id);
        }

        public void DeleteById(int id)
        {
            productRepository.DeleteById(id);
        }
    }
}
