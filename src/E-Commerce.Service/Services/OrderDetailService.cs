using E_Commerce.Domain.Configurations;
using E_Commerce.Domain.Entities.Orders;
using E_Commerce.Service.DTOs.Orders.OrderDetails;
using E_Commerce.Service.Interfases;
using System.Linq.Expressions;

namespace E_Commerce.Service.Services
{
    public class OrderDetailService : IOrderDetailService
    {
        public Task<OrderDetail> AddAsync(long userId, long productId, OrderDetailForCreateDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Expression<Func<OrderDetail, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<OrderDetail>> GetAllAsync(Expression<Func<OrderDetail, bool>>? expression = null, PaginationParams? parameters = null)
        {
            throw new NotImplementedException();
        }

        public Task<OrderDetailForFullViewDto> GetAsync(Expression<Func<OrderDetail, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<OrderDetail> UpdateAsync(long id, OrderDetailForPutDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<OrderDetail> UpdateAsync(long id, OrderDetailForPatchDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
