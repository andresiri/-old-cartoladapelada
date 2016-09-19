namespace Domain.Services
{
    public interface ILoginService
    {        
        bool Login(string email, string password);
    }
}
