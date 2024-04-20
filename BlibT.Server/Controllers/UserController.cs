using Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.ServiceManager;
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
            var books = await _service.UserService.GetLikedBooksByEmailAsync(email);

            return books != null ? Ok(books) : NotFound();
        }
        [HttpGet("buyedBooks/{email}")]
        [Authorize]
        public async Task<IActionResult> GetBuyedBooks(string email)
        {
            var books = await _service.UserService.GetBuyedBooksByEmailAsync(email);

            return books != null ? Ok(books) : NotFound();
        }

        [HttpGet("favBooks/{email}")]
        [Authorize]
        public async Task<IActionResult> GetFavoritBooks(string email)
        {
            var books = await _service.UserService.GetFavoritBooksByEmailAsync(email);


            return books != null ? Ok(books) : NotFound();
        }

        [HttpPatch("addFavorite")]
        [Authorize]
        public async Task<IActionResult> AddFavoritBook([FromBody] UserBookDto userBook)
        {
            await _service.UserService.AddFavoritBookAsync(userBook.UserEmail, userBook.BookId);

            var book = await _service.BookService.GetBookAsync(userBook.BookId, false);
            ++book.Favorits;

            await _service.BookService.UpdateBookAsync(userBook.BookId, book, true);

            return Ok();
        }

        [HttpPatch("addLike")]
        [Authorize]
        public async Task<IActionResult> AddLikedBook([FromBody] UserBookDto userBook)
        {
            await _service.UserService.AddLikedBookAsync(userBook.UserEmail, userBook.BookId);

            var book = await _service.BookService.GetBookAsync(userBook.BookId, false);
            ++book.Likes;

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
            await _service.UserService.RemoveFavoritBookAsync(userBook.UserEmail, userBook.BookId);

            var book = await _service.BookService.GetBookAsync(userBook.BookId, false);
            --book.Likes;

            await _service.BookService.UpdateBookAsync(userBook.BookId, book, true);

            return Ok();
        }
        [HttpPatch("removeLikedBook")]
        [Authorize]
        public async Task<IActionResult> removeLikedBook([FromBody] UserBookDto userBook)
        {
            await _service.UserService.RemoveLikedBookAsync(userBook.UserEmail, userBook.BookId);

            var book = await _service.BookService.GetBookAsync(userBook.BookId, false);
            --book.Likes;

            await _service.BookService.UpdateBookAsync(userBook.BookId, book, true);

            return Ok();
        }
    }
}
