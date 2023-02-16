using System.Linq.Expressions;

namespace TripExample.DAL
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        IEnumerable<T> Get(Expression<Func<T, bool>>? query = null);
        void Save();
    }
 
}