using Microsoft.AspNetCore.Identity;

namespace AutoServis.Models
{
    public class Vehicle
    {   
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string LicensePlate { get; set; }
        public int CustomerId { get; set; }
        public IdentityUser Customer { get; set; }
    }
}
