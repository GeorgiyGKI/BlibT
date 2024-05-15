using ServicesInterfaces;

namespace BlibT.Server.FileService
{
    public class FileService : IFileService
    {
        private IWebHostEnvironment environment;
        public FileService(IWebHostEnvironment env)
        {
            environment = env;
        }

        public async Task<string> SaveImageAsync(IFormFile imageFile)
        {
            try
            {
                if (imageFile is null)
                    return "default.jpg";
                
                var contentPath = this.environment.ContentRootPath;
                var path = Path.Combine(contentPath, "Uploads");

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                var ext = Path.GetExtension(imageFile.FileName);
                var allowedExtensions = new string[] { ".jpg", ".png", ".jpeg" };

                if (!allowedExtensions.Contains(ext))
                {
                   string msg = string.Format("Only {0} extensions are allowed", string.Join(",", allowedExtensions));
                   throw new Exception(msg);
                }

                string uniqueString = Guid.NewGuid().ToString();
                var newFileName = uniqueString + ext;
                var fileWithPath = Path.Combine(path, newFileName);

                using (var stream = new FileStream(fileWithPath, FileMode.Create))
                {
                    await imageFile.CopyToAsync(stream);
                }

                return newFileName;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
        public async Task<string> SaveDoxcFileAsync(IFormFile file)
        {
            try
            {
                if (file is null)
                    return "default.docx";

                var contentPath = this.environment.ContentRootPath;
                var path = Path.Combine(contentPath, "Uploads/Documents");

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                var ext = Path.GetExtension(file.FileName);
                var allowedExtensions = new string[] { ".doc", ".docx" };

                if (!allowedExtensions.Contains(ext))
                {
                    string msg = string.Format("Only {0} extensions are allowed", string.Join(",", allowedExtensions));
                    throw new Exception(msg);
                }

                string uniqueString = Guid.NewGuid().ToString();
                var newFileName = uniqueString + ext;
                var fileWithPath = Path.Combine(path, newFileName);

                using (var stream = new FileStream(fileWithPath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                return newFileName;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
        public bool DeleteImage(string imageFileName)
        {
            try
            {
                var wwwPath = environment.WebRootPath;
                var path = Path.Combine(wwwPath, "Uploads\\", imageFileName);
                if (File.Exists(path))
                {
                    File.Delete(path);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteDocxFile(string FileName)
        {
            try
            {
                var wwwPath = environment.WebRootPath;
                var path = Path.Combine(wwwPath, "Uploads\\Documents\\", FileName);
                if (File.Exists(path))
                {
                    File.Delete(path);
                    return true;
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
