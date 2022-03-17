using StocksManagement.Application.RepositoryInterfaces.Repositories;
using StocksManagement.Application.ServicesInterfaces;

namespace StocksManagement.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
    }
}
