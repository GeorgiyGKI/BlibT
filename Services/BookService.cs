using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
using LoggerService;
using Microsoft.AspNetCore.Identity;
using Shared.DataTransferObject;
using System.Linq.Expressions;

namespace Service.BookService
{
    public class BookService : IBookService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public BookService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<BookDto> GetBookAsync(int id, bool trackChanges)
        {
            var book = await _repository.Book.GetBookAsync(id, trackChanges) ?? throw new BookNotFoundException(id);
            var bookDto = _mapper.Map<BookDto>(book);

            return bookDto;
        }
        public async Task<IEnumerable<BookDto>> GetRndBooksAsync(int amount = 5, bool all = true)
        {
            var random = new Random();
            var allBooks = await _repository.Book.GetAllBooksAsync(false);

            var randomBooks = !all ? allBooks.OrderBy(x => random.Next()).ToList()
                                   : allBooks.OrderBy(x => random.Next()).Take(amount).ToList();

            var bookDto = _mapper.Map<IEnumerable<BookDto>>(randomBooks);
            return bookDto;
        }


        public async Task<BookDto> CreateBookAsync(BookDto bookDto)
        {
            var bookGenres = new List<BookGenre>();
            foreach (var genreId in bookDto.GenresIds)
            {
                bookGenres.Add(new BookGenre { GenreId = int.Parse(genreId) });
            };
            var bookEntity = _mapper.Map<Book>(bookDto);
            bookEntity.BookGenres = bookGenres;

            _repository.Book.CreateBook(bookEntity);
            await _repository.SaveAsync();
            var bookToReturn = _mapper.Map<BookDto>(bookEntity);

            return bookToReturn;
        }



        public async Task DeleteBookAsync(int id, bool trackChanges)
        {
            var book = await _repository.Book.GetBookAsync(id, trackChanges) ?? throw new BookNotFoundException(id);
            _repository.Book.DeleteBook(book);
            await _repository.SaveAsync();
        }

        public async Task UpdateBookAsync(int id, BookDto bookForUpdate, bool trackChanges)
        {
            var bookEntity = await _repository.Book.GetBookAsync(id, trackChanges) ?? throw new BookNotFoundException(id);

            var bookGenres = new List<BookGenre>();
            foreach (var genreId in bookForUpdate.GenresIds)
            {
                bookGenres.Add(new BookGenre { BookId = id, GenreId = int.Parse(genreId) });
            };

            _mapper.Map(bookForUpdate, bookEntity);
            bookEntity.Id = id;
            bookEntity.BookGenres = bookGenres;

            await _repository.SaveAsync();
        }

        public async Task<IEnumerable<BookDto>> GetAllBooksAsync(bool trackChanges)
        {
            var books = await _repository.Book.GetAllBooksAsync(trackChanges);
            var booksDto = _mapper.Map<IEnumerable<BookDto>>(books);

            return booksDto;
        }

        public async Task<IEnumerable<BookDto>> GetBooksByGenreIdAsync(int genreId, bool trackChanges)
        {
            var books = await _repository.Book.GetBooksByGenreIdAsync(genreId, trackChanges) ?? throw new GenreNotFoundException(genreId); ;
            var booksDto = _mapper.Map<IEnumerable<BookDto>>(books);

            return booksDto;
        }

    }
}
