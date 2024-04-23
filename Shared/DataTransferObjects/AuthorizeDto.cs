using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public record AuthorizeDto
    {
 
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

        public string[]? Roles { get; set; }
    }
}
