using Microsoft.EntityFrameworkCore;

namespace MediumLoadTesting;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>().HasData(GetBooks());
    }

    public DbSet<Book> Books { get; set; }

    private Book[] GetBooks()
    {
        return Enumerable.Range(1, 10).Select(index => new Book {
            BookId = index,
            Name = $"Name {index}",
            AuthorName = $"AuthorName {index}",
            PublishedAt = DateTime.UtcNow
        }).ToArray();
    }
}