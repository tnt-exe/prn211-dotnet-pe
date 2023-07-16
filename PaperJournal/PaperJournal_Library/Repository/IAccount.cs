using PaperJournal_Library.Models;

namespace PaperJournal_Library.Repository
{
    public interface IAccount
    {
        public IEnumerable<Account> GetAllAccount();
    }
}
