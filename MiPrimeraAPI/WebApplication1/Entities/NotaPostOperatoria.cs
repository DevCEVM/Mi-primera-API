using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("em_nota_postoperatoria")]
public class NotaPostoperatoria
{
    [Key]
    [Column("id")]
    public uint Id { get; set; }

    [Column("visitaID")]
    public uint VisitaId { get; set; }

    [Column("pacienteID")]
    public uint PacienteId { get; set; }

    [Column("usuarioId")]
    public ushort UsuarioId { get; set; }

    [Column("dtInserted")]
    public DateTime? DtInserted { get; set; }

    [Column("dtApproved")]
    public DateTime? DtApproved { get; set; }

    [Column("dtModified")]
    public DateTime? DtModified { get; set; }

    [Column("fecha")]
    public DateTime? Fecha { get; set; }

    [Column("status")]
    public byte Status { get; set; }

    [Column("locked")]
    public bool Locked { get; set; }

    [Column("dxID_pre")]
    public ushort DxIdPre { get; set; }

    [Column("dx_pre")]
    [MaxLength(100)]
    public string? DxPre { get; set; }

    [Column("op_planeada")]
    [MaxLength(150)]
    public string? OpPlaneada { get; set; }

    [Column("op_realizada")]
    [MaxLength(150)]
    public string? OpRealizada { get; set; }

    [Column("dxID_post")]
    public ushort DxIdPost { get; set; }

    [Column("dx_post")]
    [MaxLength(100)]
    public string? DxPost { get; set; }

    [Column("inicio")]
    public DateTime? Inicio { get; set; }

    [Column("termino")]
    public DateTime? Termino { get; set; }

    [Column("herida")]
    [MaxLength(100)]
    public string? Herida { get; set; }

    [Column("tecnica")]
    public string? Tecnica { get; set; }

    [Column("hallazgos")]
    public string? Hallazgos { get; set; }

    [Column("conteo_gasas")]
    [MaxLength(50)]
    public string? ConteoGasas { get; set; }

    [Column("conteo_compresas")]
    [MaxLength(50)]
    public string? ConteoCompresas { get; set; }

    [Column("conteo_sangrado")]
    [MaxLength(50)]
    public string? ConteoSangrado { get; set; }

    [Column("conteo_transfusiones")]
    [MaxLength(50)]
    public string? ConteoTransfusiones { get; set; }

    [Column("incidentes")]
    public string? Incidentes { get; set; }

    [Column("estado")]
    public string? Estado { get; set; }

    [Column("plan")]
    public string? Plan { get; set; }

    [Column("pronostico")]
    public string? Pronostico { get; set; }

    [Column("laboratorios")]
    public string? Laboratorios { get; set; }

    [Column("radiologia")]
    public string? Radiologia { get; set; }

    [Column("patologia")]
    public string? Patologia { get; set; }

    [Column("muestra")]
    [MaxLength(2)]
    public string? Muestra { get; set; }

    [Column("patologo")]
    [MaxLength(100)]
    public string? Patologo { get; set; }

    [Column("otros_hallazgos")]
    public string? OtrosHallazgos { get; set; }

    [Column("instrumentistaID")]
    public ushort InstrumentistaId { get; set; }

    [Column("instrumentista")]
    public string? Instrumentista { get; set; }

    [Column("anestesiologoID")]
    public ushort AnestesiologoId { get; set; }

    [Column("anestesiologo")]
    public string? Anestesiologo { get; set; }

    [Column("circulanteID")]
    public ushort CirculanteId { get; set; }

    [Column("circulante")]
    public string? Circulante { get; set; }

    [Column("medicoID")]
    public ushort MedicoId { get; set; }

    [Column("medico")]
    [MaxLength(100)]
    public string? Medico { get; set; }

    [Column("ayudantes")]
    public string? Ayudantes { get; set; }

    [Column("conteo_instrumental")]
    [MaxLength(45)]
    public string? ConteoInstrumental { get; set; }

    [Column("conteo_transfusiones_unidad")]
    [MaxLength(2)]
    public string? ConteoTransfusionesUnidad { get; set; }

    [Column("pronostico_vida")]
    [MaxLength(45)]
    public string? PronosticoVida { get; set; }

    [Column("pronostico_funcion")]
    [MaxLength(45)]
    public string? PronosticoFuncion { get; set; }

    [Column("footer_left")]
    [MaxLength(15)]
    public string? FooterLeft { get; set; }

    [Column("footer_right")]
    [MaxLength(15)]
    public string? FooterRight { get; set; }

    [Column("cxPlaneada")]
    [MaxLength(100)]
    public string? CxPlaneada { get; set; }

    [Column("cxRealizada")]
    [MaxLength(100)]
    public string? CxRealizada { get; set; }

    [Column("cxPlaneadaID")]
    public ushort CxPlaneadaId { get; set; }

    [Column("cxRealizadaID")]
    public ushort CxRealizadaId { get; set; }

    [Column("conteo_sangrado_ml")]
    [MaxLength(5)]
    public string? ConteoSangradoMl { get; set; }

    [Column("otrosDxPost")]
    public string? OtrosDxPost { get; set; }

    [Column("otrasCxPost")]
    public string? OtrasCxPost { get; set; }

    [Column("cirujanoID")]
    public ushort CirujanoId { get; set; }

    [Column("cirujano")]
    [MaxLength(100)]
    public string? Cirujano { get; set; }
}