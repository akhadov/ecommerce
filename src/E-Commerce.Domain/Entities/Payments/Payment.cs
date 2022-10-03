using E_Commerce.Domain.Commons;
using E_Commerce.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Entities.Payments
{
    public class Payment : Auditable
    {
        public PaymentType PaymentType { get; set; }
        public PaymentState PaymentState { get; set; }
    }
}
