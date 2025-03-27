using System.ComponentModel.DataAnnotations;

namespace UcneGuideApi.Models
{
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
    }
}
