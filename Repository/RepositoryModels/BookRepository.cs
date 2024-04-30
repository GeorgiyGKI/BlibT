using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository.RepositoryModels.BookRepository
{
    public class BookRepository : RepositoryBase<Book>, IBookRepository
    {
        public BookRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task<Book> GetBookAsync(int bookId, bool trackChanges) =>
               await FindByCondition(Entity => Entity.Id.Equals(bookId), trackChanges)
                     .Include(p => p.Genres)
                     .FirstOrDefaultAsync();

        public void CreateBook(Book book) => Create(book);

        public void DeleteBook(Book book) => Delete(book);

        public async Task<IEnumerable<Book>> GetAllBooksAsync(bool trackChanges) =>
               await FindAll(trackChanges)
                     .Include(p => p.Genres)
                     .ToListAsync();

        public async Task<IEnumerable<Book>> GetBooksByGenreIdAsync(int genreId, bool trackChanges)
        {
            return await FindByCondition (b => b.Genres.Any(bg => bg.Id == genreId), trackChanges)
                        .Include(b => b.Genres)
                        .ToListAsync();
        }
    } 
}
