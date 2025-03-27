using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace UcneGuideApi.Models
{
    public class Profesor
    {
        [Key]
        public int ProfesorId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
    }
}
