using Microsoft.EntityFrameworkCore;
using NotesApi.Models;

namespace NotesApi.DbContextClasses
{
    public class NotesDbContext(DbContextOptions<NotesDbContext> options): DbContext(options)
    {
        public DbSet<Note> Notes => Set<Note>();
    }
}
