using PaperJournal_Library.Models;

namespace PaperJournal_Library.Repository
{
    public interface IJournalInfo
    {
        public IEnumerable<JournalInfo> GetAllJournal();
    }
}
