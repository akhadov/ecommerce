using E_Commerce.Domain.Configurations;
using E_Commerce.Domain.Entities.Products;
using E_Commerce.Service.DTOs.Products;
using E_Commerce.Service.Interfases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Service.Services
{
    public class ReviewService : IReviewService
    {
        public Task<Review> AddAsync(ReviewForCreateDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Expression<Func<Review, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Review>> GetAllAsync(PaginationParams @params, Expression<Func<Review, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public Task<Review> GetAsync(Expression<Func<Review, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<Review> UpdateAsync(long id, ReviewForCreateDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
