using Shared.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesInterfaces
{
    public interface IUserService
    {
        Task<bool> IsLikedBook(string userEmail, int bookId);
        Task<bool> IsFavoriteBook(string userEmail, int bookId);
        Task AddFavoritBookAsync(string UserEmail, int bookId);
        Task AddLikedBookAsync(string UserEmail, int bookId);
        Task<IEnumerable<BookDto>> GetLikedBooksByEmailAsync(string UserEmail);
        Task<IEnumerable<BookDto>> GetFavoritBooksByEmailAsync(string UserEmail);
        Task RemoveFavoritBookAsync(string userEmail, int bookId);
        Task RemoveLikedBookAsync(string userEmail, int bookId);
        Task AddMoney(string userEmail, decimal amount);
        Task RemoveMoney(string userEmail, decimal amount);
        Task AddBuyedBooksAsync(string userEmail, List<BookDto> bookIds);
        Task<IEnumerable<BookDto>> GetBuyedBooksByEmailAsync(string userEmail);
    }
}
