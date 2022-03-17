using System.Linq.Expressions;

namespace StocksManagement.Application.RepositoryInterfaces.Generic
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetById(int id);
        IEnumerable<T> List();
        IEnumerable<T> List(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Delete(T entity);
        void Edit(T entity);
    }
    public abstract class BaseEntity
    {
        public int Id { get; protected set; }
    }
}
