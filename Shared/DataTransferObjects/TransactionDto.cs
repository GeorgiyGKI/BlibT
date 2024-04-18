using Shared.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public record TransactionDto
    {
        public IEnumerable<BookDto>? Books { get; set; }
        public string? UserEmail { get; set; }
        public int? Sum { get; set; }
    }
}
