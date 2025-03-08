using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace UcneGuideApi.Models
{
    public class ApplicationUser : IdentityUser { }

    public class Sugerencia
    {
        [Key]
        public int Id { get; set; }
        public string Contenido { get; set; }
        public string UsuarioId { get; set; }
        public ApplicationUser Usuario { get; set; }
    }
}
