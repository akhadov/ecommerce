using Microsoft.AspNetCore.Http;

namespace E_Commerce.Service.Interfases
{
    public interface IFileService
    {
        public interface IFileService
        {
            public string ImageFolderName { get; }
            Task<string> SaveImageAsync(IFormFile file);

        }
    }
}
