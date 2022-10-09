using E_Commerce.Domain.Configurations;
using E_Commerce.Domain.Entities.Orders;
using E_Commerce.Service.DTOs.Orders;
using System.Linq.Expressions;

namespace E_Commerce.Service.Interfases
{
    public interface IOrderService
    {
        Task<Order> AddAsync(OrderForCreateDto dto);
        Task<Order> UpdateAsync(long id, OrderForCreateDto dto);
        Task<bool> DeleteAsync(Expression<Func<Order, bool>> expression);
        Task<Order> GetAsync(Expression<Func<Order, bool>> expression);
        Task<IEnumerable<Order>> GetAllAsync(PaginationParams @params, Expression<Func<Order, bool>> expression = null);
    }
}
