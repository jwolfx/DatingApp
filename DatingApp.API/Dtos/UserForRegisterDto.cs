using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "El Password debe tener un mínimo de 4 caracteres y un máximo de 8.")]
        public string Password { get; set; }
    }
}