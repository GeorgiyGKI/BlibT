using Entities.Models;

namespace Repository.RepositoryModels.GenreRepository
{

    public interface IGenreRepository
    {
        Task<IEnumerable<Genre>> GetAllGenresAsync(bool trackChanges);
        Task<Genre> GetGenreAsync(int genreId, bool trackChanges);
        void CreateGenre(Genre genre);
        void DeleteGenre(Genre genre);
    }
}
