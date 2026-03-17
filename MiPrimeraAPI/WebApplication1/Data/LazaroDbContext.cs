
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data
{
    public class LazaroDbContext : DbContext
    {
        public LazaroDbContext(DbContextOptions<LazaroDbContext> options) : base(options) { }

        // Aquí luego agregas tus DbSet<Entidad> para la base 'Lazaro'
        // public DbSet<Paciente> Pacientes { get; set; } = default!;
    }
}
