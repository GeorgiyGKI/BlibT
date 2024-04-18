using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            Random rnd = new Random();

            builder.HasData(
                new Book
                {
                    Id = 1,
                    Title = "The Da Vinci Code",
                    AuthorId = 1,
                    Description = "Some text",
                    Likes = rnd.Next(0, 100),
                    Views = rnd.Next(0, 50),
                    Favorits = rnd.Next(0, 30),
                    Price = rnd.Next(10, 50),
                    ProductImageName = "default.jpg"
                },
                new Book
                {
                    Id = 2,
                    Title = "Dune",
                    AuthorId = 2,
                    Description = "Some text",
                    Likes = rnd.Next(0, 100),
                    Views = rnd.Next(0, 50),
                    Favorits = rnd.Next(0, 30),
                    Price = rnd.Next(10, 50),
                    ProductImageName = "default.jpg"
                },
                new Book
                {
                    Id = 3,
                    Title = "Pride and Prejudice",
                    AuthorId = 3,
                    Description = "Some text",
                    Likes = rnd.Next(0, 100),
                    Views = rnd.Next(0, 50),
                    Favorits = rnd.Next(0, 30),
                    Price = rnd.Next(10, 50),
                    ProductImageName = "default.jpg"
                },
                new Book
                {
                    Id = 4,
                    Title = "The Girl with the Dragon Tattoo",
                    AuthorId = 4,
                    Description = "Some text",
                    Likes = rnd.Next(0, 100),
                    Views = rnd.Next(0, 50),
                    Favorits = rnd.Next(0, 30),
                    Price = rnd.Next(10, 50),
                    ProductImageName = "default.jpg"
                },
                new Book
                {
                    Id = 5,
                    Title = "Harry Potter and the Sorcerer's Stone",
                    AuthorId = 5,
                    Description = "Some text",
                    Likes = rnd.Next(0, 100),
                    Views = rnd.Next(0, 50),
                    Favorits = rnd.Next(0, 30),
                    Price = rnd.Next(10, 50),
                    ProductImageName = "default.jpg"
                },
                new Book
                {
                    Id = 6,
                    Title = "The Great Gatsby",
                    AuthorId = 6,
                    Description = "Some text",
                    Likes = rnd.Next(0, 100),
                    Views = rnd.Next(0, 50),
                    Favorits = rnd.Next(0, 30),
                    Price = rnd.Next(10, 50),
                    ProductImageName = "default.jpg"
                },
                new Book
                {
                    Id = 7,
                    Title = "Steve Jobs",
                    AuthorId = 7,
                    Description = "Some text",
                    Likes = rnd.Next(0, 100),
                    Views = rnd.Next(0, 50),
                    Favorits = rnd.Next(0, 30),
                    Price = rnd.Next(10, 50),
                    ProductImageName = "default.jpg"
                },
                new Book
                {
                    Id = 8,
                    Title = "The Hobbit",
                    AuthorId = 8,
                    Description = "Some text",
                    Likes = rnd.Next(0, 100),
                    Views = rnd.Next(0, 50),
                    Favorits = rnd.Next(0, 30),
                    Price = rnd.Next(10, 50),
                    ProductImageName = "default.jpg"
                },
                new Book
                {
                    Id = 9,
                    Title = "It",
                    AuthorId = 9,
                    Description = "Some text",
                    Likes = rnd.Next(0, 100),
                    Views = rnd.Next(0, 50),
                    Favorits = rnd.Next(0, 30),
                    Price = rnd.Next(10, 50),
                    ProductImageName = "default.jpg"
                },
                new Book
                {
                    Id = 10,
                    Title = "Romeo and Juliet",
                    AuthorId = 10,
                    Description = "Some text",
                    Likes = rnd.Next(0, 100),
                    Views = rnd.Next(0, 50),
                    Favorits = rnd.Next(0, 30),
                    Price = rnd.Next(10, 50),
                    ProductImageName = "default.jpg"
                },
                 new Book
                 {
                     Id = 11,
                     Title = "The Hound of the Baskervilles",
                     AuthorId = 2,
                     Description = "Some text",
                     Likes = rnd.Next(0, 100),
                     Views = rnd.Next(0, 50),
                     Favorits = rnd.Next(0, 30),
                     Price = rnd.Next(10, 50),
                     ProductImageName = "default.jpg"
                 },
                 new Book
                 {
                     Id = 12,
                     Title = "Neuromancer",
                     AuthorId = 2,
                     Description = "Some text",
                     Likes = rnd.Next(0, 100),
                     Views = rnd.Next(0, 50),
                     Favorits = rnd.Next(0, 30),
                     Price = rnd.Next(10, 50),
                     ProductImageName = "default.jpg"
                 },
                 new Book
                 {
                     Id = 13,
                     Title = "Sense and Sensibility",
                     AuthorId = 5,
                     Description = "Some text",
                     Likes = rnd.Next(0, 100),
                     Views = rnd.Next(0, 50),
                     Favorits = rnd.Next(0, 30),
                     Price = rnd.Next(10, 50),
                     ProductImageName = "default.jpg"
                 },
                 new Book
                 {
                     Id = 14,
                     Title = "The Girl Who Played with Fire",
                     Description = "Some text",
                     Likes = rnd.Next(0, 100),
                     Views = rnd.Next(0, 50),
                     Favorits = rnd.Next(0, 30),
                     Price = rnd.Next(10, 50),
                     ProductImageName = "default.jpg"
                 },
                 new Book
                 {
                     Id = 15,
                     Title = "Harry Potter and the Chamber of Secrets",
                     AuthorId = 5,
                     Description = "Some text",
                     Likes = rnd.Next(0, 100),
                     Views = rnd.Next(0, 50),
                     Favorits = rnd.Next(0, 30),
                     Price = rnd.Next(10, 50),
                     ProductImageName = "default.jpg"
                 },
                 new Book
                 {
                     Id = 16,
                     Title = "To Kill a Mockingbird",
                     AuthorId = 6,
                     Description = "Some text",
                     Likes = rnd.Next(0, 100),
                     Views = rnd.Next(0, 50),
                     Favorits = rnd.Next(0, 30),
                     Price = rnd.Next(10, 50),
                     ProductImageName = "default.jpg"
                 },
                 new Book
                 {
                     Id = 17,
                     Title = "Einstein: His Life and Universe",
                     AuthorId = 7,
                     Description = "Some text",
                     Likes = rnd.Next(0, 100),
                     Views = rnd.Next(0, 50),
                     Favorits = rnd.Next(0, 30),
                     Price = rnd.Next(10, 50),
                     ProductImageName = "default.jpg"
                 },
                 new Book
                 {
                     Id = 18,
                     Title = "The Lord of the Rings",
                     AuthorId = 8,
                     Description = "Some text",
                     Likes = rnd.Next(0, 100),
                     Views = rnd.Next(0, 50),
                     Favorits = rnd.Next(0, 30),
                     Price = rnd.Next(10, 50),
                     ProductImageName = "default.jpg"
                 },
                 new Book
                 {
                     Id = 19,
                     Title = "The Shining",
                     AuthorId = 3,
                     Description = "Some text",
                     Likes = rnd.Next(0, 100),
                     Views = rnd.Next(0, 50),
                     Favorits = rnd.Next(0, 30),
                     Price = rnd.Next(10, 50),
                     ProductImageName = "default.jpg"
                 },
                 new Book
                 {
                     Id = 20,
                     Title = "Macbeth",
                     AuthorId = 10,
                     Description = "Some text",
                     Likes = rnd.Next(0, 100),
                     Views = rnd.Next(0, 50),
                     Favorits = rnd.Next(0, 30),
                     Price = rnd.Next(10, 50),
                     ProductImageName = "default.jpg"
                 });
        }
    }
}
