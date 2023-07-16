using System;
using System.Collections.Generic;

namespace CustomerAccount_Library.Models
{
    public partial class Customer
    {
        public Customer()
        {
            CustomerAccounts = new HashSet<CustomerAccount>();
        }

        public string CustomerId { get; set; } = null!;
        public string CustomerName { get; set; } = null!;
        public string? CustomerDesc { get; set; }

        public virtual ICollection<CustomerAccount> CustomerAccounts { get; set; }
    }
}
