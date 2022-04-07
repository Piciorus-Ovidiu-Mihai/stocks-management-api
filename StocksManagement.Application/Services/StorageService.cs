using AutoMapper;
using StocksManagement.Application.ServicesInterfaces;
using StocksManagement.Domain.Entities;
using StocksManagement.Domain.Models.Storage.Request;
using StocksManagement.Domain.Models.Storage.Response;
using StocksManagement.Domain.RepositoryInterfaces.Repositories;

namespace StocksManagement.Application.Services
{
    public class StorageService : IStorageService
    {
        private readonly IStorageRepository storageRepository;
        private readonly IMapper mapper;

        public StorageService(IStorageRepository storageRepository, IMapper mapper)
        {
            this.storageRepository = storageRepository;
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

        public void Create(StorageCreateRequest storageCreateRequest)
        {
            storageRepository.Add(mapper.Map<Storage>(storageCreateRequest));
        }

        public void Update(StorageUpdateRequest storageUpdateRequest)
        {
            storageRepository.Edit(mapper.Map<Storage>(storageUpdateRequest));
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