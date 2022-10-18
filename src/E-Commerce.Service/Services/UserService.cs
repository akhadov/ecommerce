using AutoMapper;
using E_Commerce.Data.IRepositories;
using E_Commerce.Domain.Configurations;
using E_Commerce.Domain.Entities.Users;
using E_Commerce.Service.DTOs.Users;
using E_Commerce.Service.Interfases;
using System.Linq.Expressions;

namespace E_Commerce.Service.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UserService(IUnitOfWork unitOfwork, IMapper mapper)
        {
            this._unitOfWork = unitOfwork;
            this._mapper = mapper;
        }

        public Task<bool> DeleteAsync(Expression<Func<User, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAllAsync(Expression<Func<User, bool>>? expression = null, PaginationParams? parameters = null)
        {
            throw new NotImplementedException();
        }

        public Task<UserFullViewDto?> GetAsync(Expression<Func<User, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<User> UpdateAsync(long id, UserPutDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<User> UpdateAsync(long id, UserPatchDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
