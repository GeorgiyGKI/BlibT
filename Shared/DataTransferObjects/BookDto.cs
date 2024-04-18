using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.DataTransferObject
{
    public record BookDto
    {
        public int? Id { get; set; }
        public List<string>? Pages { get; set; }
        public string? ProductImageName { get; set; }
        public List<string>?  GenresId { get; set; }
        public int? AuthorId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int? Likes { get; set; } = 0;
        public int? Views { get; set; } = 0;
        public int? Favorits { get; set; } = 0;
        public decimal? Price { get; set; }
        [NotMapped]
        public IFormFile? ImageFile { get; set; }
    }
}