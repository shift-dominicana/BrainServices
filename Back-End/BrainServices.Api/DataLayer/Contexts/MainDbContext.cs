using DataLayer.ContextExtension.Authors;
using DataLayer.ContextExtension.Books;
using DataLayer.ContextExtension.Genres;
using DataLayer.ContextExtension.Users;
using DataLayer.Models.Authors;
using DataLayer.Models.Books;
using DataLayer.Models.Genres;
using DataLayer.Models.User;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Contexts
{
    public class MainDbContext : DbContext
    {
        public MainDbContext(DbContextOptions<MainDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.ApplyConfiguration(new AuthorConfiguration());
            //modelBuilder.ApplyConfiguration(new BooksConfiguration());
            //modelBuilder.ApplyConfiguration(new GenresConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }

        //public DbSet<Author> Authors { get; set; }
        //public DbSet<Book> Books { get; set; }
        //public DbSet<Genre> Genres { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
