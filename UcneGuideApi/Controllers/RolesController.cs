using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using UcneGuideApi.DAL;
using UcneGuideApi.Models;

namespace UcneGuideApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class RolesController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public RolesController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [HttpPost("asignar")]
        public async Task<IActionResult> AsignarRol([FromBody] RolAsignacionModel model)
        {
            var usuario = await _userManager.FindByIdAsync(model.UserId);
            if (usuario == null)
                return NotFound(new { message = "Usuario no encontrado" });

            if (!await _roleManager.RoleExistsAsync(model.Role))
            {
                await _roleManager.CreateAsync(new IdentityRole(model.Role));
            }

            var resultado = await _userManager.AddToRoleAsync(usuario, model.Role);
            if (!resultado.Succeeded)
                return BadRequest(resultado.Errors);

            return Ok(new { message = $"Rol '{model.Role}' asignado correctamente al usuario {usuario.UserName}" });
        }
    }

    public class RolAsignacionModel
    {
        public string UserId { get; set; }
        public string Role { get; set; }
    }
}
