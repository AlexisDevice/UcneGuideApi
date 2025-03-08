using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UcneGuideApi.DAL;
using UcneGuideApi.Models;

namespace UcneGuideApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SugerenciasController : ControllerBase
    {
        private readonly Contexto _context;

        public SugerenciasController(Contexto context)
        {
            _context = context;
        }

        // GET: api/Sugerencias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sugerencia>>> GetSugerencias()
        {
            return await _context.Sugerencias.ToListAsync();
        }

        // GET: api/Sugerencias/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Sugerencia>> GetSugerencia(int id)
        {
            var sugerencia = await _context.Sugerencias.FindAsync(id);

            if (sugerencia == null)
            {
                return NotFound();
            }

            return sugerencia;
        }

        // PUT: api/Sugerencias/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSugerencia(int id, Sugerencia sugerencia)
        {
            if (id != sugerencia.Id)
            {
                return BadRequest();
            }

            _context.Entry(sugerencia).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SugerenciaExists(id))
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

        // POST: api/Sugerencias
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Sugerencia>> PostSugerencia(Sugerencia sugerencia)
        {
            _context.Sugerencias.Add(sugerencia);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSugerencia", new { id = sugerencia.Id }, sugerencia);
        }

        // DELETE: api/Sugerencias/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSugerencia(int id)
        {
            var sugerencia = await _context.Sugerencias.FindAsync(id);
            if (sugerencia == null)
            {
                return NotFound();
            }

            _context.Sugerencias.Remove(sugerencia);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SugerenciaExists(int id)
        {
            return _context.Sugerencias.Any(e => e.Id == id);
        }
    }
}
