using CustomerAccount_Library.Models;

namespace CustomerAccount_Library.Repository
{
    public interface ICustomer
    {
        public IEnumerable<Customer> GetAllCustomer();
    }
}
