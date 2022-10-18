using E_Commerce.Domain.Configurations;
using E_Commerce.Domain.Entities.Products;
using E_Commerce.Service.DTOs.Products.Reviews;
using E_Commerce.Service.Interfases;
using System.Linq.Expressions;

namespace E_Commerce.Service.Services
{
    public class ReviewService : IReviewService
    {
        public Task<Review> AddAsync(long userId, long productId, ReviewForCreateDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Expression<Func<Review, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Review>> GetAllAsync(Expression<Func<Review, bool>>? expression = null, PaginationParams? parameters = null)
        {
            throw new NotImplementedException();
        }

        public Task<ReviewForFullViewDto> GetAsync(Expression<Func<Review, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<Review> UpdateAsync(long id, ReviewForPutDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<Review> UpdateAsync(long id, ReviewForPatchDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
