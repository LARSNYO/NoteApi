using Application.DTOs;
using Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace NoteApi.Controllers;


[ApiController]
[Route("api/[controller]")]
public class NoteController : ControllerBase
{
    private readonly INoteService _noteService;
    public NoteController(INoteService noteService)
    {
        _noteService = noteService;
    }

    // GET: api/notes
    [HttpGet]
    public async Task<ActionResult<IEnumerable<NoteReadDto>>> GetAll()
    {
        var notes = await _noteService.GetAllNoteAsync();
        return Ok(notes);
    }

    // GET: api/notes/{id}
    [HttpGet("{id}")]
    public async Task<ActionResult<NoteReadDto>> GetById(Guid id)
    {
        var note = await _noteService.GetNoteByIdAsync(id);
        if (note is null) return NotFound();
        return Ok(note);
    }

    // POST: api/notes
    [HttpPost]
    public async Task<ActionResult<NoteReadDto>> Create([FromBody] NoteCreateDto noteCreateDto)
    {
        var createdNote = await _noteService.CreateNoteAsync(noteCreateDto);
        return CreatedAtAction(nameof(GetById), new { id = createdNote.Id }, createdNote);
    }
}