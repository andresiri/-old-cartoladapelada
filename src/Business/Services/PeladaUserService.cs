using System;
using Domain.Entities;
using Domain.Services;
using Repositorio.Transaction;

namespace Business.Services
{
    public class PeladaUserService : BaseService, IPeladaUserService
    {
        public PeladaUserService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public PeladaUser Create(PeladaUser obj)
        {
            try
            {
                var newPeladaUser = _unitOfWork.PeladaUserRepository.Create(obj);
                _unitOfWork.Save();
                return newPeladaUser;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
