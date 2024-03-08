using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public partial class RepositoryContext : DbContext
    {

        public RepositoryContext(DbContextOptions options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}