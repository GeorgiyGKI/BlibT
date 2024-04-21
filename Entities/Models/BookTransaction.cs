using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class BookTransaction
    {
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int TransactionId { get; set; }
        public Transaction Transaction { get; set; }
    }
}
