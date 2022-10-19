using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using static E_Commerce.Service.Interfases.IFileService;

namespace E_Commerce.Service.Services
{
    public class FileService : IFileService
    {
        private readonly string _basePath;

        private const string ImageFolderName = "images";

        public FileService(IWebHostEnvironment webHost)
        {
            _basePath = webHost.WebRootPath;
        }
        string IFileService.ImageFolderName => ImageFolderName;
        public async Task<string> SaveImageAsync(IFormFile file)
        {
            var fileName = MakeImageName(file.FileName);
            var partPath = Path.Combine(ImageFolderName, fileName);
            var path = Path.Combine(_basePath, partPath);

            var stream = File.Create(path);
            await file.CopyToAsync(stream);
            stream.Close();
            return partPath;
        }
        private string MakeImageName(string filename)
        {
            return $"IMG_{Guid.NewGuid():N}_{filename}";
        }
    }
}
