﻿using E_Commerce.Domain.Entities.Products;

namespace E_Commerce.Service.DTOs.Products
{
    public class ProductForFullViewDto
    {
        public long Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public decimal Price { get; set; }
        public string ImagePath { get; set; } = String.Empty;
        public int ViewCount { get; set; }
        public int CountInStock { get; set; }
        public decimal? Rating { get; set; }

        public long CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
