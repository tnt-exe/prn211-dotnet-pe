using CustomerAccount_Library.Models;

namespace CustomerAccount_Library.Repository;

public interface IUser
{
    public User Login(string userid, string password);
}
