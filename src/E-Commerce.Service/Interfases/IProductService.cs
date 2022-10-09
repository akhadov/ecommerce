using E_Commerce.Domain.Configurations;
using E_Commerce.Domain.Entities.Products;
using E_Commerce.Service.DTOs.Products;
using System.Linq.Expressions;

namespace E_Commerce.Service.Interfases
{
    public interface IProductService
    {
        Task<Product> AddAsync(ProductForCreateDto dto);
        Task<Product> UpdateAsync(long id, ProductForCreateDto dto);
        Task<bool> DeleteAsync(Expression<Func<Product, bool>> expression);
        Task<Product> GetAsync(Expression<Func<Product, bool>> expression);
        Task<IEnumerable<Product>> GetAllAsync(PaginationParams @params, Expression<Func<Product, bool>> expression = null);
    }
}
