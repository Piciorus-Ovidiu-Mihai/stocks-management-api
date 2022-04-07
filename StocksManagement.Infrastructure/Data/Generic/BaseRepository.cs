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

        public async Task<T> GetById(int id)
        {
            return await dbContext.Set<T>().FindAsync(id);
        }

        public virtual void DeleteById(int id)
        {
            var entity = dbContext.Set<T>().Find(id);
            dbContext.Set<T>().Remove(entity);
            dbContext.SaveChangesAsync();
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

        public async Task<bool> Add(T entity)
        {
            await dbContext.Set<T>().AddAsync(entity);
            return await dbContext.SaveChangesAsync() > 0;
        }
        public async Task<bool> Edit(T entity)
        {
            dbContext.Entry(entity).State = EntityState.Modified;
            return await dbContext.SaveChangesAsync() > 0;
        }
        public async Task<bool> Delete(T entity)
        {
            dbContext.Set<T>().Remove(entity);
            return await dbContext.SaveChangesAsync() > 0;
        }
    }
}
