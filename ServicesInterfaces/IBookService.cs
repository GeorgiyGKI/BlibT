using Shared.DataTransferObject;

namespace Service.BookService
{
    public interface IBookService
    {
        Task<IEnumerable<BookDto>> GetAllBooksAsync(bool trackChanges);
        Task<BookDto> GetBookAsync(int id, bool trackChanges);
        Task<BookDto> CreateBookAsync(BookDto book);
        Task DeleteBookAsync(int id, bool trackChanges);
        Task UpdateBookAsync(int id, BookDto bookForUpdate, bool trackChanges);
        Task<IEnumerable<BookDto>> GetBooksByGenreIdAsync(int genreId, bool trackChanges);
        Task<IEnumerable<BookDto>> GetRndBooksAsync(int amount = 5, bool all = true);
    }
}
