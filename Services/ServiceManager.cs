using AutoMapper;
using Contracts;
using LoggerService;
using Service.AuthorService;
using Service.BookService;
using Service.GenreService;

namespace Service.ServiceManager
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IAuthorService> _authorService;
        private readonly Lazy<IBookService> _bookService;
        private readonly Lazy<IGenreService> _genreService;
       

        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            _authorService = new Lazy<IAuthorService>(() => new AuthorService.AuthorService(repositoryManager, logger, mapper));
            _bookService = new Lazy<IBookService>(() => new BookService.BookService(repositoryManager, logger, mapper));
            _genreService = new Lazy<IGenreService>(() => new GenreService.GenreService(repositoryManager, logger, mapper));
        }

        public IAuthorService AuthorService => _authorService.Value;
        public IBookService BookService => _bookService.Value;
        public IGenreService GenreService => _genreService.Value;
    }
}
