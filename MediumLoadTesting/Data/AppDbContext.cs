using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;

namespace MediumLoadTesting;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options, IHttpContextAccessor accessor) : base(options)
    {
         var conn = Database.GetDbConnection() as SqlConnection;
         conn.AccessToken = accessor.HttpContext.Request.Headers["X-MS-TOKEN-AAD-ACCESS-TOKEN"];
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>().HasData(GetBooks());
    }

    public DbSet<Book> Books { get; set; }

    private Book[] GetBooks()
    {
        return Enumerable.Range(1, 10).Select(index => new Book
        {
            BookId = index,
            Name = $"Name {index}",
            AuthorName = $"AuthorName {index}",
            PublishedAt = DateTime.UtcNow
        }).ToArray();
    }
}