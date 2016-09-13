using Microsoft.EntityFrameworkCore.Storage;
using Repositorio.Contexto;
using Repositorio.Repositories;
using System;

namespace Repositorio.Transaction
{
    public class UnitOfWork : IUnitOfWork, IDisposible
    {
        protected Context context;
        private IDbContextTransaction transaction;

        public UnitOfWork(Context _context)
        {
            context = _context;
            transaction = context.Database.BeginTransaction();
        }

        private UserRepository userRepository;
        public UserRepository UserRepository
        {
            get
            {
                if (userRepository == null)
                {
                    userRepository = new UserRepository(context);
                }

                return userRepository;
            }
        }        

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            disposed = true;
        }

        public void Save()
        {
            Commit();
            context.SaveChanges();
        }        

        public void Commit()
        {
            transaction.Commit();
        }

        public void Rollback()
        {
            transaction.Rollback();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
