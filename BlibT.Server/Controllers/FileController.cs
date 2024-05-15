using Microsoft.AspNetCore.Mvc;
using Service.ServiceManager;
using ServicesInterfaces;
using Shared.DataTransferObjects;

namespace BlibT.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        private readonly IFileService _fileService;
        private readonly IServiceManager _service;

        public FileController(IFileService fileService, IServiceManager service)
        {
            _fileService = fileService ?? throw new ArgumentNullException(nameof(fileService));
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }

        [HttpGet("/{email}/{bookTitle}")]
        public async Task<IActionResult> GetFile()
        {
            var filePath = "path/to/your/file.docx";
            var fileName = "file.docx";
            var fileBytes = System.IO.File.ReadAllBytes(filePath);

            return File(fileBytes, "application/vnd.openxmlformats-officedocument.wordprocessingml.document", fileName);
        }

        [HttpPost]
        public async Task<IActionResult> CreateFile(FileDto file)
        {
            var fileName = await _fileService.SaveDoxcFileAsync(file.FormFile);
            var book = await _service.BookService.GetBookAsync(file.bookId, true);
            //book.DocxFileName = fileName;

            return Ok();
        }
    }
}

