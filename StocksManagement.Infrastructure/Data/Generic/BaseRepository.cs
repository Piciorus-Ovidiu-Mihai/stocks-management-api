using Microsoft.EntityFrameworkCore;
using StocksManagement.Application.RepositoryInterfaces.Generic;
using StocksManagement.Infrastructure.Persistence;
using System.Linq.Expressions;

namespace StocksManagement.Infrastructure.Data.Generic
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext dbContext;
        private readonly DbSet<T> entities;

        public BaseRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
            this.entities = dbContext.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await entities.ToListAsync();
        }

        public virtual async Task<T> GetById(int id)
        {
            return await dbContext.Set<T>().FindAsync(id);
        }

        public async void DeleteById(int id)
        {
            var entity = await GetById(id);
            dbContext.Set<T>().Remove(entity);
        }

        public async void UpdateById(int id)
        {
            var entity = await GetById(id);
            dbContext.Entry(entity).State = EntityState.Modified;
            _ = dbContext.SaveChangesAsync();
        }

        public virtual IEnumerable<T> List()
        {
            return dbContext.Set<T>().AsEnumerable();
        }

        public virtual IEnumerable<T> List(Expression<Func<T, bool>> predicate)
        {
            return dbContext.Set<T>()
                   .Where(predicate)
                   .AsEnumerable();
        }

        public void Add(T entity)
        {
            dbContext.Set<T>().Add(entity);
            dbContext.SaveChangesAsync();
        }
        public void Edit(T entity)
        {
            dbContext.Entry(entity).State = EntityState.Modified;
            dbContext.SaveChangesAsync();
        }
        public void Delete(T entity)
        {
            dbContext.Set<T>().Remove(entity);
            dbContext.SaveChangesAsync();
        }
    }
}
