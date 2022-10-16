namespace E_Commerce.Service.DTOs.Orders.OrderDetails
{
    public class OrderDetailForCreateDto
    {
        public ushort ProductCount { get; set; }
        public long UserId { get; set; }
        public long ProductId { get; set; }
    }
}
