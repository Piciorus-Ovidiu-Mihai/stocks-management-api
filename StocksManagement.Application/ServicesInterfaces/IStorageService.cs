using StocksManagement.Domain.Entities;

namespace StocksManagement.Application.ServicesInterfaces
{
    public interface IStorageService
    {
        public Task<Storage> GetStorageById(int id);
        public Task<IEnumerable<Storage>> GetAllStorages();
        public void DeleteById(int id);
        public void Create(Storage storage);
        public void Update(Storage storage);
        public void Delete(Storage storage);
        public void UpdateById(int id);
    }
}
