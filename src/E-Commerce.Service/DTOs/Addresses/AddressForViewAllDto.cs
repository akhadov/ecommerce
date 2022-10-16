namespace E_Commerce.Service.DTOs.Addresses
{
    public class AddressForViewAllDto
    {
        public long Id { get; set; }
        public string ShippingAddress { get; set; } = String.Empty;
        public string ShippingCity { get; set; } = String.Empty;
        public string ShippingCountry { get; set; } = String.Empty;
        public uint PostalCode { get; set; }
    }
}
