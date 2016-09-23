using Domain.Entities;

namespace Domain.Services
{
    public interface ILoginService
    {        
        User Login(string email, string password);
    }
}
