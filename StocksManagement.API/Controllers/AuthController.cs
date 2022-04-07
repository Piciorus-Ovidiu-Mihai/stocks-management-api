using BasicAuthentification.Middleware.Models;
using BasicAuthentification.Middleware.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace StocksManagement.API.Controllers
{
    [AllowAnonymous]
    public class AuthController : ApiControllerBase
    {
        private readonly IAuthService authService;

        public AuthController(IAuthService authService)
        {
            this.authService = authService;
        }

        [HttpPost("login")]
        public ActionResult<UserLoginResponse> Login(UserLoginRequest userLoginRequest)
        {
            var user = authService.Login(userLoginRequest);

            if (user == null)
                return NotFound("Email not found");

            return Ok(user);
        }

        [HttpPost("register")]
        public async Task<ActionResult<UserRegisterResponse>> Register(UserRegisterRequest userCreateRequest)
        {
            var user = await authService.Register(userCreateRequest);

            if (user == null)
                return BadRequest("Username or Email already exists");

            return Ok(user);
        }

    }
}
