using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("agenda_cirugias")]
public class AgendaCirugia
{
    [Key]
    [Column("id")]
    public uint Id { get; set; }

    [Column("cirugiaID")]
    public uint CirugiaId { get; set; }

    [Column("agendaID")]
    public uint AgendaId { get; set; }

    [Column("cirugia")]
    [MaxLength(200)]
    public string? Cirugia { get; set; }

    [Column("medico")]
    [MaxLength(100)]
    public string? Medico { get; set; }

    [Column("status")]
    public byte Status { get; set; }

    [Column("tempID")]
    public uint TempId { get; set; }

    [Column("preingresoID")]
    public uint PreingresoId { get; set; }
}