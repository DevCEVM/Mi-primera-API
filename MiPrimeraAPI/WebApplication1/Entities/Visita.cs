using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("visitas")]
public class Visita
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("pacienteID")]
    public uint PacienteId { get; set; }

    [Column("fecha_ingreso")]
    public DateTime? FechaIngreso { get; set; }

    [Column("fecha_egreso")]
    public DateTime? FechaEgreso { get; set; }

    [Column("dtInserted")]
    public DateTime? DtInserted { get; set; }

    [Column("areaID")]
    public byte AreaId { get; set; }

    [Column("area")]
    [MaxLength(50)]
    public string? Area { get; set; }

    [Column("habitacion")]
    [MaxLength(20)]
    public string? Habitacion { get; set; }

    [Column("servicio_medico")]
    [MaxLength(100)]
    public string? ServicioMedico { get; set; }

    [Column("servicioMedicoID")]
    public uint ServicioMedicoId { get; set; }

    [Column("poliza")]
    [MaxLength(20)]
    public string? Poliza { get; set; }

    [Column("motivo_ingreso")]
    [MaxLength(100)]
    public string? MotivoIngreso { get; set; }

    [Column("modo_ingreso")]
    [MaxLength(45)]
    public string? ModoIngreso { get; set; }

    [Column("motivo_egreso")]
    [MaxLength(45)]
    public string? MotivoEgreso { get; set; }

    [Column("status")]
    public byte Status { get; set; }

    [Column("alta_medica")]
    public byte AltaMedica { get; set; }

    [Column("alta_enfermeria")]
    public byte AltaEnfermeria { get; set; }

    [Column("alta_administrativa")]
    public byte AltaAdministrativa { get; set; }

    [Column("medicoID")]
    public ushort MedicoId { get; set; }

    [Column("medico_asignado")]
    [MaxLength(100)]
    public string? MedicoAsignado { get; set; }

    [Column("enfermeraID")]
    public ushort EnfermeraId { get; set; }

    [Column("enfermera_asignada")]
    [MaxLength(100)]
    public string? EnfermeraAsignada { get; set; }

    [Column("medico_visitante_id")]
    public ushort MedicoVisitanteId { get; set; }

    [Column("enfermera_visitante_id")]
    public ushort EnfermeraVisitanteId { get; set; }

    [Column("edad")]
    public byte Edad { get; set; }

    [Column("edad_meses")]
    public byte EdadMeses { get; set; }

    [Column("edad_dias")]
    public byte EdadDias { get; set; }

    [Column("usuario_ingreso")]
    public ushort UsuarioIngreso { get; set; }

    [Column("medico_especialidad")]
    [MaxLength(100)]
    public string? MedicoEspecialidad { get; set; }

    [Column("comentarios")]
    [MaxLength(255)]
    public string? Comentarios { get; set; }

    [Column("dx_ingreso")]
    [MaxLength(100)]
    public string? DxIngreso { get; set; }

    [Column("dx_egreso")]
    [MaxLength(100)]
    public string? DxEgreso { get; set; }

    [Column("servicioID")]
    public ushort ServicioId { get; set; }

    [Column("area_actual")]
    [MaxLength(50)]
    public string? AreaActual { get; set; }

    [Column("habitacion_actual")]
    [MaxLength(20)]
    public string? HabitacionActual { get; set; }

    [Column("kardex_area_id")]
    public uint KardexAreaId { get; set; }

    [Column("area_actual_id")]
    public byte AreaActualId { get; set; }

    [Column("habitacion_actual_id")]
    public uint HabitacionActualId { get; set; }

    [Column("habitacionID")]
    public uint HabitacionId { get; set; }

    [Column("tipo")]
    public byte Tipo { get; set; }

    [Column("expediente")]
    public uint? Expediente { get; set; }

    [Column("alta_voluntaria")]
    [MaxLength(1)]
    public string? AltaVoluntaria { get; set; }

    [Column("alta_informada")]
    [MaxLength(1)]
    public string? AltaInformada { get; set; }

    [Column("fecha_alta_medica")]
    public DateTime? FechaAltaMedica { get; set; }

    [Column("fecha_alta_enfermeria")]
    public DateTime? FechaAltaEnfermeria { get; set; }

    [Column("fecha_alta_administrativa")]
    public DateTime? FechaAltaAdministrativa { get; set; }

    [Column("user_alta_medica")]
    [MaxLength(45)]
    public string? UserAltaMedica { get; set; }

    [Column("user_alta_enfermeria")]
    [MaxLength(45)]
    public string? UserAltaEnfermeria { get; set; }

    [Column("user_alta_administrativa")]
    [MaxLength(45)]
    public string? UserAltaAdministrativa { get; set; }

    [Column("user_close")]
    [MaxLength(45)]
    public string? UserClose { get; set; }

    [Column("fecha_close")]
    public DateTime? FechaClose { get; set; }

    [Column("peso")]
    public decimal Peso { get; set; }

    [Column("talla")]
    public decimal Talla { get; set; }

    [Column("imc")]
    public decimal Imc { get; set; }

    [Column("FechaCargoCuarto")]
    public DateTime? FechaCargoCuarto { get; set; }

    [Column("habitacion_cortesia")]
    public byte HabitacionCortesia { get; set; }

    [Column("FechaCargoEvento")]
    public DateTime? FechaCargoEvento { get; set; }

    [Column("tipoPaciente")]
    [MaxLength(1)]
    public string? TipoPaciente { get; set; }

    [Column("periodico")]
    public bool Periodico { get; set; }

    [Column("interconsultantes")]
    [MaxLength(100)]
    public string Interconsultantes { get; set; } = string.Empty;

    [Column("medioDeContacto")]
    [MaxLength(200)]
    public string? MedioDeContacto { get; set; }

    [Column("parentVisitaID")]
    public uint ParentVisitaId { get; set; }

    [Column("mikrotikID")]
    [MaxLength(32)]
    public string? MikrotikId { get; set; }

    [Column("wifiuser")]
    [MaxLength(45)]
    public string? WifiUser { get; set; }

    [Column("wifipass")]
    [MaxLength(45)]
    public string? WifiPass { get; set; }

    [Column("lista_espera")]
    public bool ListaEspera { get; set; }

    [Column("lista_espera_comentarios")]
    [MaxLength(100)]
    public string? ListaEsperaComentarios { get; set; }

    [Column("areaMaster")]
    [MaxLength(50)]
    public string? AreaMaster { get; set; }

    [Column("areaMasterId")]
    public ushort AreaMasterId { get; set; }

    [Column("lista_espera_orden")]
    public ushort ListaEsperaOrden { get; set; }

    [Column("triageColor")]
    [MaxLength(15)]
    public string? TriageColor { get; set; }

    [Column("indicacion")]
    public byte Indicacion { get; set; }

    [Column("triageID")]
    public uint TriageId { get; set; }

    [Column("preingresoID")]
    public uint PreingresoId { get; set; }

    [Column("vip")]
    public byte Vip { get; set; }

    [Column("esperaHabitacion")]
    public byte EsperaHabitacion { get; set; }
}