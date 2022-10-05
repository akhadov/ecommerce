using E_Commerce.Domain.Enums;

namespace E_Commerce.Domain.Commons
{
    public abstract class Auditable
    {
        public long Id { get; set; }

        public ItemState State { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
