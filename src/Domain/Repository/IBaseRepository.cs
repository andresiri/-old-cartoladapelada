using System.Collections.Generic;

namespace Domain.Repository
{
    public interface IBaseRepository<T> where T: class
    {
        T Create(T obj);
        IEnumerable<T> GetAll();        
    }
}
