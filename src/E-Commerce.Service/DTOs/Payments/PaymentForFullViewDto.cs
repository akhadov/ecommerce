using E_Commerce.Domain.Enums;

namespace E_Commerce.Service.DTOs.Payments
{
    public class PaymentForFullViewDto
    {
        public long Id { get; set; }
        public PaymentType PaymentType { get; set; }
        public PaymentState PaymentState { get; set; }
    }
}
