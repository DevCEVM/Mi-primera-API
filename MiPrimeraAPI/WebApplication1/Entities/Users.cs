using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("users")]
public class User
{
    [Key]
    [Column("id")]
    public ushort Id { get; set; }

    [Column("username")]
    [MaxLength(45)]
    public string Username { get; set; } = null!;

    [Column("password")]
    [MaxLength(32)]
    public string Password { get; set; } = null!;

    [Column("status")]
    public byte Status { get; set; }

    [Column("fullname")]
    [MaxLength(100)]
    public string FullName { get; set; } = null!;

    [Column("system")]
    public byte System { get; set; }

    [Column("startTime1")]
    public TimeSpan? StartTime1 { get; set; }

    [Column("endTime1")]
    public TimeSpan? EndTime1 { get; set; }

    [Column("startTime2")]
    public TimeSpan? StartTime2 { get; set; }

    [Column("endTime2")]
    public TimeSpan? EndTime2 { get; set; }

    [Column("tipo")]
    public byte Tipo { get; set; }

    [Column("cedula_medica")]
    [MaxLength(30)]
    public string? CedulaMedica { get; set; }

    [Column("require_password")]
    public byte RequirePassword { get; set; }

    [Column("escuela")]
    [MaxLength(100)]
    public string? Escuela { get; set; }

    [Column("especialidad")]
    [MaxLength(100)]
    public string? Especialidad { get; set; }

    [Column("dtInserted")]
    public DateTime? DtInserted { get; set; }

    [Column("dtModified")]
    public DateTime? DtModified { get; set; }

    [Column("userInserted")]
    public short UserInserted { get; set; }

    [Column("userModified")]
    public short UserModified { get; set; }

    [Column("area")]
    [MaxLength(45)]
    public string Area { get; set; } = string.Empty;

    [Column("apaterno")]
    [MaxLength(45)]
    public string? APaterno { get; set; }

    [Column("amaterno")]
    [MaxLength(45)]
    public string? AMaterno { get; set; }

    [Column("nombre")]
    [MaxLength(45)]
    public string? Nombre { get; set; }

    [Column("beneficiario")]
    [MaxLength(180)]
    public string? Beneficiario { get; set; }

    [Column("areaId")]
    public uint? AreaId { get; set; }

    [Column("padreId")]
    public int? PadreId { get; set; }

    [Column("rfc")]
    [MaxLength(80)]
    public string? Rfc { get; set; }

    [Column("telefono1")]
    [MaxLength(80)]
    public string? Telefono1 { get; set; }

    [Column("telefono2")]
    [MaxLength(80)]
    public string? Telefono2 { get; set; }

    [Column("calle")]
    [MaxLength(70)]
    public string? Calle { get; set; }

    [Column("no_interior")]
    [MaxLength(45)]
    public string? NoInterior { get; set; }

    [Column("no_exterior")]
    [MaxLength(45)]
    public string? NoExterior { get; set; }

    [Column("colonia")]
    [MaxLength(150)]
    public string? Colonia { get; set; }

    [Column("ciudad")]
    [MaxLength(150)]
    public string? Ciudad { get; set; }

    [Column("estado")]
    [MaxLength(150)]
    public string? Estado { get; set; }

    [Column("pais")]
    [MaxLength(150)]
    public string? Pais { get; set; }

    [Column("codigo_postal")]
    [MaxLength(45)]
    public string? CodigoPostal { get; set; }

    [Column("cedula_medica2")]
    [MaxLength(80)]
    public string? CedulaMedica2 { get; set; }

    [Column("cedula_medica3")]
    [MaxLength(80)]
    public string? CedulaMedica3 { get; set; }

    [Column("especialidad2")]
    [MaxLength(150)]
    public string? Especialidad2 { get; set; }

    [Column("especialidad3")]
    [MaxLength(150)]
    public string? Especialidad3 { get; set; }

    [Column("almacenConsumo")]
    [MaxLength(150)]
    public string? AlmacenConsumo { get; set; }

    [Column("correo")]
    [MaxLength(300)]
    public string? Correo { get; set; }

    [Column("almacenPerteneceId")]
    public uint? AlmacenPerteneceId { get; set; }

    [Column("almacenPertenece")]
    [MaxLength(300)]
    public string? AlmacenPertenece { get; set; }

    [Column("perfil")]
    public uint? Perfil { get; set; }

    [Column("afkIdle")]
    public int? AfkIdle { get; set; }

    [Column("cuentaExpediente")]
    public uint? CuentaExpediente { get; set; }

    [Column("folioInternoRh")]
    [MaxLength(80)]
    public string? FolioInternoRh { get; set; }

    [Column("login")]
    public byte Login { get; set; }

    [Column("nipcortesia")]
    [MaxLength(8)]
    public string? NipCortesia { get; set; }

    [Column("rh")]
    public byte Rh { get; set; }

    [Column("num_nomina")]
    [MaxLength(10)]
    public string? NumNomina { get; set; }

    [Column("puestoID")]
    public ushort PuestoId { get; set; }

    [Column("deptoID")]
    public ushort DeptoId { get; set; }

    [Column("departamento")]
    [MaxLength(45)]
    public string? Departamento { get; set; }

    [Column("cuentaContable")]
    [MaxLength(60)]
    public string? CuentaContable { get; set; }

    [Column("areasTickets")]
    [MaxLength(150)]
    public string? AreasTickets { get; set; }

    [Column("isr")]
    public uint? Isr { get; set; }

    [Column("resico")]
    public uint? Resico { get; set; }

    [Column("curp")]
    [MaxLength(18)]
    public string? Curp { get; set; }

    [Column("docCurriculum")]
    [MaxLength(45)]
    public string? DocCurriculum { get; set; }

    [Column("docTitulo")]
    [MaxLength(45)]
    public string? DocTitulo { get; set; }

    [Column("docCedula")]
    [MaxLength(45)]
    public string? DocCedula { get; set; }

    [Column("docTituloEspecialista")]
    [MaxLength(45)]
    public string? DocTituloEspecialista { get; set; }

    [Column("docCedulaEspecialista")]
    [MaxLength(45)]
    public string? DocCedulaEspecialista { get; set; }

    [Column("docCertificacion")]
    [MaxLength(45)]
    public string? DocCertificacion { get; set; }

    [Column("docSeguro")]
    [MaxLength(45)]
    public string? DocSeguro { get; set; }

    [Column("docCartaRecomendacion")]
    [MaxLength(45)]
    public string? DocCartaRecomendacion { get; set; }

    [Column("docDiploma")]
    [MaxLength(45)]
    public string? DocDiploma { get; set; }

    [Column("registroEstatalContribuyentes")]
    [MaxLength(100)]
    public string? RegistroEstatalContribuyentes { get; set; }

    [Column("areaIdRequisiciones")]
    public uint? AreaIdRequisiciones { get; set; }

    [Column("banMedicoAutoCajaMedico")]
    public uint? BanMedicoAutoCajaMedico { get; set; }

    [Column("bancoId")]
    public uint? BancoId { get; set; }

    [Column("clabeInterbancaria")]
    [MaxLength(45)]
    public string? ClabeInterbancaria { get; set; }

    [Column("observacionesCajaMedico")]
    [MaxLength(300)]
    public string? ObservacionesCajaMedico { get; set; }
}