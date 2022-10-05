using E_Commerce.Data.DbContexts;
using E_Commerce.Data.IRepositories;
using E_Commerce.Domain.Entities.Users;

namespace E_Commerce.Data.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
