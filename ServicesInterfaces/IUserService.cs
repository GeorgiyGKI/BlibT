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
        Task<IEnumerable<BookDto>> GetBooksByUserEmailAsync(string UserEmail);
        Task<IEnumerable<BookDto>> AddFavoritBookAsync(string UserEmail);
        Task<IEnumerable<BookDto>> AddLikedBookAsync(string UserEmail);
        Task<IEnumerable<BookDto>> GetLikedBooksByEmailAsync(string UserEmail);
        Task<IEnumerable<BookDto>> GetFavoritBooksByEmailAsync(string UserEmail);
    }
}
