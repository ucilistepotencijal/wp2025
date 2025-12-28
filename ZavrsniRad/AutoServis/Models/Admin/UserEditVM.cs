using System.ComponentModel.DataAnnotations;

namespace AutoServis.Models.Admin
{
    public class UserEditVM
    {
        public string Id { get; set; } = "";

        [Required(ErrorMessage = "Email je obavezan.")]
        [EmailAddress(ErrorMessage = "Email nije ispravan.")]
        [Display(Name = "Email")]
        public string Email { get; set; } = "";

        [Display(Name = "Korisničko ime")]
        public string UserName { get; set; } = "";

        [Display(Name = "Aktivan")]
        public bool IsActive { get; set; } = true;

        [Display(Name = "Role")]
        public List<RoleCheckVM> Roles { get; set; } = new();
    }

    public class RoleCheckVM
    {
        public string Name { get; set; } = "";
        public bool Selected { get; set; }
    }
}
