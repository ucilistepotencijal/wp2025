using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace AutoServis.Models
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Unesite marku vozila.")]
        [StringLength(50, ErrorMessage = "Marka ne može imati više od 50 znakova.")]
        public string Make { get; set; } = string.Empty;

        [Required(ErrorMessage = "Unesite model vozila.")]
        [StringLength(50, ErrorMessage = "Model ne može imati više od 50 znakova.")]
        public string Model { get; set; } = string.Empty;

        [Required(ErrorMessage = "Godina proizvodnje je obavezna.")]
        [Range(1950, 2050, ErrorMessage = "Unesite ispravnu godinu proizvodnje vozila.")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Unesite registracijsku oznaku.")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Registracijska oznaka mora imati između 3 i 15 znakova.")]
        public string LicensePlate { get; set; } = string.Empty;

        [RegularExpression(@"^[A-HJ-NPR-Za-hj-npr-z0-9]{11,17}$", ErrorMessage = "VIN mora sadržavati samo slova (osim I, O, Q) i brojeve te imati između 11 i 17 znakova.")]
        [StringLength(17, MinimumLength = 11, ErrorMessage = "VIN mora imati između 11 i 17 znakova.")]
        public string? Vin { get; set; }

        [Required(ErrorMessage = "Vlasnik vozila je obavezan.")]
        public string UserId { get; set; } = string.Empty;

        [ForeignKey(nameof(UserId))]
        public IdentityUser? User { get; set; }
    }
}