using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;

namespace Controlador.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoresController : ControllerBase
    {
        private readonly DataContext _context;

        public AutoresController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Autores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Autore>>> GetAutores()
        {
            return await _context.Autores.ToListAsync();
        }

        // GET: api/Autores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Autore>> GetAutore(int id)
        {
            var autore = await _context.Autores.FindAsync(id);

            if (autore == null)
            {
                return NotFound();
            }

            return autore;
        }

        // POST: api/Autores
        [HttpPost]
        public async Task<ActionResult<Autore>> PostAutore(Autore autore)
        {
            _context.Autores.Add(autore);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAutore", new { id = autore.Idautor }, autore);
        }

        // PUT: api/Autores/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAutore(int id, Autore autore)
        {
            if (id != autore.Idautor)
            {
                return BadRequest();
            }

            _context.Entry(autore).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AutoreExists(id))
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

        // DELETE: api/Autores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAutore(int id)
        {
            var autore = await _context.Autores.FindAsync(id);
            if (autore == null)
            {
                return NotFound();
            }

            _context.Autores.Remove(autore);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AutoreExists(int id)
        {
            return _context.Autores.Any(e => e.Idautor == id);
        }
    }
}
