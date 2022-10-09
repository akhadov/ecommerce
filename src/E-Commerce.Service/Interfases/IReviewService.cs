using E_Commerce.Domain.Configurations;
using E_Commerce.Domain.Entities.Products;
using E_Commerce.Service.DTOs.Products;
using System.Linq.Expressions;

namespace E_Commerce.Service.Interfases
{
    public interface IReviewService
    {
        Task<Review> AddAsync(ReviewForCreateDto dto);
        Task<Review> UpdateAsync(long id, ReviewForCreateDto dto);
        Task<bool> DeleteAsync(Expression<Func<Review, bool>> expression);
        Task<Review> GetAsync(Expression<Func<Review, bool>> expression);
        Task<IEnumerable<Review>> GetAllAsync(PaginationParams @params, Expression<Func<Review, bool>> expression = null);
    }
}
