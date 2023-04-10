using System;
using System.Collections.Generic;

namespace PaperJournal_Library.Models
{
    public partial class JournalInfo
    {
        public JournalInfo()
        {
            Papers = new HashSet<Paper>();
        }

        public int JournalId { get; set; }
        public string JournalName { get; set; } = null!;
        public string? ShortJournalDescription { get; set; }
        public string? Telephone { get; set; }
        public string? Category { get; set; }

        public virtual ICollection<Paper> Papers { get; set; }
    }
}
