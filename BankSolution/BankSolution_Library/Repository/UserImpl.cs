using BankSolution_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSolution_Library.Repository
{
    public class UserImpl : IUser
    {
        private BankAccountTypeContext _db;

        public UserImpl()
        {
            _db = new BankAccountTypeContext();
        }

        public User Login(string userid, string pwd)
        {
            return _db.Users.ToList().FirstOrDefault(u => u.UserId.Equals(userid, StringComparison.Ordinal) &&
            u.Password.Equals(pwd, StringComparison.Ordinal));
        }
    }
}
