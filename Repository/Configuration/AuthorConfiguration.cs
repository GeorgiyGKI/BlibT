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
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasData(
                new Author
                {
                    Id = 1,
                    FullName = "John Doe"
                },
                new Author
                {
                    Id = 2,
                    FullName = "Jane Smith"
                },
                new Author
                {
                    Id = 3,
                    FullName = "David Johnson"
                },
                new Author
                {
                    Id = 4,
                    FullName = "Emma Brown"
                },
                new Author
                {
                    Id = 5,
                    FullName = "Michael Davis"
                },
                new Author
                {
                    Id = 6,
                    FullName = "Sophia Miller"
                },
                new Author
                {
                    Id = 7,
                    FullName = "Daniel Wilson"
                },
                new Author
                {
                    Id = 8,
                    FullName = "Olivia Moore"
                },
                new Author
                {
                    Id = 9,
                    FullName = "Ethan Lee"
                },
                new Author
                {
                    Id = 10,
                    FullName = "Ava Anderson",
                });
        }
    }
}
