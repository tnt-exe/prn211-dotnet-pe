using BankAccount_Library.Models;

namespace BankAccount_Library.Repository
{
    public class UserImpl : IUser
    {
        private BankAccountTypeContext _db;

        public UserImpl()
        {
            _db = new BankAccountTypeContext();
        }

        public User? Login(string userid, string pwd)
        {
            return _db.Users.ToList().FirstOrDefault(u => u.UserId.Equals(userid, StringComparison.Ordinal) &&
            u.Password.Equals(pwd, StringComparison.Ordinal));
        }
    }
}
