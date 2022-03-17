using StocksManagement.Application.RepositoryInterfaces.Repositories;
using StocksManagement.Domain.Entities;
using StocksManagement.Infrastructure.Data.Generic;
using StocksManagement.Infrastructure.Persistence;

namespace StocksManagement.Infrastructure.Data.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
