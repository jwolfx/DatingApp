using System.Threading.Tasks;
using DatingApp.API.Data;
using DatingApp.API.Dtos;
using DatingApp.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.API.Controllers
{
    [Route("api/[controller]")]
    //[ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository repo;

        public AuthController(IAuthRepository repo)
        {
            this.repo = repo;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody]UserForRegisterDto userDto)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            userDto.Username = userDto.Username.ToLower();

            if (await repo.UserExists(userDto.Username))
                return BadRequest("El username ya se encuentra registrado.");

            var user = new User
            {
                Username = userDto.Username
            };

            user = await repo.Register(user, userDto.Password);

            return StatusCode(201);
        }
    }
}