namespace CustomerAccount_Library.Models
{
    public partial class User
    {
        public string UserId { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? UserName { get; set; }
        public int? UserRole { get; set; }
    }
}
