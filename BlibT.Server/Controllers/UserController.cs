using Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.ServiceManager;
using Shared.DataTransferObjects;

namespace BlibT.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IServiceManager _service;
        public UserController(IServiceManager service) => _service = service;

        [HttpGet("favBooks/{email}")]
        public async Task<IActionResult> GetFavoritUsersBooks(string email)
        {
            var books = await _service.UserService.GetBooksByUserEmailAsync(email);
           

            return books != null ? Ok(books) : NotFound();
        }
        [HttpGet("likedBooks/{email}")]
        [Authorize]
        public async Task<IActionResult> GetLikedUsersBooks(string email)
        {
            var books = await _service.UserService.GetLikedBooksId(email);


            return books != null ? Ok(books) : NotFound();
        }
    }
}
