using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoIntegrador.Models;

namespace ProjetoIntegrador.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PontosColetaController : ControllerBase
    {
        private readonly UsuarioContext _context;

        public PontosColetaController(UsuarioContext context)
        {
            _context = context;
        }

        // GET: api/Usuario
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PontosColeta>>> GetPontosColeta()
        {
          if (_context.PontosColeta == null)
          {
              return NotFound();
          }
            return await _context.PontosColeta.ToListAsync();
        }

        // GET: api/Usuario/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PontosColeta>> GetPontosColeta(int id)
        {
          if (_context.PontosColeta == null)
          {
              return NotFound();
          }
            var PontosColeta = await _context.PontosColeta.FindAsync(id);

            if (PontosColeta == null)
            {
                return NotFound();
            }

            return PontosColeta;
        }

        // PUT: api/Usuario/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPontosColeta(int id, PontosColeta pontosColeta)
        {
            if (id != pontosColeta.Id)
            {
                return BadRequest();
            }

            _context.Entry(pontosColeta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PontosColetaExists(id))
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

        // POST: api/Usuario
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PontosColeta>> PostPontosColeta(PontosColeta pontosColeta)
        {
          if (_context.PontosColeta == null)
          {
              return Problem("Entity set 'UsuarioContext.PontosColeta'  is null.");
          }
            _context.PontosColeta.Add(pontosColeta);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPontosColeta", new { id = pontosColeta.Id }, pontosColeta);
        }

        // DELETE: api/Usuario/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePontosColeta(int id)
        {
            if (_context.PontosColeta == null)
            {
                return NotFound();
            }
            var pontosColeta = await _context.PontosColeta.FindAsync(id);
            if (pontosColeta == null)
            {
                return NotFound();
            }

            _context.PontosColeta.Remove(pontosColeta);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PontosColetaExists(int id)
        {
            return (_context.PontosColeta?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
