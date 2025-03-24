using System.ComponentModel.DataAnnotations;

namespace UcneGuideApi.Models;

public class LoginModel
{
    [Required]
    public string Login { get; set; } // Puede ser username o email

    [Required]
    public string Password { get; set; }
}
