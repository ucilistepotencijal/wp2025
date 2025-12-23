using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AutoServis.Models
{
    public class ServiceType
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Naziv usluge je obavezan.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Naziv usluge mora imati od 3 do 100 znakova.")]
        public string Name { get; set; } = string.Empty;

        [StringLength(500, ErrorMessage = "Opis usluge ne smije prelaziti 500 znakova.")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Trajanje usluge je obavezno.")]
        [Range(10, 600, ErrorMessage = "Trajanje usluge mora biti između 10 i 600 minuta.")]
        public int DurationMinutes { get; set; }

        [Required(ErrorMessage = "Cijena usluge je obavezna.")]
        [Range(typeof(decimal), "0", "10000", ErrorMessage = "Cijena mora biti između 0 i 10.000,00 EUR.")]
        [DataType(DataType.Currency)]
        [Precision(18, 2)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; } = 0m;

        public bool IsActive { get; set; } = true;
    }
}