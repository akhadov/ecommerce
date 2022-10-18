using E_Commerce.Domain.Configurations;
using E_Commerce.Domain.Entities.Products;
using E_Commerce.Service.DTOs.Products.Reviews;
using System.Linq.Expressions;

namespace E_Commerce.Service.Interfases
{
    public interface IReviewService
    {
        Task<Review> AddAsync(long userId, long productId, ReviewForCreateDto dto);
        Task<Review> UpdateAsync(long id, ReviewForPutDto dto);
        Task<Review> UpdateAsync(long id, ReviewForPatchDto dto);
        Task<bool> DeleteAsync(Expression<Func<Review, bool>> expression);
        Task<ReviewForFullViewDto> GetAsync(Expression<Func<Review, bool>> expression);
        Task<IEnumerable<Review>> GetAllAsync(Expression<Func<Review, bool>>? expression = null,
        PaginationParams? parameters = null);
    }
}
