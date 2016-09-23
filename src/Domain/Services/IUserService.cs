using Domain.Entities;

namespace Domain.Services
{
    public interface IUserService
    {
        User Create(User obj);
        void Delete(int userId);
    }
}
