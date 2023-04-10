using CustomerSolution_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerSolution_Library.Repository
{
    public interface ICustomerAccount
    {
        public IEnumerable<CustomerAccount> GetAllAccount();
        bool Add(CustomerAccount account);
        bool Remove(CustomerAccount account);
        bool Update(CustomerAccount account);
    }
}
