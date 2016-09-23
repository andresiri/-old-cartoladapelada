using Domain.Entities;

namespace Domain.Repository
{
    public interface IPeladaRepository : IBaseRepository<Pelada>
    {
        void Delete(int peladaId);
        Pelada GetById(int peladaId);
    }
}
