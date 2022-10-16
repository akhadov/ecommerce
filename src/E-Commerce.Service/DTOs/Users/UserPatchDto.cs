using E_Commerce.Service.Extensions.Attributes;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Service.DTOs.Users
{
    public class UserPatchDto
    {
        [Required, Name]
        public string? Name { get; set; }

        [Required, Email]
        public string? Email { get; set; }
    }
}
