using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("em_nota_egreso")]
public class NotaEgreso
{
    [Key]
    [Column("id")]
    public uint Id { get; set; }

    [Column("visitaID")]
    public uint VisitaId { get; set; }

    [Column("pacienteID")]
    public uint PacienteId { get; set; }

    [Column("status")]
    public byte Status { get; set; }

    [Column("usuarioId")]
    public ushort UsuarioId { get; set; }

    [Column("medicoID")]
    public ushort MedicoId { get; set; }

    [Column("dtInserted")]
    public DateTime? DtInserted { get; set; }

    [Column("dtApproved")]
    public DateTime? DtApproved { get; set; }

    [Column("dtModified")]
    public DateTime? DtModified { get; set; }

    [Column("fecha_elaboracion")]
    public DateTime? FechaElaboracion { get; set; }

    [Column("fecha_egreso")]
    public DateTime? FechaEgreso { get; set; }

    [Column("motivo_egreso")]
    [MaxLength(45)]
    public string? MotivoEgreso { get; set; }

    [Column("certificado_defuncion")]
    [MaxLength(45)]
    public string? CertificadoDefuncion { get; set; }

    [Column("dxID")]
    public uint DxId { get; set; }

    [Column("dx")]
    [MaxLength(100)]
    public string? Dx { get; set; }

    [Column("estado")]
    public string? Estado { get; set; }

    [Column("manejo")]
    public string? Manejo { get; set; }

    [Column("problemas")]
    public string? Problemas { get; set; }

    [Column("plan")]
    public string? Plan { get; set; }

    [Column("svID")]
    public int? SvId { get; set; }

    [Column("signos")]
    public string? Signos { get; set; }

    [Column("recomendaciones")]
    public string? Recomendaciones { get; set; }

    [Column("riesgo")]
    public string? Riesgo { get; set; }

    [Column("estudios")]
    public string? Estudios { get; set; }

    [Column("pronostico_vida")]
    [MaxLength(25)]
    public string? PronosticoVida { get; set; }

    [Column("pronostico_funcion")]
    [MaxLength(25)]
    public string? PronosticoFuncion { get; set; }

    [Column("locked")]
    public bool Locked { get; set; }

    [Column("fecha_ingreso")]
    public DateTime? FechaIngreso { get; set; }

    [Column("habitacion")]
    [MaxLength(15)]
    public string? Habitacion { get; set; }

    [Column("edad")]
    [MaxLength(5)]
    public string? Edad { get; set; }

    [Column("dxIDIngreso")]
    public uint DxIdIngreso { get; set; }

    [Column("dxIngreso")]
    [MaxLength(100)]
    public string? DxIngreso { get; set; }

    [Column("dias")]
    public ushort Dias { get; set; }

    [Column("autorizoID")]
    public ushort AutorizoId { get; set; }

    [Column("footer_left")]
    [MaxLength(15)]
    public string? FooterLeft { get; set; }

    [Column("footer_right")]
    [MaxLength(15)]
    public string? FooterRight { get; set; }

    [Column("dxs")]
    public string? Dxs { get; set; }
}