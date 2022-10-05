using E_Commerce.Domain.Commons;

namespace E_Commerce.Domain.Entities.Products
{
    public class Category : Auditable
    {
        public string Name { get; set; } = String.Empty;
    }
}
