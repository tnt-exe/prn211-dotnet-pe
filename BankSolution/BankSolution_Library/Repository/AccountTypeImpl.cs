using BankSolution_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSolution_Library.Repository
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
