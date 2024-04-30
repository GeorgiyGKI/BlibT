using Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.ServiceManager;
using Shared.DataTransferObject;
using Shared.DataTransferObjects;
using System.ComponentModel.DataAnnotations;

namespace BlibT.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IServiceManager _service;
        public UserController(IServiceManager service) => _service = service;

        [HttpGet("likedBooks/{email}")]
        [Authorize]
        public async Task<IActionResult> GetLikedBooks(string email)
        {
            var books = await _service.UserService.GetUserBooksByTypeAsync(email, "UserBookLike");

            return books != null ? Ok(books) : NotFound();
        }
        [HttpGet("buyedBooks/{email}")]
        [Authorize]
        public async Task<IActionResult> GetBuyedBooks(string email)
        {
            var books = await _service.UserService.GetUserBooksByTypeAsync(email, "UserBookBuyed");

            return books != null ? Ok(books) : NotFound();
        }

        [HttpGet("favBooks/{email}")]
        [Authorize]
        public async Task<IActionResult> GetFavoriteBooks(string email)
        {
            var books = await _service.UserService.GetUserBooksByTypeAsync(email, "UserBookFavorite");


            return books != null ? Ok(books) : NotFound();
        }

        [HttpPatch("addFavorite")]
        [Authorize]
        public async Task<IActionResult> AddFavoriteBook([FromBody] UserBookDto userBook)
        {
            var param = new List<BookDto> { new BookDto { Id = userBook.BookId } };

            await _service.UserService.AddBooksByTypeAsync(userBook.UserEmail, param, "UserBookFavorite");

            var book = await _service.BookService.GetBookAsync(userBook.BookId, true);
            ++book.Favorits;

            await _service.BookService.UpdateBookAsync(userBook.BookId, book, true);

            return Ok();
        }

        [HttpPatch("addLike")]
        [Authorize]
        public async Task<IActionResult> AddLikedBook([FromBody] UserBookDto userBook)
        {

            var param = new List<BookDto> { new BookDto { Id = userBook.BookId } };

            await _service.UserService.AddBooksByTypeAsync(userBook.UserEmail, param , "UserBookLike");

            var book = await _service.BookService.GetBookAsync(userBook.BookId, true);
            ++book.Likes;

            await _service.BookService.UpdateBookAsync(userBook.BookId, book, true);

            return Ok();
        }
        [HttpPatch("addView")]
        [Authorize]
        public async Task<IActionResult> AddViewBook([FromBody] UserBookDto userBook)
        {

            var book = await _service.BookService.GetBookAsync(userBook.BookId, true);
            ++book.Views;

            await _service.BookService.UpdateBookAsync(userBook.BookId, book, true);

            return Ok();
        }


        [HttpPost("isLiked")]
        [Authorize]
        public async Task<IActionResult> isLiked([FromBody] UserBookDto userBook)
        {
            var isLiked = await _service.UserService.IsLikedBook(userBook.UserEmail, userBook.BookId);

            return Ok(isLiked);
        }

        [HttpPost("isFavotite")]
        [Authorize]
        public async Task<IActionResult> isFavoriteBook([FromBody] UserBookDto userBook)
        {
            var isFavotite = await _service.UserService.IsFavoriteBook(userBook.UserEmail, userBook.BookId);

            return Ok(isFavotite);
        }

        [HttpPatch("removeFavoriteBook")]
        [Authorize]
        public async Task<IActionResult> removeFavoriteBook([FromBody] UserBookDto userBook)
        {
            await _service.UserService.RemoveBookByTypeAsync(userBook.UserEmail, userBook.BookId, "UserBookFavorite");

            var book = await _service.BookService.GetBookAsync(userBook.BookId, true);
            --book.Likes;

            await _service.BookService.UpdateBookAsync(userBook.BookId, book, true);

            return Ok();
        }
        [HttpPatch("removeLikedBook")]
        [Authorize]
        public async Task<IActionResult> removeLikedBook([FromBody] UserBookDto userBook)
        {
            await _service.UserService.RemoveBookByTypeAsync(userBook.UserEmail, userBook.BookId, "UserBookLike");

            var book = await _service.BookService.GetBookAsync(userBook.BookId, true);
            --book.Likes;

            await _service.BookService.UpdateBookAsync(userBook.BookId, book, true);

            return Ok();
        }
    }
}
