using E_Commerce.Domain.Entities.Products;
using E_Commerce.Domain.Entities.Users;

namespace E_Commerce.Service.DTOs.Orders.OrderDetails
{
    public class OrderDetailForFullViewDto
    {
        public long Id { get; set; }
        public ushort ProductCount { get; set; }

        public long UserId { get; set; }
        public User? User { get; set; }

        public long ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
