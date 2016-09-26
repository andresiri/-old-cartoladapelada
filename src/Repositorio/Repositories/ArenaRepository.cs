using Domain.Entities;
using Domain.Repository;
using Repositorio.Contexto;

namespace Repositorio.Repositories
{
    public class ArenaRepository : BaseRepository<Arena>, IArenaRepository
    {
        public ArenaRepository(Context context) : base(context)
        {            
        }
    }
}
