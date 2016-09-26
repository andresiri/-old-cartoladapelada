using Repositorio.Transaction;

namespace Business.Services
{
    public class BaseService
    {
        protected IUnitOfWork _unitOfWork;        

        public BaseService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
