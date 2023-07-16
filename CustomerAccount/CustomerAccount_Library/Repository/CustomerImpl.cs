using CustomerAccount_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAccount_Library.Repository
{
    public class CustomerImpl : ICustomer
    {
        private CustomerAccountsContext _db;

        public CustomerImpl()
        {
            _db = new();
        }

        public IEnumerable<Customer> GetAllCustomer()
        {
            return _db.Customers.ToList();
        }
    }
}
