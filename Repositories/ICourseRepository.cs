using InzynierkaApi.Models;

namespace InzynierkaApi.Repositories;

public interface ICourseRepository : IDisposable
{
    ICollection<CourseModel> GetCourses();
    CourseModel GetCourseById(int id);
    void InsertCourse(CourseModel course); 
    void UpdateCourse(CourseModel course);
    void DeleteCourse(int id);
    void Save();
    ICollection<CourseModel> GetByDate(DateTime date);
}