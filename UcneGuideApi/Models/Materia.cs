using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UcneGuideApi.Models
{
    public class Materia
    {
        [Key]
        public int MateriaId { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }

        [ForeignKey("CarreraId")]
        public int CarreraId { get; set; }

        [ForeignKey("ProfesorId")]
        public int ProfesorId { get; set; }
    }
}
