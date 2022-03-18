using StocksManagement.Domain.Entities;

namespace StocksManagement.Application.ServicesInterfaces
{
    public interface IUserService
    {
        public Task<User> GetUserById(int id);
        public Task<IEnumerable<User>> GetAllUsers();
        public void Create(User user);
        public void Update(User user);
        public void Delete(User user);
        public void UpdateById(int id);
        public void DeleteById(int id);
    }
}
