using StocksManagement.Application.ServicesInterfaces;
using StocksManagement.Domain.Entities;
using StocksManagement.Domain.RepositoryInterfaces.Repositories;

namespace StocksManagement.Application.Services
{
    public class StorageService : IStorageService
    {
        private readonly IStorageRepository storageRepository;

        public StorageService(IStorageRepository storageRepository)
        {
            this.storageRepository = storageRepository;
        }

        public void Create(Storage storage)
        {
            storageRepository.Add(storage);
        }

        public void Delete(Storage storage)
        {
            storageRepository.Delete(storage);
        }

        public async Task<IEnumerable<Storage>> GetAllStorages()
        {
            return await storageRepository.GetAllAsync();
        }

        public async Task<Storage> GetStorageById(int id)
        {
            return await storageRepository.GetById(id);
        }

        public void Update(Storage storage)
        {
            storageRepository.Edit(storage);
        }
    }
}
