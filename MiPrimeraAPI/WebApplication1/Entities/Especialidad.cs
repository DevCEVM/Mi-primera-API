using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("especialidad")]
public class Especialidad
{
    [Key]
    [Column("id")]
    public uint Id { get; set; }

    [Column("especialidad")]
    [MaxLength(100)]
    public string? Nombre { get; set; }

    [Column("status")]
    public bool Status { get; set; }

    [Column("icon")]
    [MaxLength(45)]
    public string? Icon { get; set; }
}