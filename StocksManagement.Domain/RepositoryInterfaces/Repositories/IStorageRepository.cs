using StocksManagement.Application.RepositoryInterfaces.Generic;
using StocksManagement.Domain.Entities;

namespace StocksManagement.Domain.RepositoryInterfaces.Repositories
{
    public interface IStorageRepository : IBaseRepository<Storage>
    {
        Task<Storage> GetStorageProductsById(int id);
    }

}
