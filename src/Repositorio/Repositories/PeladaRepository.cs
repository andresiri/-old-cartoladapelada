using Domain.Entities;
using Domain.Repository;
using Repositorio.Contexto;
using System.Linq;
using Domain.Exceptions;

namespace Repositorio.Repositories
{
    public class PeladaRepository : BaseRepository<Pelada>, IPeladaRepository
    {
        public PeladaRepository(Context context) : base(context)
        {
            _context = context;
        }

        public Pelada Create(Pelada pelada)
        {
            _context.Pelada.Add(pelada);

            return pelada;
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
            var pelada = _context.Pelada.Where(w => w.Id.Equals(peladaId)).FirstOrDefault();

            return pelada;
        }
    }
}
