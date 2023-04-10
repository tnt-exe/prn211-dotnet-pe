using BankSolution_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSolution_Library.Repository
{
    public interface IUser
    {
        public User Login(string userid, string pwd);
    }
}
