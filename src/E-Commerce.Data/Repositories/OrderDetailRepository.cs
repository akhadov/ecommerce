using E_Commerce.Data.DbContexts;
using E_Commerce.Data.IRepositories;
using E_Commerce.Domain.Entities.Orders;

namespace E_Commerce.Data.Repositories
{
    public class OrderDetailRepository : GenericRepository<OrderDetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
