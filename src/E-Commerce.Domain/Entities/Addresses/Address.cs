using E_Commerce.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Entities.Addresses
{
    public class Address : Auditable
    {
        public string ShippingAddress { get; set; } = String.Empty;
        public string ShippingCity { get; set; } = String.Empty;
        public string ShippingCountry { get; set; } = String.Empty;

        public uint PostalCode { get; set; }

    }
}
