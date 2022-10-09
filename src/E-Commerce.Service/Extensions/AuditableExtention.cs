using E_Commerce.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Service.Extensions
{
    public static class AuditableExtensions
    {
        public static void Update(this Auditable auditable)
        {
            auditable.UpdatedAt = DateTime.UtcNow;
            //auditable.UpdatedBy = HttpContextHelper.UserId;
        }

        public static void Delete(this Auditable auditable)
        {
            auditable.UpdatedAt = DateTime.UtcNow;
            //auditable.DeletedBy = HttpContextHelper.UserId;
        }
    }
}
