using E_Commerce.Domain.Commons;
using E_Commerce.Domain.Entities.Users;

namespace E_Commerce.Domain.Entities.Products
{
    public class Review : Auditable
    {
        public decimal Rating { get; set; }
        public string Comment { get; set; } = String.Empty;

        public long ProductId { get; set; }
        public Product? Product { get; set; }

        public long UserId { get; set; }
        public User? User { get; set; }
    }
}
