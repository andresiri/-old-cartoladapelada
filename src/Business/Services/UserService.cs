using Domain.Entities;
using Domain.Repository;
using Domain.Services;

namespace Business.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User Create(User obj)
        {
            var newUser = _userRepository.Create(obj);

            return newUser;
        }
    }
}
