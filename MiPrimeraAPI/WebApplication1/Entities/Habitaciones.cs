using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("habitaciones")]
public class Habitacion
{
    [Key]
    [Column("id")]
    public ushort Id { get; set; }

    [Column("areaID")]
    public ushort AreaId { get; set; }

    [Column("habitacion")]
    [MaxLength(60)]
    public string? Nombre { get; set; }

    [Column("status")]
    public int Status { get; set; }

    [Column("cirugia")]
    public byte Cirugia { get; set; }

    [Column("color")]
    [MaxLength(9)]
    public string Color { get; set; } = "$008000ff";

    [Column("post_status")]
    public byte PostStatus { get; set; }

    [Column("articuloId")]
    public uint? ArticuloId { get; set; }

    [Column("descripcion")]
    [MaxLength(45)]
    public string? Descripcion { get; set; }

    [Column("libre")]
    public bool Libre { get; set; }

    [Column("hvirtual")]
    public bool? HVirtual { get; set; }

    [Column("tipo")]
    [MaxLength(45)]
    public string? Tipo { get; set; }

    [Column("piso")]
    [MaxLength(15)]
    public string? Piso { get; set; }

    [Column("sith")]
    public bool Sith { get; set; }

    [Column("coords")]
    [MaxLength(1024)]
    public string? Coords { get; set; }

    [Column("wfID")]
    public uint WfId { get; set; }

    [Column("tickets")]
    public byte Tickets { get; set; }

    [Column("posicionIndicadores")]
    [MaxLength(1)]
    public string? PosicionIndicadores { get; set; }

    [Column("motivoStatus")]
    [MaxLength(200)]
    public string? MotivoStatus { get; set; }

    [Column("userInsert")]
    public ushort UserInsert { get; set; }

    [Column("dtInsert")]
    public DateTime? DtInsert { get; set; }

    [Column("userModified")]
    public ushort UserModified { get; set; }

    [Column("dtModified")]
    public DateTime? DtModified { get; set; }

    [Column("origen")]
    [MaxLength(3)]
    public string? Origen { get; set; }

    [Column("tareaInicial")]
    public ushort TareaInicial { get; set; }

    [Column("limpieza")]
    public byte Limpieza { get; set; }

    [Column("recibeTickets")]
    public byte RecibeTickets { get; set; }

    [Column("timelineID")]
    public uint TimelineId { get; set; }

    [Column("permitirAlta")]
    public byte PermitirAlta { get; set; }

    [Column("autoInicio")]
    public byte AutoInicio { get; set; }

    [Column("wfTipo")]
    public byte WfTipo { get; set; }

    [Column("semana")]
    public byte Semana { get; set; }

    [Column("rx")]
    public byte Rx { get; set; }

    [Column("modalidadID")]
    [MaxLength(50)]
    public string ModalidadId { get; set; } = "0";

    [Column("taskColor")]
    [MaxLength(10)]
    public string? TaskColor { get; set; }

    [Column("lab")]
    public byte Lab { get; set; }
}