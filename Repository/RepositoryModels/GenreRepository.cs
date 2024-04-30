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
            await FindAll(trackChanges)
            .Include(g => g.Books)
            .ToListAsync();

        public async Task<Genre> GetGenreAsync(int genreId, bool trackChanges) =>
               await FindByCondition(Entity => Entity.Id.Equals(genreId), trackChanges)
            .Include(g => g.Books)
            .SingleOrDefaultAsync();

        public void CreateGenre(Genre genre) => Create(genre);

        public void DeleteGenre(Genre genre) => Delete(genre);

        public async Task<IEnumerable<Genre>> GetGenresByBookIdAsync(int bookId, bool trackChanges)
        {
            return await FindByCondition
                (g => g.Books.Any(gen => gen.Id == bookId), trackChanges)
                .Include(g => g.Books)
                .ToListAsync();
        }
    }
}
