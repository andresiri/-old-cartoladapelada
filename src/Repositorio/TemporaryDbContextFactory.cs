using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Repositorio.Contexto;

namespace Repositorio
{
    public class TemporaryDbContextFactory : IDbContextFactory<Context>
    {
        public Context Create(DbContextFactoryOptions options)
        {
            var builder = new DbContextOptionsBuilder<Context>();
            builder.UseNpgsql("User ID=postgres;Password=andresiri;Host=localhost;Port=5432;Database=cartolaDaPelada;Pooling=true;");
            return new Context(builder.Options, new HttpContextAccessor());
        }
    }
}
