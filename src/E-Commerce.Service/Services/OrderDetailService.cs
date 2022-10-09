using E_Commerce.Domain.Configurations;
using E_Commerce.Domain.Entities.Orders;
using E_Commerce.Service.DTOs.Orders;
using E_Commerce.Service.Interfases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Service.Services
{
    public class OrderDetailService : IOrderDetailService
    {
        public Task<OrderDetail> AddAsync(OrderDetailForCreateDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Expression<Func<OrderDetail, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<OrderDetail>> GetAllAsync(PaginationParams @params, Expression<Func<OrderDetail, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public Task<OrderDetail> GetAsync(Expression<Func<OrderDetail, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<OrderDetail> UpdateAsync(long id, OrderDetailForCreateDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
