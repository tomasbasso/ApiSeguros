using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiSeguros.Models;
using System.Data;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ApiSeguros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly string cadenaSQL;

        public UsuarioController(IConfiguration configuration)
        {
            cadenaSQL = configuration.GetConnectionString("DefaultConnection");
        }

        // GET: api/Usuario
        [HttpGet]
        [Route("Lista")]
        public IActionResult Lista()
        {
            List<Usuario> lista = new List<Usuario>();
            try
            {
                using (var conexion = new SqlConnection(cadenaSQL))
                {
                    conexion.Open();
                    var cmd = new SqlCommand("listausuarios", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Usuario
                            {
                                DNI = Convert.ToInt32(reader["dni"]),
                                Nombre = Convert.ToString(reader["nombre"]),
                                Direccion = Convert.ToString(reader["direccion"]),
                                Localidad = Convert.ToString(reader["localidad"]),
                                CondicionIVA = Convert.ToString(reader["condicioniva"]),
                                Rol = Convert.ToString(reader["rol"]),
                                Email = Convert.ToString(reader["email"]),
                                Contrasena = Convert.ToString(reader["contrasena"])
                            });
                        }
                    }
                }
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok", response = lista });
            }
            catch (Exception error)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { mensaje = error.Message, response = lista });
            }
        }
    }
}
                                 
                    
            
       

