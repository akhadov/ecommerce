using E_Commerce.Data.DbContexts;
using E_Commerce.Data.IRepositories;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace E_Commerce.Data.Repositories
{
#nullable disable
    public class GenericRepository<TSource> : IGenericRepository<TSource> where TSource : class
    {
        private readonly AppDbContext _dbContext;
        private readonly DbSet<TSource> _dbSet;

        public GenericRepository(AppDbContext dbContext)
        {
            this._dbContext = dbContext;
            _dbSet = dbContext.Set<TSource>();
        }
        public IQueryable<TSource> GetAll(Expression<Func<TSource, bool>> expression = null, string include = null, bool isTracking = true)
        {
            IQueryable<TSource> query = expression is null ? _dbSet : _dbSet.Where(expression);

            if (!string.IsNullOrEmpty(include))
                query = query.Include(include);

            if (!isTracking)
                query = query.AsNoTracking();

            return query;
        }
        public async Task<TSource> AddAsync(TSource entity)
        {
            var entry = await _dbSet.AddAsync(entity);

            return entry.Entity;
        }
        public async Task<TSource> GetAsync(Expression<Func<TSource, bool>> expression = null, string include = null)
            => await GetAll(expression, include).FirstOrDefaultAsync();


        public async Task<TSource> UpdateAsync(TSource entity)
            => _dbSet.Update(entity).Entity;

        public async Task DeleteAsync(Expression<Func<TSource, bool>> expression)
        {
            var entity = await GetAsync(expression);

            _dbSet.Remove(entity);
        }
    }
}
