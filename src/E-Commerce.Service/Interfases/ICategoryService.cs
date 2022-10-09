using E_Commerce.Domain.Configurations;
using E_Commerce.Domain.Entities.Addresses;
using E_Commerce.Domain.Entities.Products;
using E_Commerce.Service.DTOs.Addresses;
using E_Commerce.Service.DTOs.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

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
