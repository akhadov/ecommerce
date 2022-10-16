using E_Commerce.Domain.Enums;

namespace E_Commerce.Service.DTOs.Payments
{
    public class PaymentForPatchDto
    {
        public PaymentType PaymentType { get; set; }
        public PaymentState PaymentState { get; set; }
    }
}
