using InzynierkaApi.Models;

namespace InzynierkaApi.Repositories;

public interface IStudentRepository
{
    IEnumerable<StudentModel> GetStudents();
    StudentModel GetStudentById(int id);

}