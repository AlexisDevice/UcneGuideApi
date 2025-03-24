using System.ComponentModel.DataAnnotations;
using UcneGuideApi.DAL;

namespace UcneGuideApi.Models
{
    public class Comentario
    {
        [Key]
        public int Id { get; set; }
        public string Contenido { get; set; }
        public int MateriaId { get; set; }
        public Materia Materia { get; set; }
        public string UsuarioId { get; set; }
        public ApplicationUser Usuario { get; set; }
    }
}
