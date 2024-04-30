using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public string? UserEmail { get; set; }
        public decimal Sum { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;

        public ICollection<Book> Books { get; set; } = [];
    }
}
