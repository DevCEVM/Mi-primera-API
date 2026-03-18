using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("cuentaspacientes")]
public class CuentaPaciente
{
    [Key]
    [Column("id")]
    public uint Id { get; set; }

    [Column("visitaId")]
    public uint? VisitaId { get; set; }

    [Column("pacienteId")]
    public uint PacienteId { get; set; }

    [Column("fecha")]
    public DateTime? Fecha { get; set; }

    [Column("areaId")]
    public uint? AreaId { get; set; }

    [Column("habitacion")]
    [MaxLength(60)]
    public string? Habitacion { get; set; }

    [Column("servicioMedico")]
    [MaxLength(150)]
    public string? ServicioMedico { get; set; }

    [Column("servicioMedicoID")]
    public uint ServicioMedicoId { get; set; }

    [Column("poliza")]
    [MaxLength(80)]
    public string? Poliza { get; set; }

    [Column("cargosAntes")]
    public decimal CargosAntes { get; set; }

    [Column("subtotal")]
    public decimal Subtotal { get; set; }

    [Column("iva")]
    public decimal Iva { get; set; }

    [Column("total")]
    public decimal Total { get; set; }

    [Column("subcuenta")]
    public uint? Subcuenta { get; set; }

    [Column("cuentaPadreId")]
    public uint? CuentaPadreId { get; set; }

    [Column("cuentaMaestraId")]
    public uint? CuentaMaestraId { get; set; }

    [Column("coaseguroAdicional")]
    public decimal CoaseguroAdicional { get; set; }

    [Column("deducible")]
    public decimal Deducible { get; set; }

    [Column("coaseguroHospital")]
    public decimal CoaseguroHospital { get; set; }

    [Column("coaseguroHm")]
    public decimal CoaseguroHm { get; set; }

    [Column("descuentoAseguradora")]
    public decimal DescuentoAseguradora { get; set; }

    [Column("descuentoAdicional")]
    public decimal DescuentoAdicional { get; set; }

    [Column("diferenciaCuenta")]
    public decimal DiferenciaCuenta { get; set; }

    // --- Valores de catálogo ---
    [Column("deduciblePorcCatalogo")]
    public decimal DeduciblePorcCatalogo { get; set; }

    [Column("deducibleCantCatalogo")]
    public decimal DeducibleCantCatalogo { get; set; }

    [Column("coaseguroHospPorcCatalogo")]
    public decimal CoaseguroHospPorcCatalogo { get; set; }

    [Column("coaseguroHospCantCatalogo")]
    public decimal CoaseguroHospCantCatalogo { get; set; }

    [Column("coaseguroHmPorcCatalogo")]
    public decimal CoaseguroHmPorcCatalogo { get; set; }

    [Column("coaseguroHmCantCatalogo")]
    public decimal CoaseguroHmCantCatalogo { get; set; }

    [Column("descuentoAsegPorcCatalogo")]
    public decimal DescuentoAsegPorcCatalogo { get; set; }

    [Column("descuentoAsegCantCatalogo")]
    public decimal DescuentoAsegCantCatalogo { get; set; }

    [Column("descuentoAdicPorcCatalogo")]
    public decimal DescuentoAdicPorcCatalogo { get; set; }

    [Column("descuentoAdicCantCatalogo")]
    public decimal DescuentoAdicCantCatalogo { get; set; }

    [Column("diferenciaCuentaPorcCatalogo")]
    public decimal DiferenciaCuentaPorcCatalogo { get; set; }

    [Column("diferenciaCuentaCantCatalogo")]
    public decimal DiferenciaCuentaCantCatalogo { get; set; }

    [Column("coaseguroAdicionalPorcCatalogo")]
    public decimal CoaseguroAdicionalPorcCatalogo { get; set; }

    [Column("coaseguroAdicionalCantCatalogo")]
    public decimal CoaseguroAdicionalCantCatalogo { get; set; }

    [Column("descuentoDeducible")]
    public decimal DescuentoDeducible { get; set; }

    [Column("tipoCambio")]
    public decimal TipoCambio { get; set; }

    [Column("totalDlls")]
    public decimal TotalDlls { get; set; }

    [Column("facturaid")]
    public int? FacturaId { get; set; }

    [Column("folioFactura")]
    [MaxLength(80)]
    public string? FolioFactura { get; set; }

    [Column("status")]
    public uint? Status { get; set; }

    [Column("tipoCuenta")]
    [MaxLength(60)]
    public string? TipoCuenta { get; set; }

    [Column("deuda")]
    public decimal Deuda { get; set; }

    [Column("particular")]
    public uint? Particular { get; set; }

    [Column("descuentoPorcentaje")]
    public decimal DescuentoPorcentaje { get; set; }

    [Column("descuentoCantidad")]
    public decimal DescuentoCantidad { get; set; }

    [Column("caja")]
    [MaxLength(150)]
    public string? Caja { get; set; }

    [Column("netoPagar")]
    public decimal NetoPagar { get; set; }

    [Column("bloquear")]
    public uint? Bloquear { get; set; }

    [Column("corteId")]
    public uint? CorteId { get; set; }

    [Column("ivaDeducible")]
    public decimal IvaDeducible { get; set; }

    [Column("ivaCoaseguroHospital")]
    public decimal IvaCoaseguroHospital { get; set; }

    [Column("ivaCoaseguroHM")]
    public decimal IvaCoaseguroHm { get; set; }

    // --- Seguro ---
    [Column("pagadaSeguro")]
    public uint? PagadaSeguro { get; set; }

    [Column("montoAutorizado")]
    public decimal MontoAutorizado { get; set; }

    [Column("statusSeguro")]
    [MaxLength(150)]
    public string? StatusSeguro { get; set; }

    [Column("fechaEnvio")]
    public DateTime? FechaEnvio { get; set; }

    [Column("fechaLiquidacion")]
    public DateTime? FechaLiquidacion { get; set; }

    [Column("dictamen")]
    [MaxLength(150)]
    public string? Dictamen { get; set; }

    [Column("folioSeguro")]
    [MaxLength(150)]
    public string? FolioSeguro { get; set; }

    [Column("siniestro")]
    [MaxLength(150)]
    public string? Siniestro { get; set; }

    [Column("fechaVencimiento")]
    public DateTime? FechaVencimiento { get; set; }

    // --- Cortesía / Caja médico ---
    [Column("portalEtiquetaSeguro")]
    [MaxLength(255)]
    public string? PortalEtiquetaSeguro { get; set; }

    [Column("nombreCortesia")]
    [MaxLength(200)]
    public string? NombreCortesia { get; set; }

    [Column("cortesiaId")]
    public uint? CortesiaId { get; set; }

    [Column("usuarioId")]
    public uint? UsuarioId { get; set; }

    [Column("pagoId")]
    public uint? PagoId { get; set; }

    [Column("clienteId")]
    public uint? ClienteId { get; set; }

    [Column("ignorarPendientes")]
    public bool IgnorarPendientes { get; set; }

    [Column("medicoId")]
    public int? MedicoId { get; set; }

    [Column("ivaCoaseguroAdicional")]
    public decimal IvaCoaseguroAdicional { get; set; }

    [Column("coaseguroAdicionalCantCatalogoAplicable")]
    public decimal CoaseguroAdicionalCantCatalogoAplicable { get; set; }

    [Column("medicoCajaMedicoId")]
    public uint? MedicoCajaMedicoId { get; set; }

    [Column("medicoCajaMedico")]
    [MaxLength(300)]
    public string? MedicoCajaMedico { get; set; }

    [Column("folioFormaPagoCajaMedico")]
    [MaxLength(80)]
    public string? FolioFormaPagoCajaMedico { get; set; }

    [Column("clasificacionCxC")]
    [MaxLength(200)]
    public string? ClasificacionCxC { get; set; }

    [Column("fechaCancelacion")]
    public DateTime? FechaCancelacion { get; set; }

    [Column("usuarioIdCancelacion")]
    public uint? UsuarioIdCancelacion { get; set; }
}