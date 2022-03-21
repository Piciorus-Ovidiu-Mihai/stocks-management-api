using AutoMapper;
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
            CreateMap<Product, ProductCreateRequest>();
            CreateMap<ProductCreateRequest, Product>();
            CreateMap<Product, ProductUpdateRequest>();
            CreateMap<ProductUpdateRequest, Product>();

            CreateMap<Storage, StorageCreateRequest>();
            CreateMap<StorageCreateRequest, Storage>();
            CreateMap<Storage, StorageUpdateRequest>();
            CreateMap<StorageUpdateRequest, Storage>();

            CreateMap<User, UserCreateRequest>();
            CreateMap<UserCreateRequest, User>();
            CreateMap<User, UserUpdateRequest>();
            CreateMap<UserUpdateRequest, User>();
        }
    }
}
