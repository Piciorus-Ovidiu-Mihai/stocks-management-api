using Microsoft.EntityFrameworkCore;
using StocksManagement.Application.RepositoryInterfaces.Generic;
using StocksManagement.Infrastructure.Persistence;
using System.Linq.Expressions;

namespace StocksManagement.Infrastructure.Data.Generic
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly DbSet<T> entities;

        public BaseRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            entities = _dbContext.Set<T>();
        }

        public async Task<bool> Add(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await entities.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public virtual IEnumerable<T> List()
        {
            return _dbContext.Set<T>().AsEnumerable();
        }

        public virtual IEnumerable<T> List(Expression<Func<T, bool>> predicate)
        {
            return _dbContext.Set<T>()
                   .Where(predicate)
                   .AsEnumerable();
        }

        public async void UpdateById(int id)
        {
            var entity = await GetById(id);
            _dbContext.Entry(entity).State = EntityState.Modified;
            _ = _dbContext.SaveChangesAsync();
        }

        public async Task<bool> Edit(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public virtual void DeleteById(int id)
        {
            var entity = _dbContext.Set<T>().Find(id);
            _dbContext.Set<T>().Remove(entity);
            _dbContext.SaveChangesAsync();
        }
    }
}
