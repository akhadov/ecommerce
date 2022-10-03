using E_Commerce.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Commons
{
    public abstract class Auditable
    {
        public long Id { get; set; }

        [JsonIgnore]
        public ItemState State { get; set; }

        [JsonIgnore]
        public DateTime CreatedAt { get; set; }

        [JsonIgnore]
        public DateTime? UpdatedAt { get; set; }
    }
}
