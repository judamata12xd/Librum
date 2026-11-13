using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;

namespace Controlador.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistorialController : ControllerBase
    {
        private readonly DataContext _context;

        public HistorialController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Historial
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VwHistorialPrestamo>>> GetHistorial()
        {
            // Devuelve los datos directamente desde tu vista SQL
            return await _context.VwHistorialPrestamos.ToListAsync();
        }
    }
}