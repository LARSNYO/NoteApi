using System.Net.Http.Headers;
using Application.DTOs;
using Application.Interfaces.Repositories;
using Application.Interfaces.Services;
using Domain.Entities;

namespace Application.Services;

public class NoteService : INoteService
{
    private readonly INoteRepository _noteRepository;
    public NoteService(INoteRepository noteRepository)
    {
        _noteRepository = noteRepository;
    }

    public async Task<NoteReadDto> CreateNoteAsync(NoteCreateDto noteCreateDto)
    {
        var note = new Note(noteCreateDto.Title, noteCreateDto.Content ?? string.Empty);
        await _noteRepository.AddNoteAsync(note);

        return new NoteReadDto
        {
            Id = note.Id,
            Title = note.Title,
            Content = note.Content,
            CreateAt = note.CreateAt,
            UpdateAt = note.UpdateAt
        };
    }

    public async Task<NoteReadDto?> GetNoteByIdAsync(Guid id)
    {
        var note = await _noteRepository.GetNoteByIdAsync(id);
        if (note is null) return null;

        return new NoteReadDto
        {
            Id = note.Id,
            Title = note.Title,
            Content = note.Content,
            CreateAt = note.CreateAt,
            UpdateAt = note.UpdateAt
        };
    }

    public async Task<IEnumerable<NoteReadDto>> GetAllNoteAsync()
    {
        var notes = await _noteRepository.GetAllNoteAsync();
        return notes.Select(n => new NoteReadDto
        {
            Id = n.Id,
            Title = n.Title,
            Content = n.Content,
            CreateAt = n.CreateAt,
            UpdateAt = n.UpdateAt
        });
    }


}