using Authorization.Data.Contexts;
using Authorization.Data.IRepositories;
using Authorization.Domain.Commons;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;

namespace Authorization.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : Auditable
    {
        private readonly AuthorizationDbContext context;
        private readonly DbSet<T> dbSet;

        public Repository(AuthorizationDbContext context)
        {
            this.context = context;
            this.dbSet = context.Set<T>();
        }


        public bool Delete(T entity)
        {
            dbSet.Remove(entity);
            return true;
        }

        public ValueTask<T> InsertAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public async ValueTask SaveAsync()
            => await context.SaveChangesAsync();

        public IQueryable<T> SelectAll(Expression<Func<T, bool>> expression, IEnumerable<string> includes)
        {
            IQueryable<T> query = expression is null ? dbSet : dbSet.Where(expression);

            if (includes is not null)
                foreach (var include in includes)
                    query = query.Include(include);

            return query;
        }

        public async ValueTask<T> SelectAsync(Expression<Func<T, bool>> expression, IEnumerable<string> includes)
            => await this.SelectAll(expression, includes).FirstOrDefaultAsync();

        public T UpdateAsync(T entity)
        {
            EntityEntry<T> entryentity = this.context.Update(entity);

            return entryentity.Entity;
        }
    }
}
