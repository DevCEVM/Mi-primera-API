using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("familias")]
public class Familia
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("familia")]
    [MaxLength(150)]
    public string? Nombre { get; set; }

    [Column("status")]
    public uint? Status { get; set; }

    [Column("ivaCompra")]
    public uint? IvaCompra { get; set; }

    [Column("ivaVenta")]
    public uint? IvaVenta { get; set; }

    [Column("grupoFacturacionId")]
    public uint? GrupoFacturacionId { get; set; }

    [Column("ordenImpresionCuenta")]
    public uint? OrdenImpresionCuenta { get; set; }

    [Column("prioridadDescuentos")]
    public uint? PrioridadDescuentos { get; set; }

    [Column("grupoFamiliaId")]
    public uint? GrupoFamiliaId { get; set; }

    [Column("cuentaContable")]
    [MaxLength(45)]
    public string? CuentaContable { get; set; }

    [Column("PorcentajeUtilidadReportes")]
    public decimal PorcentajeUtilidadReportes { get; set; }
}