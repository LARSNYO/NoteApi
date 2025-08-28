using Application.DTOs;

namespace Application.Interfaces.Services;
public interface INoteService
{
    Task<IEnumerable<NoteReadDto>> GetAllNoteAsync();
    Task<NoteReadDto?> GetNoteByIdAsync(Guid id);
    Task<NoteReadDto> CreateNoteAsync(NoteCreateDto noteCreateDto);
    // Task UpdateNoteAsync(Guid id, NoteUpdateDto noteUpdateDto);
    // Task DeleteNoteAsync(Guid id);
}