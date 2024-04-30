using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class User : IdentityUser
    {
        public decimal Pocket { get; set; } = 1000;
        public ICollection<Book> FavoriteBooks { get; set; }
        public ICollection<Book> LikedBooks { get; set; }
        public ICollection<Book> BuyedBooks { get; set; }
    }
}
