using Microsoft.EntityFrameworkCore;
using StocksManagement.Domain.Entities;

namespace StocksManagement.Infrastructure.Persistence
{
    public class DataSeed
    {
        public static async Task Seed(ApplicationDbContext dbContext)
        {
            if (await dbContext.Users.AnyAsync()) return;

            if (await dbContext.Roles.AnyAsync()) return;

            await dbContext.Roles.AddAsync(new Role { Name = "Admin" });

            await dbContext.Roles.AddAsync(new Role { Name = "Member" });

            await dbContext.SaveChangesAsync();
        }
    }
}
