namespace E_Commerce.Service.DTOs.Orders
{
    public class OrderDetailForCreateDto
    {
        public ushort ProductCount { get; set; }
        public long UserId { get; set; }
        public long ProductId { get; set; }
    }
}
