using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("articuloscuenta")]
public class ArticuloCuenta
{
    [Key]
    [Column("id")]
    public uint Id { get; set; }

    [Column("cuentaId")]
    public uint? CuentaId { get; set; }

    [Column("hojaId")]
    public uint? HojaId { get; set; }

    [Column("articuloId")]
    public uint? ArticuloId { get; set; }

    [Column("articuloClave")]
    [MaxLength(45)]
    public string? ArticuloClave { get; set; }

    [Column("descripcion")]
    [MaxLength(250)]
    public string? Descripcion { get; set; }

    [Column("tipo")]
    [MaxLength(150)]
    public string? Tipo { get; set; }

    [Column("almacenId")]
    public uint? AlmacenId { get; set; }

    [Column("nombreAlmacen")]
    [MaxLength(150)]
    public string? NombreAlmacen { get; set; }

    [Column("cantidadUnidad")]
    public uint? CantidadUnidad { get; set; }

    [Column("unidad")]
    [MaxLength(80)]
    public string? Unidad { get; set; }

    [Column("piezasUnidad")]
    public uint? PiezasUnidad { get; set; }

    [Column("totalPiezas")]
    public uint? TotalPiezas { get; set; }

    [Column("precio")]
    public decimal? Precio { get; set; }

    [Column("importe")]
    public decimal? Importe { get; set; }

    [Column("lote")]
    [MaxLength(80)]
    public string? Lote { get; set; }

    [Column("fechaCaducidad")]
    public DateTime? FechaCaducidad { get; set; }

    [Column("costoUnitarioPesos")]
    public decimal? CostoUnitarioPesos { get; set; }

    [Column("existenciaId")]
    public uint? ExistenciaId { get; set; }

    [Column("consumoId")]
    public uint? ConsumoId { get; set; }

    [Column("fechaConsumo")]
    public DateTime? FechaConsumo { get; set; }

    [Column("codigoBarra")]
    public ulong? CodigoBarra { get; set; }

    [Column("paqueteId")]
    public uint? PaqueteId { get; set; }

    [Column("pedidoId")]
    public uint? PedidoId { get; set; }

    [Column("areaId")]
    public uint? AreaId { get; set; }

    [Column("area")]
    [MaxLength(150)]
    public string? Area { get; set; }

    [Column("habitacion")]
    [MaxLength(150)]
    public string? Habitacion { get; set; }

    [Column("usuario")]
    [MaxLength(150)]
    public string? Usuario { get; set; }

    [Column("servicioMedico")]
    [MaxLength(180)]
    public string? ServicioMedico { get; set; }

    [Column("fecha")]
    public DateTime? Fecha { get; set; }

    [Column("iva")]
    public decimal Iva { get; set; }

    [Column("banIva")]
    public uint? BanIva { get; set; }

    [Column("banDescuento")]
    public uint? BanDescuento { get; set; }

    [Column("copiable")]
    public uint? Copiable { get; set; }

    [Column("modificado")]
    public uint? Modificado { get; set; }

    [Column("marcado")]
    public uint? Marcado { get; set; }

    [Column("descuentoPorcentaje")]
    public decimal DescuentoPorcentaje { get; set; }

    [Column("descuentoImporte")]
    public decimal DescuentoImporte { get; set; }

    [Column("descuentosExtras")]
    public uint? DescuentosExtras { get; set; }

    [Column("banArticuloNoBorrable")]
    public uint? BanArticuloNoBorrable { get; set; }

    [Column("ultimoDescuento")]
    public decimal UltimoDescuento { get; set; }

    [Column("banArticuloDescuento")]
    public uint? BanArticuloDescuento { get; set; }

    [Column("descuentoExtraImporte")]
    public decimal DescuentoExtraImporte { get; set; }

    [Column("aumentoExtraImporte")]
    public decimal AumentoExtraImporte { get; set; }

    [Column("importeConDescuento")]
    public decimal ImporteConDescuento { get; set; }

    [Column("modificadoPrecio")]
    public uint? ModificadoPrecio { get; set; }

    [Column("renglonPedidoId")]
    public uint? RenglonPedidoId { get; set; }

    [Column("vista")]
    public uint? Vista { get; set; }

    [Column("articuloOrdenCompraId")]
    public uint? ArticuloOrdenCompraId { get; set; }

    [Column("tipoHonorario")]
    public uint? TipoHonorario { get; set; }

    [Column("observacionTipo")]
    public uint? ObservacionTipo { get; set; }

    [Column("DiscusionCuentaId")]
    public uint? DiscusionCuentaId { get; set; }

    [Column("renglonArticuloMovInv")]
    public uint? RenglonArticuloMovInv { get; set; }

    [Column("bonificado")]
    public decimal Bonificado { get; set; }

    [Column("cantidadBonificada")]
    public uint? CantidadBonificada { get; set; }

    [Column("articuloOrigenId")]
    public uint? ArticuloOrigenId { get; set; }

    [Column("cuentaOrigenId")]
    public uint? CuentaOrigenId { get; set; }

    [Column("cuentaDesvioId")]
    public int? CuentaDesvioId { get; set; }

    [Column("indicacionesEtiqueta")]
    public string? IndicacionesEtiqueta { get; set; }

    [Column("fechaEtiqueta")]
    public DateTime? FechaEtiqueta { get; set; }

    [Column("procedimientoId")]
    public uint? ProcedimientoId { get; set; }

    [Column("procedimiento")]
    [MaxLength(300)]
    public string? Procedimiento { get; set; }

    [Column("familiaId")]
    public uint? FamiliaId { get; set; }

    [Column("banDescuentoQuitar")]
    public uint? BanDescuentoQuitar { get; set; }

    [Column("catastrofico")]
    public uint? Catastrofico { get; set; }

    [Column("requisicionSubrogadoId")]
    public uint? RequisicionSubrogadoId { get; set; }

    [Column("cajaMedicoId")]
    public uint? CajaMedicoId { get; set; }

    [Column("comandaId")]
    public uint? ComandaId { get; set; }

    [Column("grupoFacturacionId")]
    public uint? GrupoFacturacionId { get; set; }
}