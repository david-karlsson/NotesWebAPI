using System.Collections.Generic;
using Notes.DB;

namespace Notes.Core
{
    public interface INoteServices
    {
        public Note CreateNote(Note note);
        public Note GetNote(int id);

        public List<Note> GetNotes();

        public void DeleteNote(int id);

        public void EditNote(Note note);
    }
}