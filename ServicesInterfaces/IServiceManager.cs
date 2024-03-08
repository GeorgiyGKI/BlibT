using Service.AuthorService;
using Service.BookService;
using Service.GenreService;

namespace Service.ServiceManager
{
    public interface IServiceManager
    {
        IAuthorService AuthorService { get; }
        IBookService BookService { get; }
        IGenreService GenreService { get; }
    }
}
