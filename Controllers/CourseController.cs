using InzynierkaApi.Context;
using InzynierkaApi.Models;
using InzynierkaApi.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace InzynierkaApi.Controllers
{
    [ApiController]
    [Route("Course/")]
    public class CourseController : Controller
    {
        private readonly ICourseRepository _courseRepository;
        private readonly AttendanceContext context;
        public CourseController(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        [HttpGet("GetById/{id}")]
        public IActionResult GetById(int id)
        {
            var course =_courseRepository.GetCourseById(id);
            return Ok(course);
        }


        [HttpGet("GetCourse")]
        public IActionResult GetCourse()
        {
            var course = _courseRepository.GetCourses();
            if (course.Equals(null))
            {
                return NotFound();
            }
            return Ok(course);
        }

        [HttpPost("AddCourse")]
        public IActionResult AddCourse(CourseModel courseModel)
        {
            _courseRepository.InsertCourse(courseModel);
            return Ok();
        }

        [HttpGet("GetByDate/{date}")]
        public IActionResult GetCourseByDate(DateTime date)
        {
            var course = _courseRepository.GetByDate(date);
            return Ok(course);
        }
  
    }
}
