using E_Commerce.Domain.Commons;
using E_Commerce.Domain.Entities.Addresses;
using E_Commerce.Domain.Entities.Products;
using E_Commerce.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Entities.Orders
{
    public class Order : Auditable
    { 

        public decimal Total { get; set; }

        public long UserId { get; set; }
        public User? User { get; set; }

        public long AddressId { get; set; }
        public Address Address { get; set; } = null!;

        ICollection<OrderDetail>? OrderDetails { get; set; }
    }
}
