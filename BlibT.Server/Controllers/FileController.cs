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

        [HttpPost]
        public async Task<IActionResult> CreateFile([FromForm] FileDto file)
        {
            var fileName = await _fileService.SaveDoxcFileAsync(file.FormFile);
            var book = await _service.BookService.GetBookAsync(file.BookId, true);
            book.DocxFileName = fileName;
            await _service.BookService.UpdateBookAsync((int)book.Id, book, true);

            return NoContent();
        }
    }
}

