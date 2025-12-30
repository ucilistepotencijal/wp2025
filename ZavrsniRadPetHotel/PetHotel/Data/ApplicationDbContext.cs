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

            // Isključujemo automatsko brisanje rezervacija kada se obriše pas
            // kako bismo izbjegli "multiple cascade paths" grešku
            modelBuilder.Entity<Booking>()
                .HasOne(b => b.Pet)
                .WithMany() // Ako pas ima listu rezervacija, stavi .WithMany(p => p.Bookings)
                .HasForeignKey(b => b.PetId)
                .OnDelete(DeleteBehavior.Restrict); // OVO rješava grešku 1785
        }
    }
}