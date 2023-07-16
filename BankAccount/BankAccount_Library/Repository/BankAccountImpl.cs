using Microsoft.EntityFrameworkCore;
using BankAccount_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount_Library.Repository
{
    public class BankAccountImpl : IBankAccount
    {
        private BankAccountTypeContext _db;

        public BankAccountImpl()
        {
            _db = new BankAccountTypeContext();
        }

        public bool Add(BankAccount bankAccount)
        {
            if (bankAccount != null)
            {
                try
                {
                    var existingAccount = _db.BankAccounts.Find(bankAccount.AccountId);
                    if (existingAccount != null)
                    {
                        _db.Entry(existingAccount).State = EntityState.Detached;
                    }
                    _db.Add(bankAccount);
                    _db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }

        public IEnumerable<BankAccount> GetAllBankAccount()
        {
            return _db.BankAccounts.Include(bk => bk.Type).ToList();
        }

        public bool Remove(BankAccount bankAccount)
        {
            if (bankAccount != null)
            {
                try
                {
                    var existingAccount = _db.BankAccounts.Find(bankAccount.AccountId);
                    if (existingAccount != null)
                    {
                        _db.Entry(existingAccount).State = EntityState.Detached;
                    }
                    _db.Remove(bankAccount);
                    _db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }

        public bool Update(BankAccount bankAccount)
        {
            if (bankAccount != null)
            {
                try
                {
                    var existingAccount = _db.BankAccounts.Find(bankAccount.AccountId);
                    if (existingAccount != null)
                    {
                        _db.Entry(existingAccount).State = EntityState.Detached;
                    }
                    _db.Update(bankAccount);
                    _db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }
    }
}
