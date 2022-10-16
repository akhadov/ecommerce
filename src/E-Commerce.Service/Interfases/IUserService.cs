using E_Commerce.Domain.Configurations;
using E_Commerce.Domain.Entities.Users;
using E_Commerce.Service.DTOs.Users;
using System.Linq.Expressions;

namespace E_Commerce.Service.Interfases
{
    public interface IUserService
    {
        Task<User> UpdateAsync(long id, UserPutDto dto);
        Task<User> UpdateAsync(long id, UserPatchDto dto);
        Task<bool> DeleteAsync(Expression<Func<User, bool>> expression);
        Task<UserFullViewDto?> GetAsync(Expression<Func<User, bool>> expression);
        Task<IEnumerable<User>> GetAllAsync(Expression<Func<User, bool>>? expression = null,
            PaginationParams? parameters = null);
    }
}
