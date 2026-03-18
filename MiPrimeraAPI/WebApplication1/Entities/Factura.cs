using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("factura")]
public class Factura
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("fechaGenerada")]
    public DateTime? FechaGenerada { get; set; }

    [Column("subTotal")]
    public decimal? SubTotal { get; set; }

    [Column("total")]
    public decimal? Total { get; set; }

    [Column("UUID")]
    [MaxLength(255)]
    public string? UUID { get; set; }

    [Column("fechaTimbrado")]
    public DateTime? FechaTimbrado { get; set; }

    [Column("fechaCancelada")]
    public DateTime? FechaCancelada { get; set; }

    [Column("impRetenidos")]
    public decimal? ImpRetenidos { get; set; }

    [Column("impTrasladados")]
    public decimal? ImpTrasladados { get; set; }

    [Column("facturaEstatus_id")]
    public int FacturaEstatusId { get; set; }

    [Column("cTipoDeComprobante_id")]
    public int CTipoDeComprobanteId { get; set; }

    [Column("empresaEmisor")]
    public int EmpresaEmisor { get; set; }

    [Column("descuento")]
    public decimal? Descuento { get; set; }

    [Column("formaPago_id")]
    public int? FormaPagoId { get; set; }

    [Column("metodoPago_id")]
    public int? MetodoPagoId { get; set; }

    [Column("moneda_id")]
    public int? MonedaId { get; set; }

    [Column("tipo_cambio")]
    public float? TipoCambio { get; set; }

    [Column("saldo")]
    public decimal Saldo { get; set; }

    [Column("parcialidad")]
    public int? Parcialidad { get; set; }

    [Column("pagos")]
    public decimal Pagos { get; set; }

    [Column("creditos")]
    public decimal Creditos { get; set; }

    [Column("anticipos")]
    public decimal Anticipos { get; set; }

    [Column("condicionesPago")]
    [MaxLength(100)]
    public string? CondicionesPago { get; set; }

    [Column("noNomina")]
    [MaxLength(60)]
    public string? NoNomina { get; set; }

    [Column("empleado")]
    [MaxLength(300)]
    public string? Empleado { get; set; }

    [Column("banParaSustituir")]
    public uint? BanParaSustituir { get; set; }

    [Column("banSustituida")]
    public uint? BanSustituida { get; set; }
}