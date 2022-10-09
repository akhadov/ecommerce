using E_Commerce.Domain.Configurations;
using E_Commerce.Domain.Entities.Payments;
using E_Commerce.Service.DTOs.Payments;
using System.Linq.Expressions;

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
