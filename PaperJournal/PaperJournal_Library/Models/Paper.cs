using System;
using System.Collections.Generic;

namespace PaperJournal_Library.Models
{
    public partial class Paper
    {
        public string PaperId { get; set; } = null!;
        public string PaperTitle { get; set; } = null!;
        public DateTime SubmittedDate { get; set; }
        public string Abstract { get; set; } = null!;
        public string? Authors { get; set; }
        public int? JournalId { get; set; }

        public virtual JournalInfo? Journal { get; set; }
    }
}
