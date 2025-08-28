using Domain.Entities;

namespace Application.Interfaces.Repositories;

public interface INoteRepository
{
    Task<Note?> GetNoteByIdAsync(Guid id);
    Task AddNoteAsync(Note note);
    Task<IEnumerable<Note>> GetAllNoteAsync();
}