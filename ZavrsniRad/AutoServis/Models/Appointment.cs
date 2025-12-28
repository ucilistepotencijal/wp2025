using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace AutoServis.Models
{
    public class Appointment : IValidatableObject
    {
        public int Id { get; set; }

        
        public int ServiceTypeId { get; set; }

        [Display(Name = "Usluga")]
        [Required(ErrorMessage = "Odaberute uslugu.")]

        public ServiceType? ServiceType { get; set; }
        
        public string UserId { get; set; } = string.Empty;

        [Display(Name = "Kupac")]
        public IdentityUser? User { get; set; }

        public int VehicleId { get; set; }
        [Display(Name = "Vozilo")]
        [Required(ErrorMessage = "Vozilo je obavezno.")]

        public Vehicle? Vehicle { get; set; }
        [Display(Name = "Datum i vrijeme")]

        [Required(ErrorMessage = "Unesi datum i vrijeme termina.")]
        [DataType(DataType.DateTime)]
        public DateTime ScheduledDate { get; set; }

        [Display(Name = "Status")]
        [Required]
        public AppointmentStatus Status { get; set; }

        [Display(Name = "Napomena")]
        public string? Notes { get; set; }

        [Display(Name = "Datum i vrijeme kreiranja")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            // Reject unset/default dates
            if (ScheduledDate == default || ScheduledDate == DateTime.MinValue)
            {
                yield return new ValidationResult(
                    "Datum i vrijeme termina nisu ispravno postavljeni.",
                    new[] { nameof(ScheduledDate) });
                yield break;
            }

            // Compare using UTC to match CreatedAt
            if (ScheduledDate < DateTime.Now)
            {
                yield return new ValidationResult(
                    "Datum i vrijeme termina ne smiju biti u prošlosti.",
                    new[] { nameof(ScheduledDate) });
            }
        }
    }
}
