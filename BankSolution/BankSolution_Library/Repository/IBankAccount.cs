using BankSolution_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSolution_Library.Repository
{
    public interface IBankAccount
    {
        public IEnumerable<BankAccount> GetAllBankAccount();
        bool Add(BankAccount bankAccount);
        bool Remove(BankAccount bankAccount);
        bool Update(BankAccount bankAccount);
    }
}
