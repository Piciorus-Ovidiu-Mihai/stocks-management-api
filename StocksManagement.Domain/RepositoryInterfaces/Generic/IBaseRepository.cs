using System.Linq.Expressions;

namespace StocksManagement.Application.RepositoryInterfaces.Generic
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task<bool> Add(T entity);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetById(int id);
        IEnumerable<T> List();
        IEnumerable<T> List(Expression<Func<T, bool>> predicate);
        void UpdateById(int id);
        Task<bool> Edit(T entity);
        void DeleteById(int id);
        Task<bool> Delete(T entity);
    }
    public abstract class BaseEntity
    {
        public int Id { get; protected set; }
    }
}
