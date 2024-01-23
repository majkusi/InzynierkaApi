using InzynierkaApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace InzynierkaApi.Controllers
{
    [ApiController]
    [Route("Attendance/")]
    public class AttendanceController : Controller
    {
        private readonly IAttendanceRepository _attendanceRepository;

        public AttendanceController(IAttendanceRepository attendanceRepository)
        {
            _attendanceRepository = attendanceRepository;
        }

        [HttpGet("GetByCourse/{courseId}")]
        public IActionResult GetByCourse(int courseId)
        {
            var listByCourse = _attendanceRepository.GetAttendanceListByCourse(courseId);
            return Ok(listByCourse);
        }
        [HttpGet("GetByStudent/{albumId}")]
        public IActionResult GetByStudent(int albumId)
        {
            var listByCourse = _attendanceRepository.GetAttendanceListByStudent(albumId);
            
            return Ok(listByCourse);
        }

        [HttpPost("NewAttendance/{studentId}/{courseId}/{isPresent}")]
        public IActionResult PutNewAttendance(int studentId, int courseId, bool isPresent)
        {
            var addNewAttentance = _attendanceRepository.PutNewAttendance(studentId, courseId, isPresent);
            return Ok(addNewAttentance);
        }

    }
}
