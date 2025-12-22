using System.ComponentModel.DataAnnotations;

namespace AutoServis.Models
{
    public class ServiceType
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Naziv usluge je obvezan.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Naziv usluge mora imati od 3 do 100 znakova.")]
        public string Name { get; set; }

        [StringLength(500, ErrorMessage = "Opis usluge ne smije prelaziti 500 znakova.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Trajanje usluge je obvezno.")]
        [Range(10, 600, ErrorMessage = "Trajanje usluge mora biti između 10 i 600 minuta.")]
        public int DurationMinutes { get; set; }

        [Required(ErrorMessage = "Cijena usluge je obvezna.")]
        [Range(0, 10000, ErrorMessage = "Cijena usluge mora biti između 0 i 10.000,00 eur.")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public bool IsActive { get; set; } = true;
    }
}
