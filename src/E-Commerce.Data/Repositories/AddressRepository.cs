using E_Commerce.Data.DbContexts;
using E_Commerce.Data.IRepositories;
using E_Commerce.Domain.Entities.Addresses;

namespace E_Commerce.Data.Repositories
{
    public class AddressRepository : GenericRepository<Address>, IAddressRepository
    {
        public AddressRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
