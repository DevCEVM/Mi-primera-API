using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("servicios_medicos")]
public class ServicioMedico
{
    [Key]
    [Column("id")]
    public uint Id { get; set; }

    [Column("servicio")]
    [MaxLength(250)]
    public string Servicio { get; set; } = null!;

    [Column("domicilio")]
    [MaxLength(150)]
    public string? Domicilio { get; set; }

    [Column("cp")]
    [MaxLength(10)]
    public string? Cp { get; set; }

    [Column("telefono")]
    [MaxLength(20)]
    public string? Telefono { get; set; }

    [Column("tipo_precio")]
    [MaxLength(45)]
    public string? TipoPrecio { get; set; }

    [Column("requiere_poliza")]
    public byte RequierePoliza { get; set; }

    [Column("formula")]
    [MaxLength(60)]
    public string? Formula { get; set; }

    [Column("status")]
    public byte Status { get; set; }

    [Column("rfc")]
    [MaxLength(15)]
    public string? Rfc { get; set; }

    [Column("email")]
    [MaxLength(100)]
    public string? Email { get; set; }

    [Column("ciudad")]
    [MaxLength(45)]
    public string? Ciudad { get; set; }

    [Column("estado")]
    [MaxLength(45)]
    public string? Estado { get; set; }

    [Column("pais")]
    [MaxLength(45)]
    public string? Pais { get; set; }

    [Column("particular")]
    public uint? Particular { get; set; }

    [Column("porcentajeAseguradora")]
    public decimal PorcentajeAseguradora { get; set; }

    [Column("coaseguroAntes")]
    public uint? CoaseguroAntes { get; set; }

    [Column("calle")]
    [MaxLength(80)]
    public string? Calle { get; set; }

    [Column("no_exterior")]
    [MaxLength(45)]
    public string? NoExterior { get; set; }

    [Column("no_interior")]
    [MaxLength(45)]
    public string? NoInterior { get; set; }

    [Column("colonia")]
    [MaxLength(150)]
    public string? Colonia { get; set; }

    [Column("observaciones")]
    public string? Observaciones { get; set; }

    [Column("diasPago")]
    public uint? DiasPago { get; set; }

    [Column("cliente_id")]
    public int ClienteId { get; set; }

    [Column("diasPorAgregar_id")]
    public short? DiasPorAgregarId { get; set; }

    [Column("coaseguroMenosDeducible")]
    public uint? CoaseguroMenosDeducible { get; set; }

    [Column("tipoContrato")]
    [MaxLength(120)]
    public string? TipoContrato { get; set; }

    [Column("claveAtc")]
    [MaxLength(45)]
    public string? ClaveAtc { get; set; }

    [Column("usuarioFtp")]
    [MaxLength(80)]
    public string? UsuarioFtp { get; set; }

    [Column("claveFtp")]
    [MaxLength(80)]
    public string? ClaveFtp { get; set; }

    [Column("rutaFtp")]
    [MaxLength(300)]
    public string? RutaFtp { get; set; }

    [Column("carpetaFtp")]
    [MaxLength(300)]
    public string? CarpetaFtp { get; set; }

    [Column("puerto")]
    public uint? Puerto { get; set; }

    [Column("deduciblesIva")]
    public uint? DeduciblesIva { get; set; }

    [Column("coaseguroHospitalIva")]
    public uint? CoaseguroHospitalIva { get; set; }

    [Column("coaseguroHMIva")]
    public uint? CoaseguroHmiiva { get; set; }

    [Column("coaseguroAdicionalIva")]
    public uint? CoaseguroAdicionalIva { get; set; }

    [Column("condicionesPago")]
    [MaxLength(100)]
    public string? CondicionesPago { get; set; }

    [Column("retencion")]
    public uint? Retencion { get; set; }

    [Column("claveHospital")]
    [MaxLength(45)]
    public string? ClaveHospital { get; set; }

    [Column("envioMatutino")]
    public uint? EnvioMatutino { get; set; }

    [Column("envioVespertino")]
    public uint? EnvioVespertino { get; set; }

    [Column("condicinarVistasenCatastrofico")]
    public uint? CondicionarVistasCatastrofico { get; set; }

    [Column("noCondicionarVistasenCatastrofico")]
    public uint? NoCondicionarVistasCatastrofico { get; set; }

    [Column("banPaqueteAutomatico")]
    public uint? BanPaqueteAutomatico { get; set; }

    [Column("banPeriodoFacturar")]
    public uint? BanPeriodoFacturar { get; set; }

    [Column("banDescuentoRestaurante")]
    public uint? BanDescuentoRestaurante { get; set; }

    [Column("banIpejal")]
    public uint? BanIpejal { get; set; }
}