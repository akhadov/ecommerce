using E_Commerce.Service.DTOs.Users;
using E_Commerce.Service.Interfases;

namespace E_Commerce.Service.Services
{
    public class AccountService : IAccountService
    {
        public Task<string> LoginAsync(UserForLoginDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<string> RegisterAsync(UserForCreateDto dto)
        {
            throw new NotImplementedException();
        }

        public Task SendVerificationCodeAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<bool> VerifyCodeAsync(string email, string code)
        {
            throw new NotImplementedException();
        }
    }
}
