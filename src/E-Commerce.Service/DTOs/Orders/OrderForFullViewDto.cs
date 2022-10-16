using E_Commerce.Domain.Entities.Addresses;
using E_Commerce.Domain.Entities.Orders;
using E_Commerce.Domain.Entities.Payments;
using E_Commerce.Domain.Entities.Users;
using E_Commerce.Domain.Enums;

namespace E_Commerce.Service.DTOs.Orders
{
    public class OrderForFullViewDto
    {
        public long Id { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal ShippingPrice { get; set; }

        public long UserId { get; set; }
        public User? User { get; set; }

        public long PaymentId { get; set; }
        public Payment Payment { get; set; } = null!;

        public long AddressId { get; set; }
        public Address Address { get; set; } = null!;

        public DeliveryState DeliveryState { get; set; }

        ICollection<OrderDetail>? OrderDetails { get; set; }
    }
}
