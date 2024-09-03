using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiSeguros.Models;
public class Usuario
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int DNI { get; set; }
    public string Nombre { get; set; }
    public string Direccion { get; set; }
    public string Localidad { get; set; }
    public string CondicionIVA { get; set; }
    public string Rol { get; set; }
    public string Email { get; set; }
    public string Contrasena { get; set; }
    public ICollection<Poliza> Polizas { get; set; }
}
