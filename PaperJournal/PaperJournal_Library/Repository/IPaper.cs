using PaperJournal_Library.Models;

namespace PaperJournal_Library.Repository
{
    public interface IPaper
    {
        public IEnumerable<Paper> GetAllPaper();
        bool Add(Paper paper);
        bool Delete(Paper paper);
        bool Update(Paper paper);
    }
}
