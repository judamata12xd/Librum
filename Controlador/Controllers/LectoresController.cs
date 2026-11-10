using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;

namespace Controlador.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LectoresController : ControllerBase
    {
        private readonly DataContext _context;

        public LectoresController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Lectores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Lectore>>> GetLectores()
        {
            return await _context.Lectores.ToListAsync();
        }

        // GET: api/Lectores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Lectore>> GetLector(int id)
        {
            var lector = await _context.Lectores.FindAsync(id);

            if (lector == null)
            {
                return NotFound();
            }

            return lector;
        }



        // POST: api/Lectores
        [HttpPost]
        public async Task<ActionResult<Lectore>> PostLector(Lectore lector)
        {
            bool existe = await _context.Lectores.AnyAsync(l => l.Documento == lector.Documento);
            if (existe)
            {
                return BadRequest("El usuario o documento ya existe en el sistema.");
            }

            _context.Lectores.Add(lector);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLector", new { id = lector.Idlector }, lector);
        }

        // PUT: api/Lectores/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLector(int id, Lectore lector)
        {
            if (id != lector.Idlector)
            {
                return BadRequest();
            }

            _context.Entry(lector).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LectorExists(id))
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

        // DELETE: api/Lectores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLector(int id)
        {
            var lector = await _context.Lectores.FindAsync(id);
            if (lector == null)
            {
                return NotFound();
            }

            _context.Lectores.Remove(lector);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LectorExists(int id)
        {
            return _context.Lectores.Any(e => e.Idlector == id);
        }
    }
}