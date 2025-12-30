using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace PetHotel.Models
{
    public class Pet
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ime psa je obavezno")]
        public string Name { get; set; }

        // Dodaj ova polja da Index.cshtml prestane javljati greške:
        public string? Breed { get; set; }
        public string? Size { get; set; } // Ovo će odblokirati ono crno polje!
        public int BirthYear { get; set; }
        public string? MicrochipNumber { get; set; }
        public bool IsSocialized { get; set; }
        public string? PersonalNotes { get; set; }
        public bool IsActive { get; set; }

        // Ovo rješava grešku u PetsControlleru (Include(p => p.User))
        [ValidateNever]
        public string? UserId { get; set; }
        public virtual Microsoft.AspNetCore.Identity.IdentityUser? User { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }
}