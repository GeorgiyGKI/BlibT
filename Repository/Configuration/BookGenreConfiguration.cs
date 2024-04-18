using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configuration
{
    public class BookGenreConfiguration : IEntityTypeConfiguration<BookGenre>
    {
        public void Configure(EntityTypeBuilder<BookGenre> builder)
        {
            Random rnd = new Random();

            var BookGenreList = new List<BookGenre>();
            for (int i = 1; i <= 20; i++)
            {
                BookGenreList.Add(new BookGenre { BookId = i, GenreId = rnd.Next(1, 10) });
            }

            builder.HasData(BookGenreList);

        }
    }
}
