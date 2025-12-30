using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetHotel.Models
{
    public class ServiceType
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Naziv usluge je obavezan")]
        [Display(Name = "Naziv usluge (npr. Noćenje - Veliki pas)")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Što usluga uključuje")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Cijena je obavezna")]
        [Display(Name = "Cijena po danu/tretmanu (EUR)")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Display(Name = "Aktivna ponuda")]
        public bool IsActive { get; set; } = true;
    }
}