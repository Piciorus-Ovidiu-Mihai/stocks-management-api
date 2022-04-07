using Microsoft.AspNetCore.Mvc;
using StocksManagement.Application.ServicesInterfaces;
using StocksManagement.Domain.Entities;
using StocksManagement.Domain.Models.User.Request;

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

        [HttpGet("{userId}")]
        public async Task<ActionResult> GetUserById(int userId)
        {
            var result = await userService.GetUserById(userId);
            return Ok(result);
        }

        [HttpPut]
        public void Update(UserUpdateRequest userUpdateRequest)
        {
            userService.Update(userUpdateRequest);
        }

        [HttpDelete("{userId}")]
        public void DeleteUserById(int userId)
        {
            userService.DeleteById(userId);
        }

    }
}
