using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace Validacije.Models
{
    [NeViseOdTriDana(ErrorMessage = "Datum računa ne smije biti stariji od tri dana!")]
    public class MetaRacun
    {
        [Required(ErrorMessage = "Broj računa je obavezan!")]
        [StringLength(10, MinimumLength = 6, ErrorMessage = "Broj računa mora biti između 6 i 10 znakova!")]
        [Display(Name = "Broj računa")]
        public string BrojRacuna { get; set; }
        [Required(ErrorMessage = "Datum je obavezan!")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "Datum računa")]
        public DateTime? DatumRacuna { get; set; }
        [Required(ErrorMessage = "Zaposlenik je obavezan!")]
        public string Zaposlenik { get; set; }
        [Required(ErrorMessage = "Kupac je obavezan!")]
        [CompareAttribute("Zaposlenik", ErrorMessage = "Kupac i zaposlenik ne smiju biti isti!")] //ToDo
        public string Kupac { get; set; }
        [Required(ErrorMessage = "Cijena je obavezna!")]
        [Range(0.04, 1000000, ErrorMessage = "Cijena mora biti veća od 0,04 EUR i manja od 100.000,00 EUR!")]
        public decimal? Cijena { get; set; }
    }
}
