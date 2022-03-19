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

        [HttpGet("GetAllUsers")]
        public async Task<ActionResult> GetAllUsers()
        {
            var result = await userService.GetAllUsers();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetUserById(int userId)
        {
            var result = await userService.GetUserById(userId);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public void DeleteUserById(int userId)
        {
            userService.DeleteById(userId);
        }

        [HttpPut]
        public void Update(User user)
        {
            userService.Update(user);
        }

        [HttpPost]
        public void Create(User user)
        {
            userService.Create(user);
        }
    }
}
