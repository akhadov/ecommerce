namespace E_Commerce.Service.DTOs.Products
{
    public class ReviewForCreateDto
    {
        public decimal Rating { get; set; }
        public string Comment { get; set; } = String.Empty;
        public long ProductId { get; set; }
        public long UserId { get; set; }
    }
}
