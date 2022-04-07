using AutoMapper;
using StocksManagement.Application.ServicesInterfaces;
using StocksManagement.Domain.Entities;
using StocksManagement.Domain.Models.Product.Request;
using StocksManagement.Domain.Models.Storage.Request;
using StocksManagement.Domain.RepositoryInterfaces.Repositories;

namespace StocksManagement.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;
        private readonly IMapper mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            this.productRepository = productRepository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await productRepository.GetAllAsync();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await productRepository.GetById(id);
        }

        public void Create(ProductCreateRequest productCreateRequest)
        {
            productRepository.Add(mapper.Map<Product>(productCreateRequest));
        }

        public void Update(ProductUpdateRequest productUpdateRequest)
        {
            productRepository.Edit(mapper.Map<Product>(productUpdateRequest));
        }

        public void UpdateById(int id)
        {
            productRepository.UpdateById(id);
        }

        public void Delete(Product product)
        {
            productRepository.Delete(product);
        }
        public void DeleteById(int id)
        {
            productRepository.DeleteById(id);
        }
    }
}
