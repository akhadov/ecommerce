using E_Commerce.Domain.Configurations;
using E_Commerce.Domain.Entities.Products;
using E_Commerce.Service.DTOs.Products.Categories;
using System.Linq.Expressions;

namespace E_Commerce.Service.Interfases
{
    public interface ICategoryService
    {
        Task<Category> AddAsync(CategoryForCreateDto dto);
        Task<Category> UpdateAsync(long id, CategoryForCreateDto dto);
        Task<bool> DeleteAsync(Expression<Func<Category, bool>> expression);
        Task<Category> GetAsync(Expression<Func<Category, bool>> expression);
        Task<IEnumerable<Category>> GetAllAsync(PaginationParams @params, Expression<Func<Category, bool>> expression = null);
    }
}
