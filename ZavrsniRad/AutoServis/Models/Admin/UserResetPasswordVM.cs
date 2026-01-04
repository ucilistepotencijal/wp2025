using System.ComponentModel.DataAnnotations;

namespace AutoServis.Models.Admin
{
    public class UserResetPasswordVM
    {
        public string Id { get; set; } = "";

        [Display(Name = "Email")]
        public string Email { get; set; } = "";

        [Required(ErrorMessage = "Nova lozinka je obavezna.")]
        [MinLength(6, ErrorMessage = "Lozinka mora imati barem 6 znakova.")]
        [DataType(DataType.Password)]
        [Display(Name = "Nova lozinka")]
        public string NewPassword { get; set; } = "";

        [Required(ErrorMessage = "Potvrda lozinke je obavezna.")]
        [DataType(DataType.Password)]
        [Compare(nameof(NewPassword), ErrorMessage = "Lozinke se ne podudaraju.")]
        [Display(Name = "Potvrda lozinke")]
        public string ConfirmPassword { get; set; } = "";
    }
}
