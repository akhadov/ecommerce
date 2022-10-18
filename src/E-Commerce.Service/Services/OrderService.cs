using E_Commerce.Domain.Configurations;
using E_Commerce.Domain.Entities.Orders;
using E_Commerce.Service.DTOs.Orders;
using E_Commerce.Service.Interfases;
using System.Linq.Expressions;

namespace E_Commerce.Service.Services
{
    public class OrderService : IOrderService
    {
        public Task<Order> AddAsync(long userId, long paymentId, long addressId, OrderForCreateDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Expression<Func<Order, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Order>> GetAllAsync(Expression<Func<Order, bool>>? expression = null, PaginationParams? parameters = null)
        {
            throw new NotImplementedException();
        }

        public Task<OrderForFullViewDto> GetAsync(Expression<Func<Order, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<Order> UpdateAsync(long id, OrderForPutDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<Order> UpdateAsync(long id, OrderForPatchDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
