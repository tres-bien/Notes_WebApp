using Notes_WebApp.Shared;

namespace Notes_WebApp.Server
{
    public interface INoteService
    {
        Task<Note> CreateNoteAsync(Note note);
        Task<bool> DeleteNoteAsync(int id);
        Task<IEnumerable<Note>> GetAllNotesAsync();
        Task<Note> GetNoteAsync(int id);
        Task<bool> UpdateNoteAsync(int id, Note note);
    }
}