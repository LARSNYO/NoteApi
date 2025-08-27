


namespace Domain.Entities;

public record Note
{
    public Guid Id { get; init; }
    public string Title { get; init; } = null!;
    public string? Content { get; init; }
    public DateTime CreateAt { get; init; }
    public DateTime? UpdateAt { get; init; }
}