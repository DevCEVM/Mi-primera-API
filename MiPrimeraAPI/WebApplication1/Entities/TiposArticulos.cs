using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("tiposarticulos")]
public class TipoArticulo
{
    [Key]
    [Column("id")]
    public uint Id { get; set; }

    [Column("clave")]
    [MaxLength(50)]
    public string? Clave { get; set; }

    [Column("tipo")]
    [MaxLength(200)]
    public string? Tipo { get; set; }

    [Column("level")]
    public uint? Level { get; set; }

    [Column("parent")]
    public uint? Parent { get; set; }

    [Column("claveOculta")]
    [MaxLength(50)]
    public string? ClaveOculta { get; set; }

    [Column("status")]
    public uint? Status { get; set; }

    [Column("excepcion")]
    public decimal Excepcion { get; set; }

    [Column("calcularPrecio")]
    public uint? CalcularPrecio { get; set; }
}