using E_Commerce.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Entities.Products
{
    public class Category : Auditable
    {
        public string Name { get; set; } = String.Empty;
    }
}
