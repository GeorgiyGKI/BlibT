using Microsoft.AspNetCore.Mvc;

namespace BlibT.Server.Controllers
{
    [Route("api/[controller]")]
    public class ImagesController : ControllerBase
    {
        [HttpPost("upload")]
        public async Task<IActionResult> Upload(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest("File is null or empty.");

            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", file.FileName);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            return Ok();
        }

        [HttpGet("{imageName}")]
        public IActionResult GetImage(string imageName)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", imageName);
            var imageBytes = System.IO.File.ReadAllBytes(path);
            return File(imageBytes, "image/jpeg");
        }
    }
}
