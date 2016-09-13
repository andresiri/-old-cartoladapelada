using System.Collections.Generic;
using Domain.Repository;
using Repositorio.Contexto;
using System.Linq;

namespace Repositorio.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T: class
    {
        protected Context _context;

        public BaseRepository(Context context)
        {
            _context = context;
        }      

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }
    }
}
