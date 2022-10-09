using E_Commerce.Domain.Configurations;
using E_Commerce.Domain.Entities.Users;
using E_Commerce.Service.DTOs.Users;
using System.Linq.Expressions;

namespace E_Commerce.Service.Interfases
{
    public interface IUserService
    {
        Task<User> AddAsync(UserForCreateDto dto);
        Task<User> UpdateAsync(long id, UserForCreateDto dto);
        Task<bool> DeleteAsync(Expression<Func<User, bool>> expression);
        Task<User> GetAsync(Expression<Func<User, bool>> expression);
        Task<IEnumerable<User>> GetAllAsync(PaginationParams @params, Expression<Func<User, bool>> expression = null);
    }
}
