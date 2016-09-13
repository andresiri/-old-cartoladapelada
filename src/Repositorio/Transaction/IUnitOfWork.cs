using Repositorio.Repositories;

namespace Repositorio.Transaction
{
    public interface IUnitOfWork
    {
        UserRepository UserRepository { get; }
        void Save();
        void Commit();
        void Rollback();        
    }
}
