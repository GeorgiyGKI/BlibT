
using Repository.RepositoryModels.AuthorRepository;
using Repository.RepositoryModels.BookRepository;
using Repository.RepositoryModels.GenreRepository;
using Repository.RepositoryModels.ReaderRepository;
using Repository.RepositoryModels.TransactionRepository;
using Repository.RepositoryModels.TransactonStatusRepository;

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