using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace PetHotel.Models
{
    public enum DogSize
    {
        [Display(Name = "Mali (do 10kg)")] Small,
        [Display(Name = "Srednji (10-25kg)")] Medium,
        [Display(Name = "Veliki (preko 25kg)")] Large
    }

    public class Pet
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ime psa je obavezno")]
        [Display(Name = "Ime psa")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Pasmina")]
        public string? Breed { get; set; }

        [Required(ErrorMessage = "Odaberite veličinu psa")]
        [Display(Name = "Veličina psa")]
        public DogSize Size { get; set; }

        [Display(Name = "Godina rođenja")]
        public int BirthYear { get; set; }

        [Display(Name = "Broj mikročipa")]
        public string? MicrochipNumber { get; set; }

        [Display(Name = "Socijaliziran (slaže se s drugima)")]
        public bool IsSocialized { get; set; } = true;

        [Display(Name = "Napomene o psu (alergije, strahovi...)")]
        public string? PersonalNotes { get; set; }

        public bool IsActive { get; set; } = true;

        [Required]
        public string UserId { get; set; } = string.Empty;
        public virtual IdentityUser? User { get; set; }
    }
}