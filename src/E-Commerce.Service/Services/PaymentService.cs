using E_Commerce.Domain.Configurations;
using E_Commerce.Domain.Entities.Payments;
using E_Commerce.Service.DTOs.Payments;
using E_Commerce.Service.Interfases;
using System.Linq.Expressions;

namespace E_Commerce.Service.Services
{
    public class PaymentService : IPaymentService
    {
        public Task<Payment> AddAsync(PaymentForCreateDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Expression<Func<Payment, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Payment>> GetAllAsync(Expression<Func<Payment, bool>>? expression = null, PaginationParams? parameters = null)
        {
            throw new NotImplementedException();
        }

        public Task<PaymentForFullViewDto> GetAsync(Expression<Func<Payment, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<Payment> UpdateAsync(long id, PaymentForPutDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<Payment> UpdateAsync(long id, PaymentForPatchDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
