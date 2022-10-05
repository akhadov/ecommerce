using E_Commerce.Domain.Commons;
using E_Commerce.Domain.Enums;

namespace E_Commerce.Domain.Entities.Users
{
    public class User : Auditable
    {
        public string Name { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public string Password { get; set; } = String.Empty;

        public UserRole UserRole { get; set; }

    }
}
