using Microsoft.EntityFrameworkCore;
using StocksManagement.Application.RepositoryInterfaces.Repositories;
using StocksManagement.Domain.Entities;
using StocksManagement.Infrastructure.Data.Generic;
using StocksManagement.Infrastructure.Persistence;

namespace StocksManagement.Infrastructure.Data.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly ApplicationDbContext dbContext;
        public UserRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<Role> GetUserRolesAsync(int id)
        {
            var user = dbContext.Users.Include(u => u.Roles).SingleOrDefault(u => u.Id == id);

            return user.Roles.ToList();
        }

        public User GetUserByEmail(string email)
        {
            return dbContext.Users.Include(u => u.Roles).FirstOrDefault(x => x.Email == email);
        }
    }
}
