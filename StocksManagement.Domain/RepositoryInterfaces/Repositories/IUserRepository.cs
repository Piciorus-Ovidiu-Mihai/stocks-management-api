using StocksManagement.Application.RepositoryInterfaces.Generic;
using StocksManagement.Domain.Entities;

namespace StocksManagement.Application.RepositoryInterfaces.Repositories
{
    public interface IUserRepository : IBaseRepository<User>
    {
        IEnumerable<Role> GetUserRoles(int id);
        User GetUserByEmail(string email);
    }
}
