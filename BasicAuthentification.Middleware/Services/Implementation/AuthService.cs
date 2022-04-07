using AutoMapper;
using BasicAuthentification.Middleware.Models;
using BasicAuthentification.Middleware.Services.Implementation;
using StocksManagement.Application.RepositoryInterfaces.Repositories;
using StocksManagement.Domain.Entities;
using StocksManagement.Domain.RepositoryInterfaces.Repositories;

namespace BasicAuthentification.Middleware.Services.Interfaces
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;
        private readonly ITokenService tokenService;
        private readonly IRoleRepository roleRepository;

        public AuthService(IUserRepository userRepository, IMapper mapper, ITokenService tokenService, IRoleRepository roleRepository)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
            this.tokenService = tokenService;
            this.roleRepository = roleRepository;
        }

        public UserLoginResponse Login(UserLoginRequest userLoginRequest)
        {
            var user = userRepository.GetUserByEmail(userLoginRequest.Email);
            if (user == null)
                return null;


            if (!BCrypt.Net.BCrypt.Verify(userLoginRequest.Password, user.Password))
                return null;

            var userResponse = mapper.Map<UserLoginResponse>(user);

            userResponse.Token = this.tokenService.CreateToken(user);

            return userResponse;
        }

        public async Task<UserLoginResponse> Register(UserRegisterRequest userRegisterRequest)
        {
            var users = await userRepository.GetAllAsync();
            if (users.Any(u => u.Email == userRegisterRequest.Email || u.Name == userRegisterRequest.Name))
                return null;

            var user = mapper.Map<User>(userRegisterRequest);
            user.Password = BCrypt.Net.BCrypt.HashPassword(userRegisterRequest.Password);
            var role = await roleRepository.GetById(2);
            user.Roles.Add(role); //Add as member

            if (!(await userRepository.Add(user)))
                return null;

            var userResponse = mapper.Map<UserLoginResponse>(user);
            userResponse.Token = this.tokenService.CreateToken(user);

            return userResponse;
        }
    }
}
