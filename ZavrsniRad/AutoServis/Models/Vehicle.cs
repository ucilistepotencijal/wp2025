using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace AutoServis.Models
{
    public class Vehicle
    {   
        public int Id { get; set; }
        [Required(ErrorMessage = "Marka vozila je obvezna.")]
        public string Make { get; set; }
        [Required(ErrorMessage = "Model vozila je obvezan.")]
        public string Model { get; set; }
        [Required(ErrorMessage = "Godina proizvodnje je obvezna.")]
        public int Year { get; set; }
        [Required(ErrorMessage = "Registracijska oznaka je obvezna.")]
        public string LicensePlate { get; set; }
        public int CustomerId { get; set; }
        public IdentityUser Customer { get; set; }
    }
}
