using System.ComponentModel.DataAnnotations;

namespace Adresar.Models
{
    public class Kontakt
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(25, ErrorMessage = "Ime ne smije biti veće od 25 znakova")]
        public string Ime { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Prezime ne smije biti veće od 50 znakova")]
        public string Prezime { get; set; }
        [StringLength(100, ErrorMessage = "Adresa ne smije biti veća od 100 znakova")]
        public string Adresa { get; set; }
        [StringLength(20, ErrorMessage = "Telefon ne smije biti veći od 20 znakova")]
        public string Telefon { get; set; }
        [StringLength(20, ErrorMessage = "Mobitel ne smije biti veći od 20 znakova")]
        public string Mobitel { get; set; }
        [StringLength(30, ErrorMessage = "Email ne smije biti veći od 30 znakova")]
        public string Email { get; set; }
        public string Napomena { get; set; }
        public bool Aktivan { get; set; }
    }
}
