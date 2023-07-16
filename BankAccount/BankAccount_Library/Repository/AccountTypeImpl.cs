using BankAccount_Library.Models;

namespace BankAccount_Library.Repository
{
    public class AccountTypeImpl : IAccountType
    {
        private BankAccountTypeContext _db;

        public AccountTypeImpl()
        {
            _db = new BankAccountTypeContext();
        }

        public IEnumerable<AccountType> GetAllAccountType()
        {
            return _db.AccountTypes.ToList();
        }
    }
}
