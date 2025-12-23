using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace AutoServis.Models
{
    public class Vehicle
    {
        public int Id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Unesite marku vozila.")]
        public string? Make { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Unesite model vozila.")]
        public string? Model { get; set; }

        [Range(1950, 2050, ErrorMessage = "Unesite ispravnu godinu proizvodnje vozila.")]
        [Required(ErrorMessage = "Godina proizvodnje je obavezna.")]
        public int Year { get; set; }

        [StringLength(15, MinimumLength = 3)]
        [Required(ErrorMessage = "Unesite registracijsku oznaku.")]
        public string? LicensePlate { get; set; }

        [RegularExpression(@"^[A-HJ-NPR-Z0-9]+$", ErrorMessage = "VIN mora sadržavati samo slova (osim I, O, Q) i brojeve.")]
        [StringLength(17, MinimumLength = 11, ErrorMessage = "VIN mora imati između 11 i 17 znakova.")]
        public string? Vin { get; set; }
        [Required(ErrorMessage = "Vlasnik vozila je obavezan.")]
        public string UserId { get; set; } = string.Empty;
        public IdentityUser? User { get; set; }
    }
}