using InzynierkaApi.Models;
using InzynierkaApi.Repositories;
using Microsoft.AspNetCore.Mvc;
namespace InzynierkaApi.Controllers
{
    [ApiController]
    [Route("Login/")]
    public class LoginController : Controller
    {
        private readonly ILoginRepository _loginRepository;

        public LoginController(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }

        [HttpGet("{email}/{password}")]
        public IActionResult Login(string email, string password)
        {
            // Validate login credentials
            bool isValidLogin = _loginRepository.ValidateLogin(email, password);

            if (isValidLogin)
            {
                // Return a success response
                return Ok("Login successful");
            }
            else
            {
                // Return an error response
                return BadRequest("Invalid login credentials");
            }
        }

    }
}




