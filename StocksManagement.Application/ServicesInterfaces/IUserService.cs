using StocksManagement.Domain.Entities;

namespace StocksManagement.Application.ServicesInterfaces
{
    public interface IUserService
    {
        public Task<User> GetUserById(int id);
        public Task<IEnumerable<User>> GetAllUsers();
        public void Create(User storage);
        public void Update(User storage);
        public void Delete(User storage);
    }
}
