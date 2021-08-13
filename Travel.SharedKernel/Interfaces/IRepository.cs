using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Travel.SharedKernel.Interfaces
{
    public interface IRepository
    {
        T GetById<T>(Expression<Func<T, bool>> filter, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, params string[] includeProperties) where T : class;

        Task<T> GetByIdAsync<T>(Expression<Func<T, bool>> filter, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, params string[] includeProperties) where T : class;

        T[] GetCollection<T>(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, params string[] includeProperties) where T : class;

        Task<T[]> GetCollectionAsync<T>(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, params string[] includeProperties) where T : class;

        T[] List<T>() where T : class;

        Task<T[]> ListAsync<T>() where T : class;
    }
}
