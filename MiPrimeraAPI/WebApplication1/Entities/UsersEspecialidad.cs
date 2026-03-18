using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("users_especialidad")]
public class UserEspecialidad
{
    [Key]
    [Column("id")]
    public ulong Id { get; set; }

    [Column("userID")]
    public uint UserId { get; set; }

    [Column("especialidadID")]
    public uint EspecialidadId { get; set; }

    [Column("cedula")]
    [MaxLength(45)]
    public string? Cedula { get; set; }

    [Column("firma")]
    public bool Firma { get; set; }

    [Column("escuela")]
    [MaxLength(100)]
    public string? Escuela { get; set; }

    [Column("status")]
    public bool Status { get; set; }

    [Column("expediente")]
    public bool Expediente { get; set; }
}