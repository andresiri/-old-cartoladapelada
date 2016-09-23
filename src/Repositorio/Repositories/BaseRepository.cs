using System.Collections.Generic;
using Domain.Repository;
using Repositorio.Contexto;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Repositorio.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T: class
    {
        protected Context _context;
        protected DbSet<T> DbSet;

        public BaseRepository(Context context)
        {
            _context = context;
            DbSet = context.Set<T>();
        }       

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }
    }
}
