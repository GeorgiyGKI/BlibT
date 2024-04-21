using Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Service.ServiceManager;
using Shared.DataTransferObject;
using Shared.DataTransferObjects;

namespace BlibT.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        private readonly IServiceManager _service;
        private readonly UserManager<User> _userManager;
        public TransactionsController(UserManager<User> UserManager, IServiceManager service)
        {
            _service = service;
            _userManager = UserManager;
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> PostTransaction([FromBody] TransactionDto transactionDto)
        {
            var user = await _userManager.FindByEmailAsync(transactionDto.UserEmail);

            if (transactionDto != null &&
                user != null &&
                user.Pocket >= transactionDto.Sum)
            {
                await _service.TransactionService.CreateTransactionAsync(transactionDto);
                await _service.UserService.RemoveMoney(transactionDto.UserEmail, (decimal)transactionDto.Sum);
                await _service.UserService.AddBooksByTypeAsync(transactionDto.UserEmail, (List<BookDto>)transactionDto.Books, "UserBookBuyed");

                return NoContent();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetAllTransactions()
        {
            var transactions = await _service.TransactionService.GetAllTransactionsAsync();

            return transactions != null ? Ok(transactions) : NotFound();
        }
    }
}
