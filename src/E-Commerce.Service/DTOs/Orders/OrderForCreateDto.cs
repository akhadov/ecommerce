using E_Commerce.Domain.Entities.Addresses;
using E_Commerce.Domain.Entities.Payments;
using E_Commerce.Domain.Entities.Users;
using E_Commerce.Domain.Enums;

namespace E_Commerce.Service.DTOs.Orders
{
    public class OrderForCreateDto
    {
        public decimal TotalPrice { get; set; }
        public decimal ShippingPrice { get; set; }
        public long UserId { get; set; }
        public long PaymentId { get; set; }
        public long AddressId { get; set; }
    }
}
