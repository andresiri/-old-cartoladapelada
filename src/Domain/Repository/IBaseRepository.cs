using System.Collections.Generic;

namespace Domain.Repository
{
    public interface IBaseRepository<T> where T: class
    {
        IEnumerable<T> GetAll();
    }
}
