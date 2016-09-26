using Domain.Entities;
using Domain.Repository;
using Repositorio.Contexto;

namespace Repositorio.Repositories
{
    public class PeladaUserRepository : BaseRepository<PeladaUser>, IPeladaUserRepository
    {
        public PeladaUserRepository(Context context) : base(context)
        {            
        }           
    }
}
