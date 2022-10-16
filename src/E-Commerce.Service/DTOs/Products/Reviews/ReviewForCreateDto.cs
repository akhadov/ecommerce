namespace E_Commerce.Service.DTOs.Products.Reviews
{
    public class ReviewForCreateDto
    {
        public decimal Rating { get; set; }
        public string Comment { get; set; } = string.Empty;
        public long ProductId { get; set; }
        public long UserId { get; set; }
    }
}
