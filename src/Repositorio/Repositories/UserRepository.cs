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
            _context = context;
        }

        public User Create(User user)
        {                        
            _context.User.Add(user);            
            
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
