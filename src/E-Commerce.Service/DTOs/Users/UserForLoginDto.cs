using E_Commerce.Service.Extensions.Attributes;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Service.DTOs.Users
{
    public class UserForLoginDto
    {

        [Required, Email] public string Email { get; set; } = String.Empty;
        [Required, StrongPassword] public string Password { get; set; } = String.Empty;
    }
}
