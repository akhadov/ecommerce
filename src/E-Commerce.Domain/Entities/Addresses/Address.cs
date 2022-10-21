using E_Commerce.Domain.Commons;

namespace E_Commerce.Domain.Entities.Addresses
{
    public class Address : Auditable
    {
        public string ShippingAddress { get; set; } = String.Empty;
        public string ShippingCity { get; set; } = String.Empty;
        public string ShippingCountry { get; set; } = String.Empty;
        public string PostalCode { get; set; }

    }
}
