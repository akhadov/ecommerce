using E_Commerce.Service.DTOs.Users;

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
