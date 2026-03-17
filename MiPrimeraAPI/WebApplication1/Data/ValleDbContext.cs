using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data
{
    public class ValleDbContext : DbContext
    {
        public ValleDbContext(DbContextOptions<ValleDbContext> options) : base(options) { }

        // Aquí luego agregas tus DbSet<Entidad> para la base 'sah_hrsj_valle'
        // public DbSet<Cita> Citas { get; set; } = default!;
    }
}