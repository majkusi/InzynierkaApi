using InzynierkaApi.Context;
using InzynierkaApi.Models;
using InzynierkaApi.Repositories;

namespace InzynierkaApi.Repositories
{

    public class StudentRepository : IStudentRepository
    {
        private readonly AttendanceContext context;

        public StudentRepository(AttendanceContext context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IEnumerable<StudentModel> GetStudents()
        {
            return context.Students;
        }


        public StudentModel GetStudentById(int id)
        {
            return context.Students.Find(id);
        }

        // Implement other interface methods...
    }
}