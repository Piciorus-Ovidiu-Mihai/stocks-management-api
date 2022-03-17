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

        public void Create(User storage)
        {
            userRepository.Add(storage);
        }

        public void Delete(User storage)
        {
            userRepository.Delete(storage);
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await userRepository.GetAllAsync();
        }

        public async Task<User> GetUserById(int id)
        {
            return await userRepository.GetById(id);
        }

        public void Update(User storage)
        {
            userRepository.Edit(storage);
        }
    }
}
