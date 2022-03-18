using Microsoft.AspNetCore.Mvc;
using StocksManagement.Application.ServicesInterfaces;
using StocksManagement.Domain.Entities;

namespace StocksManagement.API.Controllers
{
    public class UserController: ApiControllerBase
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        public async Task<ActionResult> GetAllUsers()
        {
            var result = await userService.GetAllUsers();
            return Ok(result);
        }

        public async Task<ActionResult> GetUserById(int userId)
        {
            var result = await userService.GetUserById(userId);
            return Ok(result);
        }

        public void DeleteUserById(int userId)
        {
            userService.DeleteById(userId);
        }

        public void UpdateById(int userId)
        {
            userService.UpdateById(userId);
        }

        public void Create(User user)
        {
            userService.Create(user);
        }
    }
}
