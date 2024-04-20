using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Book
    {
        public int Id { get; set; }
        public int? AuthorId { get; set; }
        public string? Title { get; set; }
        public string? ProductImageName { get; set; }
        public List<Genre>? Genres { get; set; } = [];
        public List<Transaction>? Transactions { get; set; } = [];
        public string? Description { get; set; }
        public int? Likes { get; set; }
        public int? Views { get; set; }
        public int? Favorits { get; set; }
        public decimal? Price { get; set; }

        public Author Author { get; }
        public ICollection<User> Users { get; set; } = [];
        public List<BookGenre>? BookGenres { get; set; } = [];
        public ICollection<UserBookFavorite> UserBookFavorites { get; set; } = [];
        public ICollection<UserBookLike> UserBookLikes { get; set; } = [];
        public ICollection<UserBookBuyed> UserBookBuyeds { get; set; } = [];
        public ICollection<BookTransaction> BookTransactions { get; set; } = [];
    }
}
