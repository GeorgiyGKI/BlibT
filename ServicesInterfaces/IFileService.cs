using Microsoft.AspNetCore.Http;

namespace ServicesInterfaces
{
    public interface IFileService
    {
        public Task<string> SaveImageAsync(IFormFile imageFile);
        public bool DeleteImage(string imageFileName);
    }
}