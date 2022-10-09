using E_Commerce.Domain.Configurations;
using E_Commerce.Domain.Entities.Orders;
using E_Commerce.Domain.Entities.Products;
using E_Commerce.Service.DTOs.Orders;
using E_Commerce.Service.DTOs.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Service.Interfases
{
    internal interface IOrderDetailService
    {
        Task<OrderDetail> AddAsync(OrderDetailForCreateDto dto);
        Task<OrderDetail> UpdateAsync(long id, OrderDetailForCreateDto dto);
        Task<bool> DeleteAsync(Expression<Func<OrderDetail, bool>> expression);
        Task<OrderDetail> GetAsync(Expression<Func<OrderDetail, bool>> expression);
        Task<IEnumerable<OrderDetail>> GetAllAsync(PaginationParams @params, Expression<Func<OrderDetail, bool>> expression = null);
    }
}
