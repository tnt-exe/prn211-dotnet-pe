using CustomerAccount_Library.Models;

namespace CustomerAccount_Library.Repository
{
    public interface ICustomerAccount
    {
        public IEnumerable<CustomerAccount> GetAllAccount();
        bool Add(CustomerAccount account);
        bool Remove(CustomerAccount account);
        bool Update(CustomerAccount account);
    }
}
