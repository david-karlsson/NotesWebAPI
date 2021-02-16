using Notes.DB;
using System.Linq;

namespace Notes.Core
{
    public class NoteServices:INoteServices
    {

        private AppDbContext _context;
        public NoteServices(AppDbContext context)
        {
            _context = context;
        }

        public Note CreateNote(Note note)
        {
            _context.Add(note);
            _context.SaveChanges();

            return note;


        }

        public Note GetNote(int id)
        {
            return _context.Notes.First(n => n.Id == id);


        }
    }
}
