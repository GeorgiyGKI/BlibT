using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.ServiceManager;
using ServicesInterfaces;
using Shared.DataTransferObject;
using WebLibWebApi.Action_Filters;

namespace WebLibWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IServiceManager _service;
        private readonly IFileService _fileService;

        public BooksController(IServiceManager service, IFileService fileService)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
            _fileService = fileService ?? throw new ArgumentNullException(nameof(fileService));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBooks()
        {
            var books = await _service.BookService.GetAllBooksAsync(trackChanges: false);

            return books != null ? Ok(books) : NotFound();
        }

        [HttpGet("rndBooks")]
        public async Task<IActionResult> GetRndBooks()
        {
            var books = await _service.BookService.GetRndBooksAsync();

            return books != null ? Ok(books) : NotFound();
        }

        [HttpGet("BooksByGenreId/{id:int}")]
        public async Task<IActionResult> GetBooksByGenreId(int id)
        {
            var books = await _service.BookService.GetBooksByGenreIdAsync(id, trackChanges: false);

            return books != null ? Ok(books) : NotFound();
        }

        [HttpGet("{id:int}", Name = "BookById")]
        public async Task<IActionResult> GetBook(int id)
        {
            var book = await _service.BookService.GetBookAsync(id, trackChanges: false);

            return book != null ? Ok(book) : NotFound();
        }

        [HttpPost]
        //[ServiceFilter(typeof(ValidationFilterAttribute))]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> CreateBook([FromForm] BookDto book)
        {
            var fileName = await _fileService.SaveImageAsync(book.ImageFile);
            book.ProductImageName = fileName; // getting name of image


            await _service.BookService.CreateBookAsync(book);


            return NoContent();
        }

        [HttpDelete("{id:int}")]
        //[Authorize(Roles = "Administrator")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            await _service.BookService.DeleteBookAsync(id, trackChanges: false);

            return NoContent();
        }

        [HttpPut("{id:int}")]
        //[ServiceFilter(typeof(ValidationFilterAttribute))]
        //[Authorize(Roles = "Administrator, Moderator")]
        public async Task<IActionResult> UpdateBook(int id, [FromForm] BookDto book)
        {
            var fileName = await _fileService.SaveImageAsync(book.ImageFile);
            book.ProductImageName = fileName;



            await _service.BookService.UpdateBookAsync(id, book, trackChanges: true);

            return NoContent();
        }
    }
}
