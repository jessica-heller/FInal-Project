using Microsoft.EntityFrameworkCore;

namespace FinalProject.Models
{
    public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options)
            : base(options)
            {
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<UserBook>().HasKey(u => new {u.BookId, u.UserId});
            }

            public DbSet<Book> Book {get; set;} = default!;
            public DbSet<User> User {get; set;} = default!;
    }
}