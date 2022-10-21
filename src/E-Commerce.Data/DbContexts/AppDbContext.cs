using E_Commerce.Domain.Entities.Addresses;
using E_Commerce.Domain.Entities.Orders;
using E_Commerce.Domain.Entities.Payments;
using E_Commerce.Domain.Entities.Products;
using E_Commerce.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Data.DbContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Review> Reviews { get; set; } = null!;
        public virtual DbSet<Payment> Payments { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<OrderDetail> OrderDetails { get; set; } = null!;
        public virtual DbSet<Address> Addresses { get; set; } = null!;
    }
}
