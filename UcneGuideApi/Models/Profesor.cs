using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace UcneGuideApi.Models
{
    public class Profesor
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
    }
}
