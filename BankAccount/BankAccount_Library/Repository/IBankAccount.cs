using BankAccount_Library.Models;

namespace BankAccount_Library.Repository
{
    public interface IBankAccount
    {
        public IEnumerable<BankAccount> GetAllBankAccount();
        bool Add(BankAccount bankAccount);
        bool Remove(BankAccount bankAccount);
        bool Update(BankAccount bankAccount);
    }
}
