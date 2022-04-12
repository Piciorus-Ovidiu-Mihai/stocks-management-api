using Microsoft.EntityFrameworkCore;
using StocksManagement.Domain.Entities;
using StocksManagement.Domain.RepositoryInterfaces.Repositories;
using StocksManagement.Infrastructure.Data.Generic;
using StocksManagement.Infrastructure.Persistence;

namespace StocksManagement.Infrastructure.Data.Repositories
{
    public class StorageRepository : BaseRepository<Storage>, IStorageRepository
    {
        private readonly ApplicationDbContext applicationDbContext;
        public StorageRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            applicationDbContext = dbContext;
        }

        public async Task<Storage> GetStorageProductsById(int id)
        {
            return await applicationDbContext.Storages.Include(s => s.Products).FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
