using Microsoft.EntityFrameworkCore;

namespace Books
{
  public class BookContext : DbContext
  {

    public BookContext()
    { }

    public BookContext(DbContextOptions<BookContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFProviders.InMemory;Trusted_Connection=True;ConnectRetryCount=0");
      }
    }

    public DbSet<Book> Books { get; set; }
  }
}