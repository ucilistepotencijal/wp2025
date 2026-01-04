namespace AutoServis.Models.Admin
{
    public class UserListItemVM
    {
        public string Id { get; set; } = "";
        public string? Email { get; set; }
        public string? UserName { get; set; }
        public bool IsActive { get; set; }
        public IList<string> Roles { get; set; } = new List<string>();
    }
}
