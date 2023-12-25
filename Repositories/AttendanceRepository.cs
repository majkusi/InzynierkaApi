using InzynierkaApi.Context;
using InzynierkaApi.Models;

namespace InzynierkaApi.Repositories;

public class AttendanceRepository : IAttendanceRepository
{
    private readonly AttendanceContext context;

    public AttendanceRepository(AttendanceContext context)
    {
        this.context = context;
    }

    public List<AttendanceModel> GetAttendanceListByCourse(int courseId)
    {
        return context.AttendanceList
            .Where(attendance => attendance.CourseId == courseId)
            .ToList();
    }

    public List<AttendanceModel> GetAttendanceListByStudent(int studentId)
    {
        return context.AttendanceList
            .Where(attendance => attendance.StudentId == studentId)
            .ToList();
    }

    public AttendanceModel PutNewAttendance(int studentId, int courseId, bool isPresent)
    {
        var newAttendance = new AttendanceModel
        {
            StudentId = studentId,
            CourseId = courseId,
            IsPresent = isPresent
        };

        context.AttendanceList.Add(newAttendance);
        context.SaveChanges();

        return newAttendance;
    }


}