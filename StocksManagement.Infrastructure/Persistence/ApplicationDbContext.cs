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

        DbSet<User> Users { get; set; }
        DbSet<Role> Roles { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<Storage> Storages { get; set; }
    }
}
