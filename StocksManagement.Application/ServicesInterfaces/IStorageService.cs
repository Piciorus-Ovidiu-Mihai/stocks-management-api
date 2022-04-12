using StocksManagement.Domain.Entities;
using StocksManagement.Domain.Models.Storage.Request;
using StocksManagement.Domain.Models.Storage.Response;

namespace StocksManagement.Application.ServicesInterfaces
{
    public interface IStorageService
    {
        public Task<Storage> GetStorageById(int id);
        public Task<IEnumerable<Storage>> GetAllStorages();
        public Task<GetStorageProductsById> GetStorageProductsById(int id);
        public void Create(StorageCreateRequest storage);
        public Task<bool> Update(StorageUpdateRequest storageUpdateRequest);
        public void UpdateById(int id);
        public void Delete(Storage storage);
        public void DeleteById(int id);
    }
}
