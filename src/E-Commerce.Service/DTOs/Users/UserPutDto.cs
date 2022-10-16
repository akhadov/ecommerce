using E_Commerce.Service.Extensions.Attributes;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Service.DTOs.Users
{
    public class UserPutDto
    {
        [Required, Name]
        public string Name { get; set; } = String.Empty;

        [Required, Email]
        public string Email { get; set; } = String.Empty;
    }
}
