using E_Commerce.Domain.Configurations;
using E_Commerce.Domain.Entities.Payments;
using E_Commerce.Service.DTOs.Payments;
using E_Commerce.Service.Interfases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

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

        public Task<IEnumerable<Payment>> GetAllAsync(PaginationParams @params, Expression<Func<Payment, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public Task<Payment> GetAsync(Expression<Func<Payment, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<Payment> UpdateAsync(long id, PaymentForCreateDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
