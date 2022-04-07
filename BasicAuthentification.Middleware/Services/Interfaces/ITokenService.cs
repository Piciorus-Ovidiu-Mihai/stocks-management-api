
using StocksManagement.Domain.Entities;

namespace BasicAuthentification.Middleware.Services.Implementation
{
    public interface ITokenService
    {
        string CreateToken(User user);
    }
}
