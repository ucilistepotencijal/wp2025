using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace AutoServis.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Marka vozila je obavezna.")]
        public string Make { get; set; }
        [Required(ErrorMessage = "Model vozila je obavezan.")]
        public string Model { get; set; }
        [Required(ErrorMessage = "Godina proizvodnje je obavezna.")]
        public int Year { get; set; }
        [Required(ErrorMessage = "Registracijska oznaka je obavezna.")]
        public string LicensePlate { get; set; }
        public int CustomerId { get; set; }
        public IdentityUser Customer { get; set; }
    }
}
