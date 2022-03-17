using Microsoft.EntityFrameworkCore;
using StocksManagement.Domain.Entities;

namespace StocksManagement.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        DbSet<User> Users;
        DbSet<Role> Roles;
    }
}
