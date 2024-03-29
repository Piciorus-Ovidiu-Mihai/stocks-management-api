﻿using AutoMapper;
using StocksManagement.Application.RepositoryInterfaces.Repositories;
using StocksManagement.Application.ServicesInterfaces;
using StocksManagement.Domain.Entities;
using StocksManagement.Domain.Models.User.Request;

namespace StocksManagement.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;

        public UserService(IUserRepository userRepository, IMapper mapper )
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await userRepository.GetAllAsync();
        }

        public IList<string> GetUserRoles(int id)
        {
            var roles = new List<string>();

            foreach (var role in userRepository.GetUserRoles(id))
            {
                roles.Add(role.Name);
            }

            return roles;
        }

        public async Task<User> GetUserById(int id)
        {
            return await userRepository.GetById(id);
        }

        public void Update(UserUpdateRequest userUpdateRequest)
        {
            userRepository.Edit(mapper.Map<User>(userUpdateRequest));
        }

        public void UpdateById(int id)
        {
            userRepository.DeleteById(id);
        }

        public void DeleteById(int id)
        {
            userRepository.DeleteById(id);
        }

        public void Delete(User user)
        {
            userRepository.Delete(user);
        }
    }

}
