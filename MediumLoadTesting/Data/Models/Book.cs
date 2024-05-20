namespace MediumLoadTesting;

public class Book
{
    public int BookId { get; set; }

    public required string Name { get; set; }

    public required string AuthorName { get; set; }

    public DateTime PublishedAt { get; set; }
}
