using PaperJournal_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperJournal_Library.Repository
{
    public class AccountImpl : IAccount
    {
        private PaperJournalSp2023DBContext _db;

        public AccountImpl()
        {
            _db = new PaperJournalSp2023DBContext();
        }

        public IEnumerable<Account> GetAllAccount()
        {
            return _db.Accounts.ToList();
        }
    }
}
