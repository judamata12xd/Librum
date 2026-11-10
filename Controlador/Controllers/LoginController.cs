using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Modelo.Entidades; 

namespace Controlador.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IConfiguration _config;

        public LoginController(DataContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        [HttpPost("iniciar-sesion")]
        public async Task<IActionResult> IniciarSesion([FromBody] LoginRequest request)
        {
            int idRol = 0;
            string nombreUsuario = "";
            string tipoUsuario = "";

        
            var empleado = await _context.Empleados
                .FirstOrDefaultAsync(e => e.Usuario == request.Usuario && e.Clave == request.Clave);

            if (empleado != null)
            {
                idRol = (int)empleado.Idrol;
                nombreUsuario = empleado.Usuario;
                tipoUsuario = "Empleado";
            }
            else
            {
            
                var lector = await _context.Lectores
                    .FirstOrDefaultAsync(l => l.Usuario == request.Usuario && l.Clave == request.Clave);

                if (lector != null)
                {
                    idRol = (int)lector.Idrol;
                    nombreUsuario = lector.Usuario;
                    tipoUsuario = "Lector";
                }
            }

            if (idRol == 0)
            {
                return Unauthorized("Usuario o contraseña incorrectos.");
            }

  
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, nombreUsuario),
                new Claim(ClaimTypes.Role, idRol.ToString()),
                new Claim("TipoUsuario", tipoUsuario) 
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Audience"],
                claims: claims,
                expires: DateTime.Now.AddHours(2),
                signingCredentials: creds
            );

            var tokenString = new JwtSecurityTokenHandler().WriteToken(token);

   
            return Ok(new { Token = tokenString, IdRol = idRol, Tipo = tipoUsuario });
        }
    }

    public class LoginRequest
    {
        public string Usuario { get; set; }
        public string Clave { get; set; }
    }
}
