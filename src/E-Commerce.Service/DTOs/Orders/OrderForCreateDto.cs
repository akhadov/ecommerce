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
