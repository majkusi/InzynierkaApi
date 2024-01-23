using InzynierkaApi.Context;
using InzynierkaApi.Models;
namespace InzynierkaApi.Repositories;

public class LoginRepository : ILoginRepository
{
    private AttendanceContext context;

    public LoginRepository(AttendanceContext context)
    {
        this.context = context;
    }

    public bool ValidateLogin(string email, string password)
    {
        return context.TeacherLogin.Any(user => user.Email == email && user.Password == password);
    }
}
