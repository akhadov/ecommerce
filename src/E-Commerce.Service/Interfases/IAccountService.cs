using E_Commerce.Service.DTOs.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Service.Interfases
{
    public interface IAccountService
    {
        Task<string> LoginAsync(UserForLoginDto dto);
        Task<string> RegisterAsync(UserForCreateDto dto);
        Task SendVerificationCodeAsync(string email);
        Task<bool> VerifyCodeAsync(string email, string code);
    }
}
