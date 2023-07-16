﻿using System;
using System.Collections.Generic;

namespace BankAccount_Library.Models
{
    public partial class BankAccount
    {
        public string AccountId { get; set; } = null!;
        public string AccountName { get; set; } = null!;
        public DateTime? OpenDate { get; set; }
        public string? BranchName { get; set; }
        public string? TypeId { get; set; }

        public virtual AccountType? Type { get; set; }
    }
}
