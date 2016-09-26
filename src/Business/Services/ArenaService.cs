using System;
using Domain.Entities;
using Domain.Services;
using Repositorio.Transaction;

namespace Business.Services
{
    public class ArenaService : BaseService, IArenaService
    {
        public ArenaService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public Arena Create(Arena obj)
        {
            try
            {
                var newObj = _unitOfWork.ArenaRepository.Create(obj);
                _unitOfWork.Save();
                return newObj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
