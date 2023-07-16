using BankAccount_Library.Models;

namespace BankAccount_Library.Repository
{
    public interface IAccountType
    {
        public IEnumerable<AccountType> GetAllAccountType();
    }
}
