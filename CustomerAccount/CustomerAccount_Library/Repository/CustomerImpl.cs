using CustomerAccount_Library.Models;

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
