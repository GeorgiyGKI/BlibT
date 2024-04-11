using Entities.Models;

namespace Repository.RepositoryModels.BookRepository
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetAllBooksAsync(bool trackChanges);
        Task<Book> GetBookAsync(int bookId, bool trackChanges);
        void CreateBook(Book book);
        void DeleteBook(Book book);
        Task<IEnumerable<Book>> GetBooksByGenreIdAsync(int genreId, bool trackChanges);
    }
}
