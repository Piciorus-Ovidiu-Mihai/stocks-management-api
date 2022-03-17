using StocksManagement.Domain.Entities;
using StocksManagement.Domain.RepositoryInterfaces.Repositories;
using StocksManagement.Infrastructure.Data.Generic;
using StocksManagement.Infrastructure.Persistence;

namespace StocksManagement.Infrastructure.Data.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
