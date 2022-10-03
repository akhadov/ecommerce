using E_Commerce.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Entities.Products
{
    public class Product : Auditable
    {
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
