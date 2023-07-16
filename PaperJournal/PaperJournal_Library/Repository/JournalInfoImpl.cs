using PaperJournal_Library.Models;

namespace PaperJournal_Library.Repository
{
    public class JournalInfoImpl : IJournalInfo
    {
        private PaperJournalSp2023DBContext _db;

        public JournalInfoImpl()
        {
            _db = new PaperJournalSp2023DBContext();
        }

        public IEnumerable<JournalInfo> GetAllJournal()
        {
            return _db.JournalInfos.ToList();
        }
    }
}
