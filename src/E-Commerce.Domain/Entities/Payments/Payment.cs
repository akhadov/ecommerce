using E_Commerce.Domain.Commons;
using E_Commerce.Domain.Enums;

namespace E_Commerce.Domain.Entities.Payments
{
    public class Payment : Auditable
    {
        public PaymentType PaymentType { get; set; }
        public PaymentState PaymentState { get; set; }
    }
}
