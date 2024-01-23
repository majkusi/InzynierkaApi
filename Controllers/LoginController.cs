using InzynierkaApi.Models;
using InzynierkaApi.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
namespace InzynierkaApi.Controllers
{
    [ApiController]
    [Route("Login/")]
    public class LoginController : ControllerBase
    {
        private readonly ILoginRepository _loginRepository;

        public LoginController(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }
       
        [HttpPost("GiveCredentials")]
        public IActionResult Login([FromBody] TeacherLoginModel model)
        {
            // Validate user credentials (you may use a database here)
            if (IsValidUser(model.Email, model.Password))
            {
                var token = GenerateJwtToken(model.Email);
                return Ok(new { Token = token });
            }

            return Unauthorized();
        }

        private bool IsValidUser(string username, string password)
        {
            // Implement your user validation logic (e.g., check against a database)
            return _loginRepository.ValidateLogin(username, password);
        }

        private string GenerateJwtToken(string username)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes("your-secret-key-should-be-longer-and-secure");
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, username) }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials =
                    new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

    }
}




