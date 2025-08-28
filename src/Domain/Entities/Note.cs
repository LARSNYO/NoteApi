namespace Domain.Entities;

public record Note
{
    public Guid Id { get; init; }
    public string Title { get; init; } = null!;
    public string? Content { get; init; }
    public DateTime CreateAt { get; init; }
    public DateTime? UpdateAt { get; init; }

    public Note(string title, string content)
    {
        if (string.IsNullOrWhiteSpace(title))
            throw new ArgumentException("Title cannot be empty", nameof(title));

        Id = Guid.NewGuid();
        Title = title;
        Content = content;
        CreateAt = DateTime.UtcNow;
    }
}