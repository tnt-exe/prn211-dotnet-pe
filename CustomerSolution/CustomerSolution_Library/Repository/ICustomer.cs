﻿using CustomerSolution_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerSolution_Library.Repository
{
    public interface ICustomer
    {
        public IEnumerable<Customer> GetAllCustomer();
    }
}
