using Microsoft.EntityFrameworkCore;
using Notes_WebApp.Server.Data;
using Notes_WebApp.Server;
using Notes_WebApp.Shared;

namespace Notes.Tests
{
    public class Tests
    {
        [Test]
        public void GetAllNotesAsync_ReturnsListOfNotes()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            using (var context = new DataContext(options))
            {
                context.Notes.Add(new Note { Id = 1, Title = "Note 1" });
                context.Notes.Add(new Note { Id = 2, Title = "Note 2" });
                context.SaveChanges();
            }

            using (var context = new DataContext(options))
            {
                var service = new NoteService(context);

                // Act
                var result = service.GetAllNotesAsync().Result;

                // Assert
                Assert.That(result.Count(), Is.EqualTo(2));
            }
        }

        [Test]
        public void CreateNoteAsync_CreatesNewNote()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            using (var context = new DataContext(options))
            {
                var service = new NoteService(context);
                var newNote = new Note { Title = "New Note", Content = "Content" };

                // Act
                var result = service.CreateNoteAsync(newNote).Result;

                // Assert
                Assert.NotNull(result);
                Assert.That(result.Title, Is.EqualTo("New Note"));
            }
        }

        [Test]
        public void GetNoteAsync_ReturnsNote()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            using (var context = new DataContext(options))
            {
                context.Notes.Add(new Note { Id = 1, Title = "Note 1" });
                context.SaveChanges();
            }

            using (var context = new DataContext(options))
            {
                var service = new NoteService(context);

                // Act
                var result = service.GetNoteAsync(1).Result;

                // Assert
                Assert.NotNull(result);
                Assert.That(result.Title, Is.EqualTo("Note 1"));
            }
        }

        [Test]
        public void UpdateNoteAsync_UpdatesNote()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            using (var context = new DataContext(options))
            {
                context.Notes.Add(new Note { Id = 1, Title = "Note 1" });
                context.SaveChanges();
            }

            using (var context = new DataContext(options))
            {
                var service = new NoteService(context);
                var updatedNote = new Note { Id = 1, Title = "Updated Note" };

                // Act
                var result = service.UpdateNoteAsync(1, updatedNote).Result;

                // Assert
                Assert.True(result);
                var note = context.Notes.FindAsync(1).Result;
                Assert.That(note.Title, Is.EqualTo("Updated Note"));
            }
        }

        [Test]
        public void DeleteNoteAsync_DeletesNote()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            using (var context = new DataContext(options))
            {
                context.Notes.Add(new Note { Id = 1, Title = "Note 1" });
                context.SaveChanges();
            }

            using (var context = new DataContext(options))
            {
                var service = new NoteService(context);

                // Act
                var result = service.DeleteNoteAsync(1).Result;

                // Assert
                Assert.True(result);
                var note = context.Notes.FindAsync(1).Result;
                Assert.IsNull(note);
            }
        }
    }
}