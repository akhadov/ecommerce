using AutoMapper;
using E_Commerce.Data.IRepositories;
using E_Commerce.Domain.Configurations;
using E_Commerce.Domain.Entities.Users;
using E_Commerce.Domain.Enums;
using E_Commerce.Service.DTOs.Users;
using E_Commerce.Service.Exceptions;
using E_Commerce.Service.Extensions;
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

        public async Task<bool> DeleteAsync(Expression<Func<User, bool>> expression)
        {
            var user = await _unitOfWork.Users.GetAsync(expression);
            if (user is null)
                throw new NotFoundException("User");

            user.State = ItemState.Deleted;
            user.Update();

            await _unitOfWork.SaveChangesAsync();

            return true;
        }

        public Task<IEnumerable<User>> GetAllAsync(Expression<Func<User, bool>>? expression = null, PaginationParams? parameters = null)
        {
            return Task.FromResult<IEnumerable<User>>(
            (expression is null ? _unitOfWork.Users.GetAll(expression, isTracking: false) : _unitOfWork.Users.GetAll(expression, isTracking: false))
            .ToPagedAsQueryable(parameters)); //.Where(expression))
        }

        public async Task<UserFullViewDto?> GetAsync(Expression<Func<User, bool>> expression)
        {
            var user = await _unitOfWork.Users.GetAsync(expression);
            if (user is null)
                throw new NotFoundException("User");

            return _mapper.Map<UserFullViewDto>(user);
        }

        public async Task<User> UpdateAsync(long id, UserPutDto dto)
        {
            var user = await _unitOfWork.Users.GetAsync(p => p.Id == id && p.State != ItemState.Deleted);
            if (user is null)
                throw new NotFoundException("User");

            user = _mapper.Map(dto, user);

            user.State = ItemState.Updated;
            user.Update();

            user = await _unitOfWork.Users.UpdateAsync(user);

            await _unitOfWork.SaveChangesAsync();

            return user;
        }

        public async Task<User> UpdateAsync(long id, UserPatchDto dto)
        {
            var user = await _unitOfWork.Users.GetAsync(p => p.Id == id && p.State != ItemState.Deleted);
            if (user is null)
                throw new NotFoundException("User");

            if (dto.Name is not null)
                user.Name = dto.Name;
            if (dto.Email is not null)
                user.Email = dto.Email;

            user.State = ItemState.Updated;
            user.Update();

            user = await _unitOfWork.Users.UpdateAsync(user);

            await _unitOfWork.SaveChangesAsync();

            return user;
        }
    }
}
