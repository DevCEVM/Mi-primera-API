using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("articulos")]
public class Articulo
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("claveHospital")]
    [MaxLength(50)]
    public string? ClaveHospital { get; set; }

    [Column("claveSah")]
    [MaxLength(100)]
    public string? ClaveSah { get; set; }

    [Column("claveBionexo")]
    [MaxLength(80)]
    public string? ClaveBionexo { get; set; }

    [Column("codigoBarra")]
    [MaxLength(100)]
    public string? CodigoBarra { get; set; }

    [Column("descripcion")]
    [MaxLength(300)]
    public string? Descripcion { get; set; }

    [Column("tipo")]
    [MaxLength(100)]
    public string? Tipo { get; set; }

    [Column("familia")]
    [MaxLength(200)]
    public string? Familia { get; set; }

    [Column("sales")]
    [MaxLength(300)]
    public string? Sales { get; set; }

    [Column("descripcionCorta")]
    [MaxLength(300)]
    public string? DescripcionCorta { get; set; }

    [Column("lasa")]
    [MaxLength(5)]
    public string? Lasa { get; set; }

    [Column("controlado")]
    [MaxLength(5)]
    public string? Controlado { get; set; }

    [Column("solucion")]
    [MaxLength(5)]
    public string? Solucion { get; set; }

    [Column("consumible")]
    [MaxLength(5)]
    public string? Consumible { get; set; }

    [Column("generico")]
    [MaxLength(5)]
    public string? Generico { get; set; }

    [Column("ivaCompra")]
    public decimal? IvaCompra { get; set; }

    [Column("ivaVenta")]
    public decimal? IvaVenta { get; set; }

    [Column("dosis")]
    [MaxLength(45)]
    public string? Dosis { get; set; }

    [Column("dosisUnidad")]
    [MaxLength(15)]
    public string? DosisUnidad { get; set; }

    [Column("viaAdministracion")]
    [MaxLength(60)]
    public string? ViaAdministracion { get; set; }

    [Column("formaFarmaceutica")]
    [MaxLength(150)]
    public string? FormaFarmaceutica { get; set; }

    [Column("frecuenciaTipica")]
    [MaxLength(60)]
    public string? FrecuenciaTipica { get; set; }

    [Column("duracionTipica")]
    [MaxLength(150)]
    public string? DuracionTipica { get; set; }

    [Column("otraIndicacion")]
    [MaxLength(200)]
    public string? OtraIndicacion { get; set; }

    // Precios
    [Column("precio1")]
    public decimal? Precio1 { get; set; }

    [Column("precio2")]
    public decimal? Precio2 { get; set; }

    [Column("precio3")]
    public decimal? Precio3 { get; set; }

    [Column("precio4")]
    public decimal? Precio4 { get; set; }

    [Column("precio5")]
    public decimal? Precio5 { get; set; }

    [Column("precio6")]
    public decimal? Precio6 { get; set; }

    [Column("precio7")]
    public decimal? Precio7 { get; set; }

    [Column("precio8")]
    public decimal? Precio8 { get; set; }

    [Column("precio9")]
    public decimal? Precio9 { get; set; }

    [Column("precio10")]
    public decimal? Precio10 { get; set; }

    [Column("precioCaja1")]
    public decimal? PrecioCaja1 { get; set; }

    [Column("precioCaja2")]
    public decimal? PrecioCaja2 { get; set; }

    [Column("precioCaja3")]
    public decimal? PrecioCaja3 { get; set; }

    [Column("precioCaja4")]
    public decimal? PrecioCaja4 { get; set; }

    [Column("precioCaja5")]
    public decimal? PrecioCaja5 { get; set; }

    [Column("precioCaja6")]
    public decimal? PrecioCaja6 { get; set; }

    [Column("precioCaja7")]
    public decimal? PrecioCaja7 { get; set; }

    [Column("precioCaja8")]
    public decimal? PrecioCaja8 { get; set; }

    [Column("precioCaja9")]
    public decimal? PrecioCaja9 { get; set; }

    [Column("precioCaja10")]
    public decimal? PrecioCaja10 { get; set; }

    [Column("precioMaximo")]
    public decimal? PrecioMaximo { get; set; }

    [Column("status")]
    public int? Status { get; set; }

    [Column("familiaId")]
    public uint? FamiliaId { get; set; }

    [Column("proveedorId")]
    public uint? ProveedorId { get; set; }

    [Column("marcaLaboratorio")]
    [MaxLength(200)]
    public string? MarcaLaboratorio { get; set; }

    [Column("grupo")]
    [MaxLength(80)]
    public string? Grupo { get; set; }

    [Column("tipoArticulo")]
    [MaxLength(45)]
    public string? TipoArticulo { get; set; }

    [Column("costo")]
    public decimal? Costo { get; set; }

    [Column("costoPromedio")]
    public decimal? CostoPromedio { get; set; }

    [Column("unidad")]
    [MaxLength(45)]
    public string? Unidad { get; set; }

    [Column("altoriesgo")]
    public bool AltoRiesgo { get; set; }

    [Column("tipoServicio")]
    [MaxLength(45)]
    public string? TipoServicio { get; set; }

    [Column("indicacionesImagenologia")]
    public string? IndicacionesImagenologia { get; set; }

    [Column("caracteristicas")]
    public string? Caracteristicas { get; set; }

    [Column("categoria")]
    [MaxLength(60)]
    public string? Categoria { get; set; }

    [Column("sinonimo")]
    [MaxLength(300)]
    public string? Sinonimo { get; set; }

    [Column("registroSanitario")]
    [MaxLength(150)]
    public string? RegistroSanitario { get; set; }

    [Column("lisId")]
    [MaxLength(80)]
    public string? LisId { get; set; }
}