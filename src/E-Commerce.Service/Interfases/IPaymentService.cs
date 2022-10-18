using E_Commerce.Domain.Configurations;
using E_Commerce.Domain.Entities.Payments;
using E_Commerce.Service.DTOs.Payments;
using System.Linq.Expressions;

namespace E_Commerce.Service.Interfases
{
    public interface IPaymentService
    {
        Task<Payment> AddAsync(PaymentForCreateDto dto);
        Task<Payment> UpdateAsync(long id, PaymentForPutDto dto);
        Task<Payment> UpdateAsync(long id, PaymentForPatchDto dto);
        Task<bool> DeleteAsync(Expression<Func<Payment, bool>> expression);
        Task<PaymentForFullViewDto> GetAsync(Expression<Func<Payment, bool>> expression);
        Task<IEnumerable<Payment>> GetAllAsync(Expression<Func<Payment, bool>>? expression = null,
        PaginationParams? parameters = null);
    }
}
