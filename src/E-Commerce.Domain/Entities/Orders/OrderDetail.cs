using E_Commerce.Domain.Commons;
using E_Commerce.Domain.Entities.Products;
using E_Commerce.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Entities.Orders
{
    public class OrderDetail : Auditable
    {
        public ushort ProductCount { get; set; }

        public long UserId { get; set; }
        public User? User { get; set; }

        public long ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
