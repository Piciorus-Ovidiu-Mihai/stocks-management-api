﻿using AutoMapper;
using StocksManagement.Application.ServicesInterfaces;
using StocksManagement.Domain.Entities;
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

        public void Create(ProductCreateRequest productCreateRequest)
        {
            productRepository.Add(mapper.Map<Product>(productCreateRequest));
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
            productRepository.UpdateById(id);
        }

        public void DeleteById(int id)
        {
            productRepository.DeleteById(id);
        }
    }
}
