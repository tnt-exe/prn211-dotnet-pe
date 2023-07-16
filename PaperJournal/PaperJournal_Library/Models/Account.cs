namespace PaperJournal_Library.Models
{
    public partial class Account
    {
        public string StaffId { get; set; } = null!;
        public string AccountFullName { get; set; } = null!;
        public string AccountEmail { get; set; } = null!;
        public string? AccountPassword { get; set; }
        public DateTime Birthday { get; set; }
        public int? AccountRole { get; set; }
    }
}
