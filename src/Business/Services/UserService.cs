using Domain.Entities;
using Domain.Lib;
using Domain.Services;
using Repositorio.Transaction;
using System;

namespace Business.Services
{
    public class UserService : IUserService
    {        
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {            
            _unitOfWork = unitOfWork;
        }

        public User Create(User obj)
        {
            try
            {
                obj.Validate();

                var existentUser = _unitOfWork.UserRepository.GetByEmailAddress(obj.Email);

                if (existentUser != null)
                {
                    throw new Exception("Email already in use.");
                }

                obj.Password = Password.hash(obj.Password, obj.Email);

                var newUser = _unitOfWork.UserRepository.Create(obj);
                _unitOfWork.Save();

                return newUser;
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }
    }
}
