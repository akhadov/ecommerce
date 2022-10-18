using E_Commerce.Domain.Configurations;
using E_Commerce.Domain.Entities.Orders;
using E_Commerce.Service.DTOs.Orders.OrderDetails;
using System.Linq.Expressions;

namespace E_Commerce.Service.Interfases
{
    internal interface IOrderDetailService
    {
        Task<OrderDetail> AddAsync(long userId, long productId, OrderDetailForCreateDto dto);
        Task<OrderDetail> UpdateAsync(long id, OrderDetailForPutDto dto);
        Task<OrderDetail> UpdateAsync(long id, OrderDetailForPatchDto dto);
        Task<bool> DeleteAsync(Expression<Func<OrderDetail, bool>> expression);
        Task<OrderDetailForFullViewDto> GetAsync(Expression<Func<OrderDetail, bool>> expression);
        Task<IEnumerable<OrderDetail>> GetAllAsync(Expression<Func<OrderDetail, bool>>? expression = null,
        PaginationParams? parameters = null);
    }
}
