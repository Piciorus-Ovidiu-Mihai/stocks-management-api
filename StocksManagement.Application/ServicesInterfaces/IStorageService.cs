using StocksManagement.Domain.Entities;
using StocksManagement.Domain.Models.Storage.Request;

namespace StocksManagement.Application.ServicesInterfaces
{
    public interface IStorageService
    {
        public Task<Storage> GetStorageById(int id);
        public Task<IEnumerable<Storage>> GetAllStorages();
        public void Create(StorageCreateRequest storage);
        public void Update(StorageUpdateRequest storage);
        public void UpdateById(int id);
        public void Delete(Storage storage);
        public void DeleteById(int id);
    }
}
