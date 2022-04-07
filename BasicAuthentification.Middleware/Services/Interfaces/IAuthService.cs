
using BasicAuthentification.Middleware.Models;

namespace BasicAuthentification.Middleware.Services.Interfaces
{
    public interface IAuthService
    {
        UserLoginResponse Login(UserLoginRequest userLoginRequest);
        Task<UserLoginResponse> Register(UserRegisterRequest userRegisterRequest);
    }
}
