using E_Commerce.Domain.Configurations;
using E_Commerce.Domain.Entities.Payments;
using E_Commerce.Domain.Entities.Products;
using E_Commerce.Service.DTOs.Payments;
using E_Commerce.Service.DTOs.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Service.Interfases
{
    public interface IPaymentService
    {
        Task<Payment> AddAsync(PaymentForCreateDto dto);
        Task<Payment> UpdateAsync(long id, PaymentForCreateDto dto);
        Task<bool> DeleteAsync(Expression<Func<Payment, bool>> expression);
        Task<Payment> GetAsync(Expression<Func<Payment, bool>> expression);
        Task<IEnumerable<Payment>> GetAllAsync(PaginationParams @params, Expression<Func<Payment, bool>> expression = null);
    }
}
