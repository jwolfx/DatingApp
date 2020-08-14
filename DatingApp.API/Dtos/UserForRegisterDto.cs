using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required(ErrorMessage = "El campo Username es requerido.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "El campo Password es requerido.")]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "El campo Password debe tener entre 4 y 8 caracteres de largo.")]
        public string Password { get; set; }
    }
}