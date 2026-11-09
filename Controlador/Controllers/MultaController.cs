using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;

namespace Controlador.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MultasController : ControllerBase
    {
        private readonly DataContext _context;

        public MultasController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Multas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Multum>>> GetMultas()
        {
            return await _context.Multa.ToListAsync();
        }

        // GET: api/Multas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Multum>> GetMulta(int id)
        {
            var multa = await _context.Multa.FindAsync(id);

            if (multa == null)
            {
                return NotFound();
            }

            return multa;
        }

        // POST: api/Multas
        [HttpPost]
        public async Task<ActionResult<Multum>> PostMulta(Multum multa)
        {
            _context.Multa.Add(multa);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMulta", new { id = multa.Idmulta }, multa);
        }

        // PUT: api/Multas/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMulta(int id, Multum multa)
        {
            if (id != multa.Idmulta)
            {
                return BadRequest();
            }

            _context.Entry(multa).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MultaExists(id))
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

        // DELETE: api/Multas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMulta(int id)
        {
            var multa = await _context.Multa.FindAsync(id);
            if (multa == null)
            {
                return NotFound();
            }

            _context.Multa.Remove(multa);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MultaExists(int id)
        {
            return _context.Multa.Any(e => e.Idmulta == id);
        }
    }
}
