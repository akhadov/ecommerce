using E_Commerce.Domain.Commons;

namespace E_Commerce.Service.Extensions
{
    public static class AuditableExtensions
    {
        public static void Create(this Auditable auditable)
        {
            auditable.CreatedAt = DateTime.UtcNow;
            //auditable.CreatedBy = HttpContextHelper.UserId;
        }

        public static void Update(this Auditable auditable)
        {
            auditable.UpdatedAt = DateTime.UtcNow;
            //auditable.UpdatedBy = HttpContextHelper.UserId;
        }

    }
}
