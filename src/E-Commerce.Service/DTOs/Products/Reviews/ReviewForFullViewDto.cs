using E_Commerce.Domain.Entities.Products;
using E_Commerce.Domain.Entities.Users;

namespace E_Commerce.Service.DTOs.Products.Reviews
{
    public class ReviewForFullViewDto
    {
        public long Id { get; set; }
        public decimal Rating { get; set; }
        public string Comment { get; set; } = String.Empty;

        public long ProductId { get; set; }
        public Product? Product { get; set; }

        public long UserId { get; set; }
        public User? User { get; set; }
    }
}
