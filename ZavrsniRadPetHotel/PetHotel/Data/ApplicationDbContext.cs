using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PetHotel.Models; // Provjeri da se projekt stvarno zove PetHotel

namespace PetHotel.Data
{
    // IdentityDbContext nam omogućuje da imamo i korisnike i naše tablice
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Pet> Pets { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Booking>()
                .HasOne(b => b.Pet)
                .WithMany(p => p.Bookings) // Povezujemo listu iz Pet modela
                .HasForeignKey(b => b.PetId) // Koristimo POSTOJEĆI PetId
                .OnDelete(DeleteBehavior.Cascade); // Ako želiš da brisanje psa briše rezervacije
        }
    }
}