
using Repository.RepositoryModels.AuthorRepository;
using Repository.RepositoryModels.BookRepository;
using Repository.RepositoryModels.GenreRepository;
using RepositoryInterfaces.RepositoryModels;

namespace Contracts
{
    public interface IRepositoryManager
    {
        IAuthorRepository Author { get; }
        IBookRepository Book { get; }
        IGenreRepository Genre { get; }
        ITransactionRepository Transaction { get; }
        Task SaveAsync();
    }
}