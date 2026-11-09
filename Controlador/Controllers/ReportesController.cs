using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;

namespace Controlador.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportesController : ControllerBase
    {
        private readonly DataContext _context;

        public ReportesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("historial")]
        public async Task<ActionResult<IEnumerable<VwHistorialPrestamo>>> GetHistorial()
        {
            return await _context.VwHistorialPrestamos.ToListAsync();
        }
    }
}