using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserLoginDto
    {
        [Required(ErrorMessage = "El campo Username es requerido.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "El campo Password es requerido.")]
        public string Password { get; set; }
    }
}