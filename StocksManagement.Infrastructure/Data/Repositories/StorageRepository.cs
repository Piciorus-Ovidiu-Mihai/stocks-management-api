using StocksManagement.Domain.Entities;
using StocksManagement.Domain.RepositoryInterfaces.Repositories;
using StocksManagement.Infrastructure.Data.Generic;
using StocksManagement.Infrastructure.Persistence;

namespace StocksManagement.Infrastructure.Data.Repositories
{
    internal class StorageRepository : BaseRepository<Storage>, IStorageRepository
    {
        public StorageRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
