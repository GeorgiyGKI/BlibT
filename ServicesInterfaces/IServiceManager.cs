using Service.AuthenticationService;
using Service.AuthorService;
using Service.BookService;
using Service.GenreService;
using Services.ServiceInterfaces;
using ServicesInterfaces;

namespace Service.ServiceManager
{
    public interface IServiceManager
    {
        IAuthorService AuthorService { get; }
        IBookService BookService { get; }
        IGenreService GenreService { get; }
        IAuthenticationService AuthenticationService { get; }
        IUserService UserService { get; }
        ITransactionService TransactionService { get; }
    }
}
