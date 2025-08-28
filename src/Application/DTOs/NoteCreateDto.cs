namespace Application.DTOs;

public record NoteCreateDto
{
    public string Title { get; init; } = null!;
    public string? Content { get; init; }
}