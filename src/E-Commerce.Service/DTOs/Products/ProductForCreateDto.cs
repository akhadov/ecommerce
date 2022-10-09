using Microsoft.AspNetCore.Http;

namespace E_Commerce.Service.DTOs.Products
{
    public class ProductForCreateDto
    {
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public decimal Price { get; set; }
        public IFormFile Image { get; set; } = null!;
        public int ViewCount { get; set; }
        public int CountInStock { get; set; }
        public decimal? Rating { get; set; }

        public long CategoryId { get; set; }
    }
}
