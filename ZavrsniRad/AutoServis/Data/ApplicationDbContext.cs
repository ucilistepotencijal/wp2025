using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AutoServis.Data
{
    public class ApplicationDbContext: IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<AutoServis.Models.ServiceType> ServiceTypes { get; set; }
        public DbSet<AutoServis.Models.Vehicle> Vehicles { get; set; }
        public DbSet<AutoServis.Models.Appoitment> Appoitments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<AutoServis.Models.ServiceType>()
                .Property(s => s.Price)
                .HasColumnType("decimal(10,2)");

            builder.Entity<AutoServis.Models.ServiceType>()
                .HasIndex(st => st.Name)
                .IsUnique();

            builder.Entity<AutoServis.Models.ServiceType>().HasData(
                new AutoServis.Models.ServiceType { Id = 1, Name = "Servis ulja i filtera", Price = 299.00m },
                new AutoServis.Models.ServiceType { Id = 2, Name = "Zamjena kočionih pločica", Price = 450.00m },
                new AutoServis.Models.ServiceType { Id = 3, Name = "Balansiranje i centriranje kotača", Price = 120.00m },
                new AutoServis.Models.ServiceType { Id = 4, Name = "Dijagnostika motora", Price = 250.00m },
                new AutoServis.Models.ServiceType { Id = 5, Name = "Zamjena remena i napinjača", Price = 850.00m },
                new AutoServis.Models.ServiceType { Id = 6, Name = "Servis klima-uređaja (punjenje)", Price = 450.00m },
                new AutoServis.Models.ServiceType { Id = 7, Name = "Zamjena akumulatora", Price = 380.00m },
                new AutoServis.Models.ServiceType { Id = 8, Name = "Sezonska zamjena guma (montaža + balans)", Price = 160.00m },
                new AutoServis.Models.ServiceType { Id = 9, Name = "Opći servis (pregled i održavanje)", Price = 520.00m },
                new AutoServis.Models.ServiceType { Id = 10, Name = "Pranje i čišćenje interijera", Price = 120.00m }
            );

            builder.Entity<AutoServis.Models.Appoitment>()
                .HasOne(a => a.ServiceType)
                .WithMany()
                .HasForeignKey(a => a.ServiceTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<AutoServis.Models.Appoitment>()
                .HasOne(a => a.Vehicle)
                .WithMany()
                .HasForeignKey(a => a.VehicleId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<AutoServis.Models.Appoitment>()
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
