using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

public class AseguradoraContext : DbContext
{
    public AseguradoraContext(DbContextOptions<AseguradoraContext> options)
    : base(options)
    {
    }

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Poliza> Polizas { get; set; }
}

public class Usuario
{
    public int DNI { get; set; }
    public string Nombre { get; set; }
    public string Direccion { get; set; }
    public string Localidad { get; set; }
    public string CondicionIVA { get; set; }
    public string Rol { get; set; }
    public string Email { get; set; }
    public string Contrasena { get; set; }
}

public class Poliza
{
    public int NumeroPoliza { get; set; }
    public DateTime VigenciaDesde { get; set; }
    public DateTime VigenciaHasta { get; set; }
    public string LocalidadRiesgo { get; set; }
    public string MarcaVehiculo { get; set; }
    public int Anio { get; set; }
    public string Patente { get; set; }
    public string NumeroMotor { get; set; }
    public string NumeroChasis { get; set; }
    public decimal ValorVehiculo { get; set; }
    public int AseguradoId { get; set; }
    public int AseguradorId { get; set; }
    public Usuario Asegurado { get; set; }
    public Usuario Asegurador { get; set; }
}
