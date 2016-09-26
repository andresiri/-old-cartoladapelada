using System;
using Domain.Entities;
using Domain.Services;
using Repositorio.Transaction;

namespace Business.Services
{
    public class PeladaService : IPeladaService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PeladaService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Pelada Read(int id)
        {
            try
            {
                var pelada = _unitOfWork.PeladaRepository.GetById(id);
                return pelada;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Pelada Create(Pelada obj)
        {
            try
            {                
                var newPelada = _unitOfWork.PeladaRepository.Create(obj);
                _unitOfWork.Save();
                return newPelada;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(int peladaId)
        {
            try
            {
                _unitOfWork.PeladaRepository.Delete(peladaId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
