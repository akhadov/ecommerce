using E_Commerce.Domain.Configurations;
using E_Commerce.Domain.Entities.Users;
using E_Commerce.Service.DTOs.Users;
using E_Commerce.Service.Interfases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Service.Services
{
    public class UserService : IUserService
    {
        public Task<User> AddAsync(UserForCreateDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Expression<Func<User, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAllAsync(PaginationParams @params, Expression<Func<User, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetAsync(Expression<Func<User, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<User> UpdateAsync(long id, UserForCreateDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
