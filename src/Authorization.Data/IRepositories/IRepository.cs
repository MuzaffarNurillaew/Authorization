using Authorization.Domain.Commons;
using System.Linq.Expressions;

namespace Authorization.Data.IRepositories
{
    public interface IRepository<T> where T : Auditable
    {
        ValueTask<T> InsertAsync(T entity);
        T UpdateAsync(T entity);
        bool Delete(T entity);
        ValueTask<T> SelectAsync(Expression<Func<T, bool>> expression, IEnumerable<string> includes);
        IQueryable<T> SelectAll(Expression<Func<T, bool>> expression, IEnumerable<string> includes);
        ValueTask SaveAsync();
    }
}
