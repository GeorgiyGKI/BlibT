
using Repository.RepositoryModels.AuthorRepository;
using Repository.RepositoryModels.BookRepository;
using Repository.RepositoryModels.GenreRepository;

namespace Contracts
{
    public interface IRepositoryManager
    {
        IAuthorRepository Author { get; }
        IBookRepository Book { get; }
        IGenreRepository Genre { get; }
        Task SaveAsync();
    }
}