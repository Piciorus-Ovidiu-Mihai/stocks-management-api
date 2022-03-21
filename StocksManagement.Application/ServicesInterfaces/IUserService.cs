using StocksManagement.Domain.Entities;
using StocksManagement.Domain.Models.User.Request;

namespace StocksManagement.Application.ServicesInterfaces
{
    public interface IUserService
    {
        public Task<User> GetUserById(int id);
        public Task<IEnumerable<User>> GetAllUsers();
        public void Create(UserCreateRequest user);
        public void Update(UserUpdateRequest user);
        public void Delete(User user);
        public void UpdateById(int id);
        public void DeleteById(int id);
    }
}
