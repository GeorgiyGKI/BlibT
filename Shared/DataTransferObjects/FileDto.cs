using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public record FileDto
    {
        public string Email { get; set; }
        public int bookId { get; set; }
        public IFormFile? FormFile { get; set; }
    }
}
