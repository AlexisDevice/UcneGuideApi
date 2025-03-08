using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace UcneGuideApi.Models
{
    public class Materia
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
    }
}
