using E_Commerce.Domain.Commons;

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
