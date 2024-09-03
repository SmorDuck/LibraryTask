using Microsoft.EntityFrameworkCore;
using Domain;

namespace LibraryTaskBack.Data
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}
