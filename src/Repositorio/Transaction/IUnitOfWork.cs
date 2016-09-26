using Repositorio.Repositories;

namespace Repositorio.Transaction
{
    public interface IUnitOfWork
    {
        UserRepository UserRepository { get; }
        PeladaRepository PeladaRepository { get; }
        PeladaUserRepository PeladaUserRepository { get; }
        ArenaRepository ArenaRepository { get; }
        void Save();
        void Commit();
        void Rollback();        
    }
}
