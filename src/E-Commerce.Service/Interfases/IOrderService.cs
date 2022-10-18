using E_Commerce.Domain.Configurations;
using E_Commerce.Domain.Entities.Orders;
using E_Commerce.Service.DTOs.Orders;
using System.Linq.Expressions;

namespace E_Commerce.Service.Interfases
{
    public interface IOrderService
    {
        Task<Order> AddAsync(long userId, long paymentId, long addressId, OrderForCreateDto dto);
        Task<Order> UpdateAsync(long id, OrderForPutDto dto);
        Task<Order> UpdateAsync(long id, OrderForPatchDto dto);
        Task<bool> DeleteAsync(Expression<Func<Order, bool>> expression);
        Task<OrderForFullViewDto> GetAsync(Expression<Func<Order, bool>> expression);
        Task<IEnumerable<Order>> GetAllAsync(Expression<Func<Order, bool>>? expression = null,
        PaginationParams? parameters = null);
    }
}
