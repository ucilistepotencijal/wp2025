using Microsoft.AspNetCore.Identity;
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

    public class Booking
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

        [Display(Name = "Dodatne napomene za ovaj boravak")]
        public string? Notes { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Display(Name = "Status rezervacije")]
        public BookingStatus Status { get; set; } = BookingStatus.Scheduled;

        // Veza sa psom
        [Required]
        [Display(Name = "Pas")]
        public int PetId { get; set; }
        public virtual Pet? Pet { get; set; }

        // Veza s tipom usluge
        [Required]
        [Display(Name = "Usluga")]
        public int ServiceTypeId { get; set; }
        public virtual ServiceType? ServiceType { get; set; }

        // Vlasnik
        [Required]
        public string UserId { get; set; } = string.Empty;
        public virtual IdentityUser? User { get; set; }
    }
}