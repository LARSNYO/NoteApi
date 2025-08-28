


namespace Domain.Entities;

public record Tag
{
    public Guid Id { get; init; }
    public string Name { get; init; } = null!;
    public List<Note> Notes { get; init; } = new();
}
