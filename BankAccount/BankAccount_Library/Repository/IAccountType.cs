using BankAccount_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount_Library.Repository
{
    public interface IAccountType
    {
        public IEnumerable<AccountType> GetAllAccountType();
    }
}
