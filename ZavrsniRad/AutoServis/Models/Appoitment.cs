using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace AutoServis.Models
{
    public class Appointment : IValidatableObject
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Vrsta usluge je obavezna.")]
        public int ServiceTypeId { get; set; }
        public ServiceType? ServiceType { get; set; }


        [Required(ErrorMessage = "Kupac je obavezan.")]
        public string UserId { get; set; } = string.Empty;
        public IdentityUser? User { get; set; }


        [Required(ErrorMessage = "Vozilo je obavezno.")]
        public int VehicleId { get; set; }
        public Vehicle? Vehicle { get; set; }

        [Required(ErrorMessage = "Unesi datum i vrijeme termina.")]
        public DateTime ScheduledDate { get; set; }

        [Required]
        public AppoitmentStatus Status { get; set; }

        public string? Notes { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (ScheduledDate < DateTime.Now)
            {
                yield return new ValidationResult(
                    "Datum i vrijeme termina ne smiju biti u prošlosti.",
                    new[] { nameof(ScheduledDate) });
            }
        }
    }
}