using System.ComponentModel.DataAnnotations;

namespace Shared.DataTransferObject
{
    public record AuthorDto
    {
        public int Id { get; init; }
        [Required]
        [StringLength(30)]
        public string FullName { get; init; }
    }
}
