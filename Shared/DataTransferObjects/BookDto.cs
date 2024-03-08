using System.ComponentModel.DataAnnotations;

namespace Shared.DataTransferObject
{
    public record BookDto
    {
        public int Id { get; init; }

        [Required]
        [StringLength(30)]
        public string Title { get; init; }

        [Required]
        public int AuthorId { get; init; }

        [Required]
        [Range(0, 9999)]
        public int Year { get; init; }

        [Required]
        public int GenreId { get; init; }

        [Required]
        [Range(1, 99)]
        public int Quantity { get; init; }

        [Required]
        public FileInfo ImageData { get; init; }
    }
}