using InzynierkaApi.Models;

namespace InzynierkaApi.Repositories;

public interface IAttendanceRepository
{
    List<AttendanceModel> GetAttendanceListByCourse(int courseId);
    List<AttendanceModel> GetAttendanceListByStudent(int albumId);
    AttendanceModel PutNewAttendance(int studentId, int courseId, bool isPresent);
}