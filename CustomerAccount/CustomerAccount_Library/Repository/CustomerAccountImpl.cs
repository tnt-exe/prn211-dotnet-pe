using Microsoft.EntityFrameworkCore;
using CustomerAccount_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAccount_Library.Repository
{
    public class CustomerAccountImpl : ICustomerAccount
    {
        private CustomerAccountsContext _db;

        public CustomerAccountImpl()
        {
            _db = new CustomerAccountsContext();
        }

        public bool Add(CustomerAccount account)
        {
            try
            {
                if (account != null)
                {
                    var exist = _db.CustomerAccounts.Find(account.AccountId);
                    if (exist != null)
                    {
                        _db.Entry(exist).State = EntityState.Detached;
                    }
                    _db.Add(account);
                    _db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<CustomerAccount> GetAllAccount()
        {
            return _db.CustomerAccounts.Include(c => c.Customer).ToList();
        }

        public bool Remove(CustomerAccount account)
        {
            try
            {
                if (account != null)
                {
                    var exist = _db.CustomerAccounts.Find(account.AccountId);
                    if (exist != null)
                    {
                        _db.Entry(exist).State = EntityState.Detached;
                    }
                    _db.Remove(account);
                    _db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(CustomerAccount account)
        {
            try
            {
                if (account != null)
                {
                    var exist = _db.CustomerAccounts.Find(account.AccountId);
                    if (exist != null)
                    {
                        _db.Entry(exist).State = EntityState.Detached;
                    }
                    _db.Update(account);
                    _db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
