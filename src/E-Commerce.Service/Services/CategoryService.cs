using E_Commerce.Domain.Configurations;
using E_Commerce.Domain.Entities.Products;
using E_Commerce.Service.DTOs.Products;
using E_Commerce.Service.Interfases;
using System.Linq.Expressions;

namespace E_Commerce.Service.Services
{
    public class CategoryService : ICategoryService
    {
        public Task<Category> AddAsync(CategoryForCreateDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Expression<Func<Category, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Category>> GetAllAsync(PaginationParams @params, Expression<Func<Category, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetAsync(Expression<Func<Category, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<Category> UpdateAsync(long id, CategoryForCreateDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
