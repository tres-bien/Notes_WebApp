using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Notes_WebApp.Server.Data;
using Notes_WebApp.Shared;

namespace Notes_WebApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        private readonly INoteService _noteService;

        public NotesController(INoteService noteService)
        {
            _noteService = noteService ?? throw new ArgumentNullException(nameof(noteService));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Note>>> GetNotes()
        {
            var notes = await _noteService.GetAllNotesAsync();
            return Ok(notes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Note>> GetNote(int id)
        {
            var note = await _noteService.GetNoteAsync(id);
            if (note == null)
            {
                return NotFound();
            }

            return Ok(note);
        }

        [HttpPost]
        public async Task<ActionResult<Note>> CreateNote([FromBody] Note noteRequest)
        {
            if (noteRequest == null)
            {
                return BadRequest();
            }

            var note = await _noteService.CreateNoteAsync(noteRequest);
            return Ok(note);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateNote(int id, [FromBody] Note note)
        {
            if (note == null)
            {
                return BadRequest();
            }

            var updated = await _noteService.UpdateNoteAsync(id, note);
            if (!updated)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteNote(int id)
        {
            var deleted = await _noteService.DeleteNoteAsync(id);
            if (!deleted)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
