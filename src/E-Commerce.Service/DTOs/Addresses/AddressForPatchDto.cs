namespace E_Commerce.Service.DTOs.Addresses
{
    public class AddressForPatchDto
    {
        public string ShippingAddress { get; set; } = String.Empty;
        public string ShippingCity { get; set; } = String.Empty;
        public string ShippingCountry { get; set; } = String.Empty;
        public string PostalCode { get; set; } = String.Empty;
    }
}
