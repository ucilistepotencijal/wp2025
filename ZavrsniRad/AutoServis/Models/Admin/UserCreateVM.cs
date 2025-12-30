using System.ComponentModel.DataAnnotations;

namespace AutoServis.Models.Admin
{
    public class UserCreateVM
    {
        [Required(ErrorMessage = "Email je obavezan.")]
        [EmailAddress(ErrorMessage = "Email nije ispravan.")]
        [Display(Name = "Email")]
        public string Email { get; set; } = "";

        [Required(ErrorMessage = "Lozinka je obavezna.")]
        [MinLength(6, ErrorMessage = "Lozinka mora imati barem 6 znakova.")]
        [DataType(DataType.Password)]
        [Display(Name = "Lozinka")]
        public string Password { get; set; } = "";

        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Lozinke se ne podudaraju.")]
        [Display(Name = "Potvrda lozinke")]
        public string ConfirmPassword { get; set; } = "";

        [Display(Name = "Role")]
        public List<RoleCheckVM> Roles { get; set; } = new();
    }
}
