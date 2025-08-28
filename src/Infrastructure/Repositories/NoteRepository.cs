using Application.Interfaces.Repositories;
using Infrastracture.Persistance;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastracture.Repositories;

public class NoteRepository : INoteRepository
{
    private readonly NoteDbContext _noteDbContext;
    public NoteRepository(NoteDbContext noteDbContext)
    {
        _noteDbContext = noteDbContext;
    }

    public async Task<Note?> GetNoteByIdAsync(Guid id) => await _noteDbContext.Notes.FindAsync(id);

    public async Task AddNoteAsync(Note note)
    {
        await _noteDbContext.Notes.AddAsync(note);
        await _noteDbContext.SaveChangesAsync();
    }

    public async Task<IEnumerable<Note>> GetAllNoteAsync() => await _noteDbContext.Notes.ToListAsync();
}