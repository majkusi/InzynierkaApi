using InzynierkaApi.Context;
using InzynierkaApi.Models;

namespace InzynierkaApi.Repositories;

public interface ITeacherRepository
{
    public ICollection<TeacherModel> GetTeachers();
    public TeacherModel GetTeacherById(int id);
    public void UpdateTeacher(TeacherModel teacher);
    public void Save();
}