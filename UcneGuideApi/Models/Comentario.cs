using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UcneGuideApi.DAL;

namespace UcneGuideApi.Models
{
    public class Comentario
    {
        [Key]
        public int Id { get; set; }
        public string Contenido { get; set; }
       
        [ForeignKey ("MateriaId")]
        public int MateriaId { get; set; }

        [ForeignKey("UsuarioId")]
        public string UsuarioId { get; set; }
    }
}
