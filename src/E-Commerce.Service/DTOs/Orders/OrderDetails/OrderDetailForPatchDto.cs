namespace E_Commerce.Service.DTOs.Orders.OrderDetails
{
    public class OrderDetailForPatchDto
    {
        public ushort ProductCount { get; set; }
        public long UserId { get; set; }
        public long ProductId { get; set; }
    }
}
