using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace AutoServis.Models
{
    public class Appointment : IValidatableObject
    {
        public int Id { get; set; }

        [Display(Name = "Usluga")]
        [Required(ErrorMessage = "Odaberite uslugu.")]
        public int ServiceTypeId { get; set; }

        public ServiceType? ServiceType { get; set; }

        [Required]
        public string UserId { get; set; } = string.Empty;

        [Display(Name = "Kupac")]
        public IdentityUser? User { get; set; }

        [Display(Name = "Vozilo")]
        [Required(ErrorMessage = "Vozilo je obavezno.")]
        public int VehicleId { get; set; }

        public Vehicle? Vehicle { get; set; }

        [Display(Name = "Datum i vrijeme")]
        [Required(ErrorMessage = "Unesi datum i vrijeme termina.")]
        [DataType(DataType.DateTime)]
        public DateTime ScheduledDate { get; set; }

        [Display(Name = "Status")]
        [Required]
        public AppointmentStatus Status { get; set; } = AppointmentStatus.Scheduled;

        [Display(Name = "Napomena")]
        public string? Notes { get; set; }

        [Display(Name = "Datum i vrijeme kreiranja")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (ScheduledDate == default || ScheduledDate == DateTime.MinValue)
            {
                yield return new ValidationResult(
                    "Datum i vrijeme termina nisu ispravno postavljeni.",
                    new[] { nameof(ScheduledDate) });
                yield break;
            }

            if (ScheduledDate < DateTime.Now)
            {
                yield return new ValidationResult(
                    "Datum i vrijeme termina ne smiju biti u prošlosti.",
                    new[] { nameof(ScheduledDate) });
            }
        }
    }
}
