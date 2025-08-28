namespace Application.DTOs;

public record NoteUpdateDto
{
    public string Title { get; init; } = null!;
    public string? Content { get; init; }
}