using System.ComponentModel.DataAnnotations;

namespace UcneGuideApi.Models
{
    public class RegisterModel
    {
        [Required]
        public string UserName { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required, MinLength(8)]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*\d).{8,}$", ErrorMessage = "La contraseña debe tener al menos una mayúscula y un número.")]
        public string Password { get; set; }
    }
}
