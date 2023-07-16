using CustomerAccount_Library.Models;

namespace CustomerAccount_Library.Repository
{
    public class UserImpl : IUser
    {
        private CustomerAccountsContext _db;

        public UserImpl()
        {
            _db = new CustomerAccountsContext();
        }

        public User Login(string userid, string password)
        {
            var user = _db.Users.ToList()
                .FirstOrDefault(u => u.UserId.Equals(userid, StringComparison.Ordinal) && u.Password.Equals(password, StringComparison.Ordinal));
            if (user != null)
            {
                return user;
            }
            return null;
        }
    }
}
