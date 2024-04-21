using Shared.DataTransferObject;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesInterfaces
{
    public interface IUserService
    {
        Task<IEnumerable<BookDto>> GetUserBooksByTypeAsync(string userEmail, string type);
        Task AddBooksByTypeAsync(string userEmail, List<BookDto> bookIds, string type);
        Task RemoveBookByTypeAsync(string userEmail, int bookId, string type);
        Task<bool> IsLikedBook(string userEmail, int bookId);
        Task<bool> IsFavoriteBook(string userEmail, int bookId);
        Task AddMoney(string userEmail, decimal amount);
        Task RemoveMoney(string userEmail, decimal amount);
    }
}
