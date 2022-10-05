using E_Commerce.Data.DbContexts;
using E_Commerce.Data.IRepositories;
using E_Commerce.Domain.Entities.Products;

namespace E_Commerce.Data.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
