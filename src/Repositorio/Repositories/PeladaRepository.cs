using Domain.Entities;
using Domain.Repository;
using Repositorio.Contexto;
using System.Linq;
using Domain.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace Repositorio.Repositories
{
    public class PeladaRepository : BaseRepository<Pelada>, IPeladaRepository
    {
        public PeladaRepository(Context context) : base(context)
        {           
        }
        
        public void Delete(int peladaId)
        {
            var pelada = GetById(peladaId);

            if (pelada == null)
            {
                var exception = new EntityNotFoundException(peladaId);
                throw exception;
            }

            _context.Pelada.Remove(pelada);
        }

        public Pelada GetById(int peladaId)
        {
            var pelada = _context.Pelada
                .Include(p => p.CreatedByUser)
                .Where(w => w.Id.Equals(peladaId))
                .FirstOrDefault();

            return pelada;
        }
    }
}
