using Notes.DB;

namespace Notes.Core
{
    public interface INoteServices
    {
        public Note CreateNote(Note note);
        public Note GetNote(int id);
    }
}