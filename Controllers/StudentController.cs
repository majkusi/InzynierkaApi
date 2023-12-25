using InzynierkaApi.Repositories;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("Students/")]
public class StudentController : Controller
{
    private readonly IStudentRepository _studentRepository;

    public StudentController(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }

    [HttpGet("/GetAll")]
    public IActionResult GetAll()
    {
        var students = _studentRepository.GetStudents();
   
        return Ok(students);
    }
    [HttpGet("/GetById/{id}")]
    public IActionResult GetById(int id)
    {
        var course = _studentRepository.GetStudentById(id);
        return Ok(course);
    }
}