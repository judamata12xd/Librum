using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;

namespace Controlador.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrestamosController : ControllerBase
    {
        private readonly DataContext _context;

        public PrestamosController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Prestamos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Prestamo>>> GetPrestamos()
        {
            return await _context.Prestamos.ToListAsync();
        }

        // GET: api/Prestamos/lector/5
        [HttpGet("lector/{idlector}")]
        public async Task<ActionResult<IEnumerable<Prestamo>>> GetPrestamosPorLector(int idlector)
        {
            // Busca en la tabla de préstamos únicamente los que le pertenecen a este lector
            var prestamosDelLector = await _context.Prestamos
                                                   .Where(p => p.Idlector == idlector)
                                                   .ToListAsync();
            return Ok(prestamosDelLector);
        }

        // GET: api/Prestamos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Prestamo>> GetPrestamo(int id)
        {
            var prestamo = await _context.Prestamos.FindAsync(id);

            if (prestamo == null)
            {
                return NotFound();
            }

            return prestamo;
        }

        // POST: api/Prestamos
        [HttpPost]
        public async Task<ActionResult<Prestamo>> PostPrestamo(Prestamo prestamo)
        {
            try
            {
           
                int diasPrestamo = (prestamo.FechaDevolucionE - DateTime.Now).Days;
                if (diasPrestamo <= 0) diasPrestamo = 1;

                await _context.Database.ExecuteSqlRawAsync(
                    "EXEC sp_RegistrarPrestamo @p0, @p1, @p2, @p3",
                    prestamo.Codlibro, prestamo.Idlector, prestamo.IdEmpleado, diasPrestamo);

                return Ok(prestamo);
            }
            catch (Exception ex)
            {
                
                return BadRequest(ex.InnerException?.Message ?? ex.Message);
            }
        }

        // PUT: api/Prestamos/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPrestamo(int id, Prestamo prestamo)
        {
            if (id != prestamo.IdPrestamo)
            {
                return BadRequest();
            }

           
            if (prestamo.Estado == "R")
            {
                try
                {
             
                    await _context.Database.ExecuteSqlRawAsync(
                        "EXEC sp_ReintegrarLibro @p0",
                        id);

                    return NoContent();
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.InnerException?.Message ?? ex.Message);
                }
            }

            _context.Entry(prestamo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PrestamoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/Prestamos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePrestamo(int id)
        {
            var prestamo = await _context.Prestamos.FindAsync(id);
            if (prestamo == null)
            {
                return NotFound();
            }

            _context.Prestamos.Remove(prestamo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PrestamoExists(int id)
        {
            return _context.Prestamos.Any(e => e.IdPrestamo == id);
        }
    }
}