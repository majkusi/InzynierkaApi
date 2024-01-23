using InzynierkaApi.Context;
using InzynierkaApi.Models;

namespace InzynierkaApi.Repositories;

public class TeacherRepository : ITeacherRepository
{
    private  AttendanceContext context;
    public TeacherRepository(AttendanceContext context)
    {
        this.context = context;
    }
    public ICollection<TeacherModel> GetTeachers()
    {
        return context.Teachers.ToList();
    }

    public TeacherModel GetTeacherById(int id)
    {
        return context.Teachers.Find(id);
    }


    public void UpdateTeacher(TeacherModel teacher)
    {
        context.Teachers.Update(teacher);
    }
    public void Save()
    {
        context.SaveChanges();
    }
    private bool disposed = false;

    protected virtual void Dispose(bool disposing)
    {
        if (!this.disposed)
        {
            if (disposing)
            {
                context.Dispose();
            }
        }
        this.disposed = true;
    }
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}
