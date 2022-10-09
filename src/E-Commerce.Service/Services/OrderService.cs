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
    public class OrderService : IOrderService
    {
        public Task<Order> AddAsync(OrderForCreateDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Expression<Func<Order, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Order>> GetAllAsync(PaginationParams @params, Expression<Func<Order, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public Task<Order> GetAsync(Expression<Func<Order, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<Order> UpdateAsync(long id, OrderForCreateDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
