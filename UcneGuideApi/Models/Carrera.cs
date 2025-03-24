using System.ComponentModel.DataAnnotations;

namespace UcneGuideApi.Models
{
    public class Carrera
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Codigo { get; set; }

        public string Descripcion { get; set; }
    }
}
