using InzynierkaApi.Context;
using InzynierkaApi.Models;

namespace InzynierkaApi.Repositories;

public interface ILoginRepository
{

    bool ValidateLogin(string email, string password);
}