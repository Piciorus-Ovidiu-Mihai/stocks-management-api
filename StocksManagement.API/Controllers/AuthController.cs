using BasicAuthentification.Middleware.Models;
using BasicAuthentification.Middleware.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace StocksManagement.API.Controllers
{
    public class AuthController : ApiControllerBase
    {
        [AllowAnonymous]
        public class AccountController : ApiControllerBase
        {
            private readonly IAuthService accountService;

            public AccountController(IAuthService accountService)
            {
                this.accountService = accountService;
            }

            [HttpPost("login")]
            public ActionResult<UserLoginResponse> Login(UserLoginRequest userLoginRequest)
            {
                var user = accountService.Login(userLoginRequest);

                if (user == null)
                    return NotFound("Email not found");

                return Ok(user);
            }

            [HttpPost("register")]
            public async Task<ActionResult<UserRegisterResponse>> Register(UserRegisterRequest userCreateRequest)
            {
                var user = await accountService.Register(userCreateRequest);

                if (user == null)
                    return BadRequest("Username or Email already exists");

                return Ok(user);
            }

        }
    }
}
