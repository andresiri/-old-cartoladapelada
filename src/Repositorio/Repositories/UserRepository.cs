using Domain.Entities;
using Domain.Repository;
using Repositorio.Contexto;
using System.Linq;

namespace Repositorio.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(Context context) : base(context)
        {            
        }       

        public void Delete(int userId)
        {
            var user = GetById(userId);

            if (user != null)
            {
                _context.User.Remove(user);
            }
        }

        public User GetById(int userId)
        {
            var user = _context.User.Where(w => w.Id.Equals(userId)).FirstOrDefault();

            return user;
        }

        public User GetByEmailAddress(string emailAddress)
        {
            emailAddress = emailAddress.Trim();
            var user = _context.User.Where(u => u.Email.Equals(emailAddress)).FirstOrDefault();
            return user;
        }
    }
}
