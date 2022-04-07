using AutoMapper;
using BasicAuthentification.Middleware.Models;
using StocksManagement.Domain.Entities;
using StocksManagement.Domain.Models.Product.Request;
using StocksManagement.Domain.Models.Storage.Request;
using StocksManagement.Domain.Models.User.Request;

namespace StocksManagement.Infrastructure.Mapper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {

            // Product
            CreateMap<Product, ProductCreateRequest>();
            CreateMap<ProductCreateRequest, Product>();
            CreateMap<Product, ProductUpdateRequest>();
            CreateMap<ProductUpdateRequest, Product>();

            // Storage
            CreateMap<Storage, StorageCreateRequest>();
            CreateMap<StorageCreateRequest, Storage>();
            CreateMap<Storage, StorageUpdateRequest>();
            CreateMap<StorageUpdateRequest, Storage>();

            // User
            CreateMap<User, UserUpdateRequest>();
            CreateMap<UserUpdateRequest, User>();
            CreateMap<User, UserRegisterRequest>();
            CreateMap<UserRegisterRequest, User>();
            CreateMap<UserLoginRequest, User>();
            CreateMap<User, UserLoginRequest>();
            CreateMap<User, UserLoginResponse>();
            CreateMap<UserLoginResponse, User>();
            CreateMap<UserRegisterResponse, User>();

            //Role
            CreateMap<User,UserRegisterResponse>();
            CreateMap<Role, RoleResponse>();
        }
    }
}
