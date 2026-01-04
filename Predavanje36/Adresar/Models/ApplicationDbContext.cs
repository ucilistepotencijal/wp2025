using Microsoft.EntityFrameworkCore;

namespace Adresar.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Kontakt> Kontakti { get; set; }
    }
}
