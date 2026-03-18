using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("agenda")]
public class Agenda
{
    [Key]
    [Column("id")]
    public uint Id { get; set; }

    [Column("visitaID")]
    public int VisitaId { get; set; }

    [Column("tipo")]
    [MaxLength(45)]
    public string? Tipo { get; set; }

    [Column("habitacionID")]
    public ushort HabitacionId { get; set; }

    [Column("diagnostico")]
    [MaxLength(200)]
    public string? Diagnostico { get; set; }

    [Column("fecha")]
    public DateTime? Fecha { get; set; }

    [Column("duracion")]
    public ushort Duracion { get; set; }

    /// <summary>
    /// 1 = Programada, 2 = Terminada, 3 = Cancelada
    /// </summary>
    [Column("status")]
    public byte Status { get; set; }

    [Column("insert_userID")]
    public ushort InsertUserId { get; set; }

    [Column("insert_fecha")]
    public DateTime? InsertFecha { get; set; }

    [Column("cancel_userID")]
    public ushort CancelUserId { get; set; }

    [Column("cancel_fecha")]
    public DateTime? CancelFecha { get; set; }

    [Column("comentarios")]
    public string? Comentarios { get; set; }

    // Datos del paciente (snapshot)
    [Column("paterno")]
    [MaxLength(50)]
    public string? Paterno { get; set; }

    [Column("materno")]
    [MaxLength(50)]
    public string? Materno { get; set; }

    [Column("nombre")]
    [MaxLength(75)]
    public string? Nombre { get; set; }

    [Column("fecha_nacimiento")]
    public DateTime? FechaNacimiento { get; set; }

    [Column("edad")]
    public byte Edad { get; set; }

    [Column("edad_dias")]
    public byte EdadDias { get; set; }

    [Column("edad_meses")]
    public byte EdadMeses { get; set; }

    [Column("sexo")]
    [MaxLength(20)]
    public string? Sexo { get; set; }

    [Column("telefono")]
    [MaxLength(20)]
    public string? Telefono { get; set; }

    [Column("peso")]
    [MaxLength(6)]
    public string? Peso { get; set; }

    [Column("cancel_motivo")]
    [MaxLength(45)]
    public string CancelMotivo { get; set; } = string.Empty;

    // Tiempos clínicos
    [Column("inicio_sala")]
    public DateTime? InicioSala { get; set; }

    [Column("inicio_anestesia")]
    public DateTime? InicioAnestesia { get; set; }

    [Column("inicio_cx")]
    public DateTime? InicioCx { get; set; }

    [Column("fin_sala")]
    public DateTime? FinSala { get; set; }

    [Column("fin_anestesia")]
    public DateTime? FinAnestesia { get; set; }

    [Column("fin_cx")]
    public DateTime? FinCx { get; set; }

    [Column("tipo_herida")]
    [MaxLength(45)]
    public string? TipoHerida { get; set; }

    [Column("cierre_userID")]
    public ushort CierreUserId { get; set; }

    [Column("cierre_fecha")]
    public DateTime? CierreFecha { get; set; }

    [Column("cx_segura")]
    public bool CxSegura { get; set; }

    [Column("val_enfermeria")]
    public byte ValEnfermeria { get; set; }

    // Relaciones (IDs)
    [Column("dxID")]
    public uint DxId { get; set; }

    [Column("medicoID")]
    public uint MedicoId { get; set; }

    [Column("anestesiologoID")]
    public uint AnestesiologoId { get; set; }

    [Column("medico")]
    [MaxLength(100)]
    public string? Medico { get; set; }

    [Column("anestesiologo")]
    [MaxLength(100)]
    public string? Anestesiologo { get; set; }

    [Column("instrumentistaID")]
    public uint InstrumentistaId { get; set; }

    [Column("instrumentista")]
    [MaxLength(100)]
    public string? Instrumentista { get; set; }

    [Column("tipo_intervencion")]
    [MaxLength(1)]
    public string? TipoIntervencion { get; set; }

    [Column("tipo_anestesia")]
    [MaxLength(45)]
    public string? TipoAnestesia { get; set; }

    [Column("proveedorID")]
    public ushort ProveedorId { get; set; }

    [Column("aseguradoraID")]
    public ushort AseguradoraId { get; set; }

    [Column("telMedico")]
    [MaxLength(20)]
    public string? TelMedico { get; set; }

    [Column("telProveedor")]
    [MaxLength(20)]
    public string? TelProveedor { get; set; }

    [Column("comprasSeenBy")]
    public ushort ComprasSeenBy { get; set; }

    [Column("comprasSeen")]
    public byte ComprasSeen { get; set; }

    [Column("comprasSeenDate")]
    public DateTime? ComprasSeenDate { get; set; }

    [Column("notaPostID")]
    public uint NotaPostId { get; set; }

    [Column("turno")]
    [MaxLength(45)]
    public string? Turno { get; set; }

    [Column("estanciaHospitalaria")]
    [MaxLength(100)]
    public string? EstanciaHospitalaria { get; set; }

    [Column("telCirujano")]
    [MaxLength(20)]
    public string? TelCirujano { get; set; }

    [Column("telAnestesiologo")]
    [MaxLength(20)]
    public string? TelAnestesiologo { get; set; }

    [Column("pediatraId")]
    public uint PediatraId { get; set; }

    [Column("pediatra")]
    [MaxLength(180)]
    public string? Pediatra { get; set; }

    [Column("neonatologoId")]
    public uint NeonatologoId { get; set; }

    [Column("neonatologo")]
    [MaxLength(180)]
    public string? Neonatologo { get; set; }
}