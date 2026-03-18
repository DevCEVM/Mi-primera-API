using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data
{
    public class LazaroDbContext : DbContext
    {
        public LazaroDbContext(DbContextOptions<LazaroDbContext> options) : base(options) { }

        // Núcleo clínico
        public DbSet<Paciente> Pacientes { get; set; } = default!;
        public DbSet<Visita> Visitas { get; set; } = default!;
        public DbSet<Agenda> Agenda { get; set; } = default!;
        public DbSet<AgendaCirugia> AgendaCirugias { get; set; } = default!;
        public DbSet<NotaPostoperatoria> NotasPostoperatorias { get; set; } = default!;
        public DbSet<NotaEgreso> NotasEgreso { get; set; } = default!;

        // Médicos (users)
        public DbSet<User> Users { get; set; } = default!;
        public DbSet<UserEspecialidad> UsersEspecialidades { get; set; } = default!;
        public DbSet<Especialidad> Especialidades { get; set; } = default!;

        // Cuentas / facturación
        public DbSet<CuentaPaciente> CuentasPacientes { get; set; } = default!;
        public DbSet<ArticuloCuenta> ArticulosCuenta { get; set; } = default!;
        public DbSet<Factura> Facturas { get; set; } = default!;

        // Catálogos
        public DbSet<Articulo> Articulos { get; set; } = default!;
        public DbSet<TipoArticulo> TiposArticulos { get; set; } = default!;
        public DbSet<Familia> Familias { get; set; } = default!;
        public DbSet<Habitacion> Habitaciones { get; set; } = default!;
        public DbSet<ServicioMedico> ServiciosMedicos { get; set; } = default!;


    }
}