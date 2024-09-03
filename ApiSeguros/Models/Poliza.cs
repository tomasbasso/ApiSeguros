
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiSeguros.Models;
public class Poliza
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int NumeroPoliza { get; set; }

    [Required]
    public DateTime VigenciaDesde { get; set; }

    [Required]
    public DateTime VigenciaHasta { get; set; }

    [Required]
    [StringLength(100)]
    public string LocalidadRiesgo { get; set; }

    [Required]
    [StringLength(100)]
    public string MarcaVehiculo { get; set; }

    [Required]
    public int Anio { get; set; }

    [Required]
    [StringLength(20)]
    public string Patente { get; set; }

    [Required]
    [StringLength(50)]
    public string NumeroMotor { get; set; }

    [Required]
    [StringLength(50)]
    public string NumeroChasis { get; set; }

    [Required]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal ValorVehiculo { get; set; }

    // Relaciones
    [Required]
    public int AseguradoId { get; set; }

    [Required]
    public int AseguradorId { get; set; }

    // Navegación
    [ForeignKey("AseguradoId")]
    public Usuario Asegurado { get; set; }

    [ForeignKey("AseguradorId")]
    public Usuario Asegurador { get; set; }
}
