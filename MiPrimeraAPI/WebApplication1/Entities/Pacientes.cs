using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("pacientes")]
public class Paciente
{
    [Key]
    [Column("id")]
    public uint Id { get; set; }

    [Column("paterno")]
    [MaxLength(50)]
    public string Paterno { get; set; } = string.Empty;

    [Column("materno")]
    [MaxLength(50)]
    public string Materno { get; set; } = string.Empty;

    [Column("nombre")]
    [MaxLength(75)]
    public string Nombre { get; set; } = string.Empty;

    [Column("fullname")]
    [MaxLength(175)]
    public string FullName { get; set; } = string.Empty;

    [Column("fecha_nacimiento")]
    public DateTime? FechaNacimiento { get; set; }

    [Column("edad")]
    public byte? Edad { get; set; }

    [Column("edad_dias")]
    public byte? EdadDias { get; set; }

    [Column("edad_meses")]
    public byte EdadMeses { get; set; }

    [Column("sexo")]
    [MaxLength(15)]
    public string? Sexo { get; set; }

    [Column("curp")]
    [MaxLength(25)]
    public string? Curp { get; set; }

    [Column("rfc")]
    [MaxLength(15)]
    public string? Rfc { get; set; }

    [Column("servicio_medico")]
    [MaxLength(100)]
    public string? ServicioMedico { get; set; }

    [Column("servicioMedicoID")]
    public uint ServicioMedicoId { get; set; }

    [Column("poliza")]
    [MaxLength(20)]
    public string? Poliza { get; set; }

    [Column("correo")]
    [MaxLength(100)]
    public string? Correo { get; set; }

    [Column("telefono_casa")]
    [MaxLength(20)]
    public string? TelefonoCasa { get; set; }

    [Column("telefono_trabajo")]
    [MaxLength(20)]
    public string? TelefonoTrabajo { get; set; }

    [Column("telefono_movil1")]
    [MaxLength(20)]
    public string? TelefonoMovil1 { get; set; }

    [Column("telefono_movil2")]
    [MaxLength(20)]
    public string? TelefonoMovil2 { get; set; }

    // Dirección
    [Column("calle")]
    [MaxLength(70)]
    public string? Calle { get; set; }

    [Column("codigo_postal")]
    [MaxLength(45)]
    public string? CodigoPostal { get; set; }

    [Column("no_exterior")]
    [MaxLength(45)]
    public string? NoExterior { get; set; }

    [Column("no_interior")]
    [MaxLength(45)]
    public string? NoInterior { get; set; }

    [Column("colonia")]
    [MaxLength(70)]
    public string? Colonia { get; set; }

    [Column("ciudad")]
    [MaxLength(70)]
    public string? Ciudad { get; set; }

    [Column("estado")]
    [MaxLength(75)]
    public string? Estado { get; set; }

    [Column("pais")]
    [MaxLength(200)]
    public string? Pais { get; set; }

    // Información social
    [Column("tipo_domicilio")]
    [MaxLength(45)]
    public string? TipoDomicilio { get; set; }

    [Column("escolaridad")]
    [MaxLength(60)]
    public string? Escolaridad { get; set; }

    [Column("ocupacion")]
    [MaxLength(45)]
    public string? Ocupacion { get; set; }

    [Column("religion")]
    [MaxLength(60)]
    public string? Religion { get; set; }

    [Column("grupo_etnico")]
    [MaxLength(60)]
    public string? GrupoEtnico { get; set; }

    [Column("nivel_socioeconomico")]
    [MaxLength(75)]
    public string? NivelSocioeconomico { get; set; }

    [Column("estado_civil")]
    [MaxLength(60)]
    public string? EstadoCivil { get; set; }

    [Column("nacionalidad")]
    [MaxLength(45)]
    public string? Nacionalidad { get; set; }

    // Datos administrativos
    [Column("status")]
    public byte Status { get; set; }

    [Column("expediente")]
    [MaxLength(30)]
    public string? Expediente { get; set; }

    [Column("visitas")]
    public ushort Visitas { get; set; }

    [Column("fn_desconocida")]
    public byte FechaNacimientoDesconocida { get; set; }

    [Column("incognito")]
    public byte Incognito { get; set; }

    [Column("prefijo")]
    [MaxLength(10)]
    public string? Prefijo { get; set; }

    [Column("es_externo")]
    public bool EsExterno { get; set; }

    [Column("particular")]
    public uint? Particular { get; set; }

    [Column("es_empleado")]
    public bool EsEmpleado { get; set; }

    [Column("parentID")]
    public uint ParentId { get; set; }

    [Column("preingreso")]
    public byte Preingreso { get; set; }

    [Column("pasaporte")]
    [MaxLength(15)]
    public string? Pasaporte { get; set; }

    [Column("tipoPoliza")]
    [MaxLength(32)]
    public string? TipoPoliza { get; set; }
}