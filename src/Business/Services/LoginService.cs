using Domain.Lib;
using Domain.Services;
using Repositorio.Transaction;
using System;

namespace Business.Services
{
    public class LoginService : ILoginService
    {
        private readonly IUnitOfWork _unitOfWork;

        public LoginService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public bool Login(string email, string password)
        {
            try
            {
                var user = _unitOfWork.UserRepository.GetByEmailAddress(email);

                if (user != null)
                {
                    var hashPassword = Password.hash(password, email);

                    if (hashPassword.Equals(user.Password))
                    {
                        return true;
                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
