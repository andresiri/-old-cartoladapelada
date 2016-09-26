using Domain.Entities;

namespace Domain.Repository
{
    public interface IUserRepository : IBaseRepository<User>
    {        
        void Delete(int userId);
    }
}
