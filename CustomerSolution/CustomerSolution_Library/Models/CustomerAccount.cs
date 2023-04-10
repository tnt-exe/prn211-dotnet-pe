using System;
using System.Collections.Generic;

namespace CustomerSolution_Library.Models
{
    public partial class CustomerAccount
    {
        public string AccountId { get; set; } = null!;
        public string AccountName { get; set; } = null!;
        public DateTime? OpenDate { get; set; }
        public string? RegionName { get; set; }
        public string? CustomerId { get; set; }

        public virtual Customer? Customer { get; set; }
    }
}
