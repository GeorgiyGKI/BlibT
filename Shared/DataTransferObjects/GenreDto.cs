﻿using System.ComponentModel.DataAnnotations;

namespace Shared.DataTransferObject
{
    public record GenreDto
    {
        public int Id { get; init; }
        [Required]
        [StringLength(35)]
        public string? Name { get; init; }
    }
}
