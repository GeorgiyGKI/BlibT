using Contracts;
using Repository.RepositoryModels;
using Repository.RepositoryModels.AuthorRepository;
using Repository.RepositoryModels.BookRepository;
using Repository.RepositoryModels.GenreRepository;
using RepositoryInterfaces.RepositoryModels;

namespace Repository
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<IAuthorRepository> _authorRepository;
        private readonly Lazy<IBookRepository> _bookRepository;
        private readonly Lazy<IGenreRepository> _genreRepository;
        private readonly Lazy<ITransactionRepository> _transactionRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _authorRepository = new Lazy<IAuthorRepository>(() => new AuthorRepository(repositoryContext));
            _bookRepository = new Lazy<IBookRepository>(() => new BookRepository(repositoryContext));
            _genreRepository = new Lazy<IGenreRepository>(() => new GenreRepository(repositoryContext));
            _transactionRepository = new Lazy<ITransactionRepository>(() => new TransactionRepository(repositoryContext));
        }

        public IAuthorRepository Author => _authorRepository.Value;
        public IBookRepository Book => _bookRepository.Value;
        public IGenreRepository Genre => _genreRepository.Value;
        public ITransactionRepository Transaction => _transactionRepository.Value;
        public async Task SaveAsync() => await _repositoryContext.SaveChangesAsync();
    }
}