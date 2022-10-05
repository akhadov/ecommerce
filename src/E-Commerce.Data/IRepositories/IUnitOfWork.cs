using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Data.IRepositories
{
    public interface IUnitOfWork : IDisposable
    {
        IAddressRepository Addresses { get; }
        ICategoryRepository Categories { get; }
        IOrderDetailRepository OrderDetails { get; }
        IOrderRepository Orders { get; }
        IPaymentRepository Payments { get; }
        IProductRepository Products { get; }
        IReviewRepository Reviews { get; }
        IUserRepository Users { get; }
        Task SaveChangesAsync();
    }
}
