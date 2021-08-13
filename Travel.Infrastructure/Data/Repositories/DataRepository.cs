using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Travel.SharedKernel;
using Travel.SharedKernel.Interfaces;

namespace Travel.Infrastructure.Data.Repositories
{
    public class DataRepository : IRepository
    {
        private readonly ApplicationDbContext _context;

        public DataRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        private IQueryable<T> GetQuery<T>(Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, params string[] includeProperties)
            where T : class
        {
            IQueryable<T> query = _context.Set<T>();

            query = includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));

            return orderBy == null ? query : orderBy.Invoke(query);
        }

        public T GetById<T>(Expression<Func<T, bool>> filter, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, params string[] includeProperties)
            where T : class
        {
            return GetQuery(orderBy, includeProperties).FirstOrDefault(filter);
        }

        public Task<T> GetByIdAsync<T>(Expression<Func<T, bool>> filter, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, params string[] includeProperties)
            where T : class
        {
            return GetQuery(orderBy, includeProperties).FirstOrDefaultAsync(filter);
        }

        private IQueryable<T> GetQuery<T>(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, params string[] includeProperties)
            where T : class
        {
            IQueryable<T> query = GetQuery(orderBy, includeProperties);

            if (filter != null)
            {
                query = query.Where(filter);
            }

            return query;
        }

        public T[] GetCollection<T>(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, params string[] includeProperties)
            where T : class
        {
            return GetQuery(filter, orderBy, includeProperties).ToArray();
        }

        public Task<T[]> GetCollectionAsync<T>(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, params string[] includeProperties)
            where T : class
        {
            return GetQuery(filter, orderBy, includeProperties).ToArrayAsync();
        }

        public T[] List<T>() where T : class
        {
            return _context.Set<T>().ToArray();
        }

        public Task<T[]> ListAsync<T>() where T : class
        {
            return _context.Set<T>().ToArrayAsync();
        }
    }
}
