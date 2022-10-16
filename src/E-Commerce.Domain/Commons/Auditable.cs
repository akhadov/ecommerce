using E_Commerce.Domain.Enums;
using System.Text.Json.Serialization;

namespace E_Commerce.Domain.Commons
{
    public abstract class Auditable
    {
        public long Id { get; set; }

        [JsonIgnore] public ItemState State { get; set; }
        [JsonIgnore] public DateTime CreatedAt { get; set; }
        [JsonIgnore] public DateTime? UpdatedAt { get; set; }
    }
}
