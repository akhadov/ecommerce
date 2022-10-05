using E_Commerce.Data.DbContexts;
using E_Commerce.Data.IRepositories;
using E_Commerce.Domain.Entities.Payments;

namespace E_Commerce.Data.Repositories
{
    public class PaymentRepository : GenericRepository<Payment>, IPaymentRepository
    {
        public PaymentRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
