using Domain.Entities;

namespace Domain.Services
{    
    public interface IPeladaService
    {
        Pelada Create(Pelada obj);
        void Delete(int peladaId);
    }
}
