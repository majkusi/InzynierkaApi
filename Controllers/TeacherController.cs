using InzynierkaApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace InzynierkaApi.Controllers
{
    [ApiController]
    [Route("Teacher/")]
    public class TeacherController : Controller
    {
        private readonly ITeacherRepository _teacherRepository;

        public TeacherController(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }
        [HttpGet("GetTeachers")]
        public IActionResult GetTeahers()
        {
            var teacher = _teacherRepository.GetTeachers();
            return Ok(teacher);
        }

        [HttpGet("GetTeacherById/{id}")]
        public IActionResult GetTeacherById(int id)
        {
            var teacher = _teacherRepository.GetTeacherById(id);
            return Ok(teacher);
        }

    }
}
