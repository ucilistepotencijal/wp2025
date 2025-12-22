using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace AutoServis.Models
{
    public class Appoitment: IValidatableObject
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Vrsta usluge je obvezna.")]
        public int ServiceTypeId { get; set; }
        public ServiceType ServiceType { get; set; }
        public int CustomerId { get; set; }
        [Required(ErrorMessage = "Kupac je obvezan.")]
        public IdentityUser Customer { get; set; }
        [Required(ErrorMessage = "Vozilo je obvezno.")]
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
        [Required(ErrorMessage = "Unesi datum i vrijeme termina.")]
        public DateTime ScheduledDate { get; set; }
        [Required]
        public AppoitmentStatus Status { get; set; }
        public string? Notes { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (ScheduledDate < DateTime.UtcNow)
            {
                yield return new ValidationResult(
                    "Datum i vrijeme termina ne mogu biti u prošlosti.",
                    new[] { nameof(ScheduledDate) });
            }
        }
    }
}
