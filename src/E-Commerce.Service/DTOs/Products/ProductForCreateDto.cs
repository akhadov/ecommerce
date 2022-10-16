﻿using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Service.DTOs.Products
{
    public class ProductForCreateDto
    {
        [Required]
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        [Required]
        public decimal Price { get; set; }
        public IFormFile Image { get; set; } = null!;
        [Required]
        public int ViewCount { get; set; }
        [Required]
        public int CountInStock { get; set; }
        public decimal? Rating { get; set; }

        public long CategoryId { get; set; }
    }
}
