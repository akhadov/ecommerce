using E_Commerce.Domain.Configurations;
using E_Commerce.Domain.Entities.Products;
using E_Commerce.Service.DTOs.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

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
