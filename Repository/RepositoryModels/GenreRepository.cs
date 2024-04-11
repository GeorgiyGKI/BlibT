using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository.RepositoryModels.GenreRepository
{
    public class GenreRepository : RepositoryBase<Genre>, IGenreRepository
    {
        public GenreRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<Genre>> GetAllGenresAsync(bool trackChanges) =>
            await FindAll(trackChanges).ToListAsync();

        public async Task<Genre> GetGenreAsync(int genreId, bool trackChanges) =>
               await FindByCondition(Entity => Entity.Id.Equals(genreId), trackChanges).SingleOrDefaultAsync();

        public void CreateGenre(Genre genre) => Create(genre);

        public void DeleteGenre(Genre genre) => Delete(genre);

        public async Task<IEnumerable<Genre>> GetGenresByBookIdAsync(int bookId, bool trackChanges)
        {
            return await FindByCondition
                (g => g.BookGenres.Any(gen => gen.BookId == bookId), trackChanges)
                .Include(g => g.Books)
                .ToListAsync();
        }
    }
}
