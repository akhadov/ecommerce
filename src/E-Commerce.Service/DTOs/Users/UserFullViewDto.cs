using E_Commerce.Domain.Entities.Orders;
using E_Commerce.Domain.Enums;

namespace E_Commerce.Service.DTOs.Users
{
    public class UserFullViewDto
    {
        public long Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;

        public UserRole UserRole { get; set; }
        public virtual ICollection<OrderDetail>? OrderDetails { get; set; }

    }
}
