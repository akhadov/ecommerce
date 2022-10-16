using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Service.DTOs.Addresses
{
    public class AddressForCreateDto
    {
        [Required] public string ShippingAddress { get; set; } = String.Empty;
        [Required] public string ShippingCity { get; set; } = String.Empty;
        [Required] public string ShippingCountry { get; set; } = String.Empty;
        public uint PostalCode { get; set; }
    }
}
