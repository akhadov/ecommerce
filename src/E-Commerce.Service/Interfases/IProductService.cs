using E_Commerce.Domain.Configurations;
using E_Commerce.Domain.Entities.Products;
using E_Commerce.Service.DTOs.Products;
using System.Linq.Expressions;

namespace E_Commerce.Service.Interfases
{
    public interface IProductService
    {
        Task<Product> AddAsync(long categoryId, ProductForCreateDto dto);
        Task<Product> UpdateAsync(long id, ProductForPutDto dto);
        Task<Product> UpdateAsync(long id, ProductForPatchDto dto);
        Task<bool> DeleteAsync(Expression<Func<Product, bool>> expression);
        Task<ProductForFullViewDto> GetAsync(Expression<Func<Product, bool>> expression);
        Task<IEnumerable<Product>> GetAllAsync(Expression<Func<Product, bool>>? expression = null,
        PaginationParams? parameters = null);
    }
}
