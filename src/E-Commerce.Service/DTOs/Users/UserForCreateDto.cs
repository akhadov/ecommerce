using E_Commerce.Service.Extensions.Attributes;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Service.DTOs.Users
{
    public class UserForCreateDto
    {
        [Required(ErrorMessage = "First name is required"), Name]
        [MaxLength(50), MinLength(2)]
        public string Name { get; set; } = String.Empty;

        [Required, Email]
        public string Email { get; set; } = String.Empty;

        [Required(ErrorMessage = "Password is required"), MaxLength(50), MinLength(8), StrongPassword]
        public string Password { get; set; } = String.Empty;
    }
}
