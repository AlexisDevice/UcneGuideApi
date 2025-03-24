using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System.Security.Claims;
using UcneGuideApi.DAL;
using UcneGuideApi.Models;
using Microsoft.AspNetCore.Identity;

namespace UcneGuideApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class SugerenciasController : ControllerBase
    {
        private readonly Contexto _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public SugerenciasController(Contexto context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: api/Sugerencias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sugerencia>>> GetSugerencias()
        {
            return await _context.Sugerencias.Include(s => s.Usuario).ToListAsync();
        }

        // GET: api/Sugerencias/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Sugerencia>> GetSugerencia(int id)
        {
            var sugerencia = await _context.Sugerencias.Include(s => s.Usuario).FirstOrDefaultAsync(s => s.Id == id);

            if (sugerencia == null)
            {
                return NotFound();
            }

            return sugerencia;
        }

        // PUT: api/Sugerencias/5
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
        [HttpPost]
        public async Task<ActionResult<Sugerencia>> PostSugerencia(Sugerencia sugerencia)
        {
            // Obtener el ID del usuario desde el token JWT
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            // Buscar el usuario por el Id (para establecer la relación)
            var usuario = await _userManager.FindByIdAsync(userId);

            if (usuario == null)
            {
                return Unauthorized(new { message = "Usuario no autenticado" });
            }

            // Asignar el usuario a la sugerencia
            sugerencia.UsuarioId = userId;
            sugerencia.Usuario = usuario;

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
