﻿namespace E_Commerce.Service.DTOs.Addresses
{
    public class AddressForCreation
    {
        public string ShippingAddress { get; set; } = String.Empty;
        public string ShippingCity { get; set; } = String.Empty;
        public string ShippingCountry { get; set; } = String.Empty;
        public uint PostalCode { get; set; }
    }
}