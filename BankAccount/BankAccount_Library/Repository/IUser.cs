using BankAccount_Library.Models;

namespace BankAccount_Library.Repository
{
    public interface IUser
    {
        public User? Login(string userid, string pwd);
    }
}
