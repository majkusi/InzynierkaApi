using InzynierkaApi.Models;
using InzynierkaApi.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using InzynierkaApi.Services;

namespace InzynierkaApi.Controllers
{
    [ApiController]
    [Route("Login/")]
    public class LoginController : ControllerBase
    {
        private  LoginService _loginService;
        public LoginController(LoginService loginService)
        {
            _loginService = loginService;
        }
        [HttpPost("GiveCredentials")]
        public IActionResult Login([FromBody] TeacherLoginModel model)
        {
            if (_loginService.IsValidUser(model.Email, model.Password))
            {
                var token = _loginService.GenerateJwtToken(model.Email);
                return Ok(new { Token = token });
            }
            return Unauthorized();
        }
    }
}




