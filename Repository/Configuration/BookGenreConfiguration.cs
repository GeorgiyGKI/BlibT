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
            builder.HasData(
               new BookGenre
               {
                   BookId = 1,
                   GenreId = 1,
               },
               new BookGenre
               {
                   BookId = 1,
                   GenreId = 2,
               },
               new BookGenre
               {
                   BookId = 1,
                   GenreId = 3,
               },
               new BookGenre
               {
                   BookId = 2,
                   GenreId = 3,
               },
               new BookGenre
               {
                   BookId = 2,
                   GenreId = 4,
               },
                 new BookGenre
                 {
                     BookId = 2,
                     GenreId = 5,
                 }
               );
        }
    }
}
