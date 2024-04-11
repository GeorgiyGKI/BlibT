using AutoMapper;
using Contracts;
using Entities.Models;
using LoggerService;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Service.AuthenticationService;
using Service.AuthorService;
using Service.BookService;
using Service.GenreService;
using Services;
using ServicesInterfaces;

namespace Service.ServiceManager
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IAuthorService> _authorService;
        private readonly Lazy<IBookService> _bookService;
        private readonly Lazy<IGenreService> _genreService;
        private readonly Lazy<IAuthenticationService> _authenticationService;
        private readonly Lazy<IUserService> _userService;

        public ServiceManager(IRepositoryManager repositoryManager,
            ILoggerManager logger,
            IMapper mapper,
            UserManager<User> UserManager,
            RoleManager<IdentityRole> RoleManager,
            IConfiguration configuration)
        {
            _authorService = new Lazy<IAuthorService>(() => new AuthorService.AuthorService(repositoryManager, logger, mapper));
            _bookService = new Lazy<IBookService>(() => new BookService.BookService(repositoryManager, logger, mapper));
            _genreService = new Lazy<IGenreService>(() => new GenreService.GenreService(repositoryManager, logger, mapper));
            _authenticationService = new Lazy<IAuthenticationService>(() => new AuthenticationService.AuthenticationService(logger, mapper, UserManager, RoleManager, configuration));
            _userService = new Lazy<IUserService>(() => new UserService(UserManager, repositoryManager, mapper));
        }

        public IAuthorService AuthorService => _authorService.Value;
        public IBookService BookService => _bookService.Value;
        public IGenreService GenreService => _genreService.Value;
        public IAuthenticationService AuthenticationService => _authenticationService.Value;
        public IUserService UserService => _userService.Value;
    }
}
