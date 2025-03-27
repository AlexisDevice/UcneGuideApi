using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UcneGuideApi.DAL;

namespace UcneGuideApi.Models
{

    public class Sugerencia
    {
        [Key]
        public int SugerenciaId { get; set; }
        public string Contenido { get; set; }

        [ForeignKey("UsuarioId")]
        public int UsuarioId { get; set; }
        
    }
}
