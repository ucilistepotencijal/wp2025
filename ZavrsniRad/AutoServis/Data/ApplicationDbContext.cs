using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AutoServis.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<AutoServis.Models.ServiceType> ServiceTypes { get; set; }
        public DbSet<AutoServis.Models.Appointment> Appointments { get; set; }
        public DbSet<AutoServis.Models.Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<AutoServis.Models.ServiceType>()
                .Property(st => st.Price)
                .HasColumnType("decimal(10,2)");

            builder.Entity<AutoServis.Models.ServiceType>()
                .HasIndex(st => st.Name)
                .IsUnique();

            builder.Entity<AutoServis.Models.ServiceType>().HasData(
                new Models.ServiceType
                {
                    Id = 1,
                    Name = "Zamjena ulja",
                    Description = "Kompletna zamjena motornog ulja s promjenom filtera.",
                    DurationMinutes = 30,
                    Price = 79.99m,
                    IsActive = true
                },
                new Models.ServiceType
                {
                    Id = 2,
                    Name = "Balansiranje i rotacija kotača",
                    Description = "Balansiranje i rotacija kotača radi ujednačenog trošenja i bolje upravljivosti.",
                    DurationMinutes = 45,
                    Price = 49.99m,
                    IsActive = true
                },
                new Models.ServiceType
                {
                    Id = 3,
                    Name = "Poravnavanje kotača (geometrija)",
                    Description = "Precizno poravnavanje kotača za stabilnu vožnju i smanjenu potrošnju guma.",
                    DurationMinutes = 60,
                    Price = 99.99m,
                    IsActive = true
                },
                new Models.ServiceType
                {
                    Id = 4,
                    Name = "Zamjena kočionih pločica",
                    Description = "Provjera i zamjena prednjih/stražnjih kočionih pločica po potrebi.",
                    DurationMinutes = 50,
                    Price = 129.99m,
                    IsActive = true
                },
                new Models.ServiceType
                {
                    Id = 5,
                    Name = "Dijagnostika motora",
                    Description = "Elektronička dijagnostika motora, čitanje grešaka i prijedlog popravaka.",
                    DurationMinutes = 40,
                    Price = 59.99m,
                    IsActive = true
                },
                new Models.ServiceType
                {
                    Id = 6,
                    Name = "Servis klima uređaja",
                    Description = "Punjenje i provjera sustava klima uređaja, uklanjanje nečistoća i ispitivanje učinka.",
                    DurationMinutes = 70,
                    Price = 149.99m,
                    IsActive = true
                }
            );

            builder.Entity<AutoServis.Models.Appointment>()
                .HasOne(a => a.ServiceType)
                .WithMany()
                .HasForeignKey(a => a.ServiceTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<AutoServis.Models.Appointment>()
                .HasOne(a => a.Vehicle)
                .WithMany()
                .HasForeignKey(a => a.VehicleId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<AutoServis.Models.Appointment>()
                .HasOne(a => a.Customer)
                .WithMany()
                .HasForeignKey(a => a.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<AutoServis.Models.Vehicle>()
                .HasOne(v => v.Customer)
                .WithMany()
                .HasForeignKey(v => v.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
