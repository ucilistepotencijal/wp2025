using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation; // Dodano za [ValidateNever]
using System.ComponentModel.DataAnnotations;

namespace PetHotel.Models
{
    public enum BookingStatus
    {
        [Display(Name = "Rezervirano")] Scheduled,
        [Display(Name = "Pas je u hotelu")] InProgress,
        [Display(Name = "Odjavljen")] Completed,
        [Display(Name = "Otkazano")] Cancelled
    }

    public class Booking : IValidatableObject
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Datum dolaska je obavezan")]
        [Display(Name = "Check-in (Dolazak)")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Datum odlaska je obavezan")]
        [Display(Name = "Check-out (Odlazak)")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        // Logika za provjeru datuma
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (EndDate <= StartDate)
            {
                yield return new ValidationResult(
                    "Datum odlaska (Check-out) mora biti nakon datuma dolaska (Check-in).",
                    new[] { nameof(EndDate) });
            }
        }

        [Display(Name = "Dodatne napomene za ovaj boravak")]
        public string? Notes { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Display(Name = "Status rezervacije")]
        public BookingStatus Status { get; set; }

        // Veza sa psom
        [Required]
        [Display(Name = "Pas")]
        public int PetId { get; set; }

        [ValidateNever] // Sprječava grešku jer ne šaljemo cijeli objekt kroz formu
        public virtual Pet? Pet { get; set; }

        // Veza s tipom usluge
        [Required]
        [Display(Name = "Usluga")]
        public int ServiceTypeId { get; set; }

        [ValidateNever] // Sprječava grešku za tip usluge
        public virtual ServiceType? ServiceType { get; set; }

        // Vlasnik - Ovdje je bio glavni problem
        [ValidateNever] // Ovo je ključno da sustav ne traži UserId unutar forme
        public string UserId { get; set; } = string.Empty;

        [ValidateNever]
        public virtual IdentityUser? User { get; set; }
    }
}