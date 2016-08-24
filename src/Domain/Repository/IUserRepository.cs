using Domain.Entities;

namespace Domain.Repository
{
    public interface IUserRepository
    {
        User Create(User user);
    }
}
