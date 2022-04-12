using AutoMapper;
using StocksManagement.Application.ServicesInterfaces;
using StocksManagement.Domain.Entities;
using StocksManagement.Domain.Models.Product.Response;
using StocksManagement.Domain.Models.Storage.Request;
using StocksManagement.Domain.Models.Storage.Response;
using StocksManagement.Domain.RepositoryInterfaces.Repositories;

namespace StocksManagement.Application.Services
{
    public class StorageService : IStorageService
    {
        private readonly IStorageRepository storageRepository;
        private readonly IProductRepository productRepository;
        private readonly IMapper mapper;

        public StorageService(IStorageRepository storageRepository, IMapper mapper, IProductRepository productRepository)
        {
            this.storageRepository = storageRepository;
            this.productRepository = productRepository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<Storage>> GetAllStorages()
        {
            return await storageRepository.GetAllAsync();
        }

        public async Task<Storage> GetStorageById(int id)
        {
            return await storageRepository.GetById(id);
        }

        public async Task<GetStorageProductsById> GetStorageProductsById(int id)
        {
            var storage = await storageRepository.GetStorageProductsById(id);
            GetStorageProductsById storageModel = new GetStorageProductsById()
            {
                Name = storage.Name,
                Location = storage.Location,
                getProductResponses = new List<GetProductResponse>()
                {
                }
            };
            foreach (var product in storage.Products)
            {
                storageModel.getProductResponses.Add(mapper.Map<GetProductResponse>(product));

            }
            return storageModel;
        }

        public void Create(StorageCreateRequest storageCreateRequest)
        {
            storageRepository.Add(mapper.Map<Storage>(storageCreateRequest));
        }

        public async Task<bool> Update(StorageUpdateRequest storageUpdateRequest)
        {
            Storage storage = await GetStorageById(storageUpdateRequest.Id);
            foreach (var id in storageUpdateRequest.ProductsIds)
            {
                var product = await productRepository.GetById(id);
                storage.Products.Add(product);
            }
            return await storageRepository.Edit(storage);
        }

        public void UpdateById(int id)
        {
            storageRepository.DeleteById(id);
        }

        public void Delete(Storage storage)
        {
            storageRepository.Delete(storage);
        }

        public void DeleteById(int id)
        {
            storageRepository.DeleteById(id);
        }
    }
}