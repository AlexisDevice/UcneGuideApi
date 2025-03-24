using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using UcneGuideApi.DAL;

namespace UcneGuideApi.Models
{

    public class Sugerencia
    {
        [Key]
        public int Id { get; set; }
        public string Contenido { get; set; }
        public string UsuarioId { get; set; }
        public ApplicationUser Usuario { get; set; }
    }
}
