using Domain.Entities;
using Domain.Repository;
using Repositorio.Contexto;

namespace Repositorio.Repositories
{
    public class UserRepository : IUserRepository
    {
        private Context _context;

        public UserRepository(Context context)
        {
            _context = context;
        }

        public User Create(User user)
        {
            _context.User.Add(user);
            _context.SaveChanges();
            return user;
        }
    }
}
