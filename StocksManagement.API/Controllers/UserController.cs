using StocksManagement.Application.ServicesInterfaces;

namespace StocksManagement.API.Controllers
{
    public class UserController: ApiControllerBase
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }
    }
}
