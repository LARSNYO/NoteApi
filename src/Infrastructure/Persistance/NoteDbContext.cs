using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Infrastracture.Persistance;


namespace Infrastracture.Persistance;

public class NoteDbContext : DbContext
{
    public NoteDbContext(DbContextOptions<NoteDbContext> options) : base(options)
    { }
    public DbSet<Note> Notes { get; init; }
}