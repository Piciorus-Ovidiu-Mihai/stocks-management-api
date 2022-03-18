using StocksManagement.Application.RepositoryInterfaces.Repositories;
using StocksManagement.Application.ServicesInterfaces;
using StocksManagement.Domain.Entities;

namespace StocksManagement.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public void Create(User user)
        {
            userRepository.Add(user);
        }

        public void Delete(User user)
        {
            userRepository.Delete(user);
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await userRepository.GetAllAsync();
        }

        public async Task<User> GetUserById(int id)
        {
            return await userRepository.GetById(id);
        }
        public void UpdateById(int id)
        {
            userRepository.DeleteById(id);
        }

        public void DeleteById(int id)
        {
            userRepository.DeleteById(id);
        }

        public void Update(User user)
        {
            userRepository.Edit(user);
        }
    }

}
