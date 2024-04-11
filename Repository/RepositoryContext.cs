using Entities.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Repository.Configuration;

namespace Repository
{
    public partial class RepositoryContext : IdentityDbContext<User>
    {

        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BookGenre>()
                .HasKey(bc => new { bc.BookId, bc.GenreId });
            modelBuilder.Entity<BookGenre>()
                .HasOne(bc => bc.Book)
                .WithMany(b => b.BookGenres)
                .HasForeignKey(bc => bc.BookId);
            modelBuilder.Entity<BookGenre>()
                .HasOne(bc => bc.Genre)
                .WithMany(c => c.BookGenres)
                .HasForeignKey(bc => bc.GenreId);

            modelBuilder.Entity<User>()
        .HasMany(e => e.LikedBooks)
        .WithMany(e => e.Users)
        .UsingEntity<UserBookLike>();

            modelBuilder.Entity<User>()
        .HasMany(e => e.FavoriteBooks)
        .WithMany(e => e.Users)
        .UsingEntity<UserBookFavorite>();

            modelBuilder.ApplyConfiguration(new AuthorConfiguration());
            modelBuilder.ApplyConfiguration(new BookConfiguration());
            modelBuilder.ApplyConfiguration(new GenreConfiguration());
            modelBuilder.ApplyConfiguration(new BookGenreConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<BookGenre> BookGenres { get; set; }
    }
}