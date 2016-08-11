using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Repositorio.Contexto
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<Usuario> User { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            ConfigureUsuario(builder);
            
            base.OnModelCreating(builder);
        }
        private static void ConfigureUsuario(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>(b =>
            {
                b.ToTable("usuario");
                b.HasKey(u => u.Id);
                b.Property(u => u.Id).HasColumnName("id");
                b.Property(u => u.Nome).IsRequired().HasMaxLength(100).HasColumnName("nome");
                b.Property(u => u.SobreNome).HasMaxLength(100).HasColumnName("sobrenome");
                b.Property(u => u.Email).IsRequired().HasMaxLength(100).HasColumnName("email");
                b.Property(u => u.Senha).IsRequired().HasMaxLength(100).HasColumnName("senha");
                b.Property(u => u.Apelido).HasMaxLength(100).HasColumnName("apelido");
                b.Property(u => u.Numero).HasColumnName("numero");
                b.Property(u => u.Posicao).HasMaxLength(100).HasColumnName("posicao");
            });
        }
    }
}
