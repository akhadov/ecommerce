using System.Linq.Expressions;

namespace E_Commerce.Data.IRepositories
{
#nullable disable
    public interface IGenericRepository<TSource> where TSource : class
    {
        IQueryable<TSource> GetAll(Expression<Func<TSource, bool>> expression = null, string include = null, bool isTracking = true);
        Task<TSource> AddAsync(TSource entity);
        Task<TSource> GetAsync(Expression<Func<TSource, bool>> expression = null, string include = null);
        Task<TSource> UpdateAsync(TSource entity);
        Task DeleteAsync(Expression<Func<TSource, bool>> expression);
    }
}
