using E_Commerce.Data.DbContexts;
using E_Commerce.Data.IRepositories;

namespace E_Commerce.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _dbContext;

        public UnitOfWork(AppDbContext dbContext)
        {
            this._dbContext = dbContext;
            Addresses = new AddressRepository(dbContext);
            Categories = new CategoryRepository(dbContext);
            OrderDetails = new OrderDetailRepository(dbContext);
            Orders = new OrderRepository(dbContext);
            Payments = new PaymentRepository(dbContext);
            Products = new ProductRepository(dbContext);
            Reviews = new ReviewRepository(dbContext);
            Users = new UserRepository(dbContext);
        }
        public IAddressRepository Addresses { get; }

        public ICategoryRepository Categories { get; }

        public IOrderDetailRepository OrderDetails { get; }

        public IOrderRepository Orders { get; }

        public IPaymentRepository Payments { get; }

        public IProductRepository Products { get; }

        public IReviewRepository Reviews { get; }

        public IUserRepository Users { get; }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
