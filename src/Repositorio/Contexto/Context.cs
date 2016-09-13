using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Repositorio.Contexto
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<User> User { get; set; }
        public DbSet<Pelada> Pelada { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            ConfigureUser(builder);
            ConfigurePelada(builder);

            base.OnModelCreating(builder);
        }
        private static void ConfigureUser(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(b =>
            {
                b.ToTable("user");
                b.HasKey(u => u.Id);
                b.Property(u => u.Id).HasColumnName("id");
                b.Property(u => u.FirstName).IsRequired().HasMaxLength(100).HasColumnName("firstName");
                b.Property(u => u.LastName).HasMaxLength(100).HasColumnName("lastName");
                b.Property(u => u.Email).IsRequired().HasMaxLength(100).HasColumnName("email");
                b.Property(u => u.Password).IsRequired().HasMaxLength(100).HasColumnName("password");
                b.Property(u => u.Nickname).HasMaxLength(100).HasColumnName("nickname");
                b.Property(u => u.Number).HasColumnName("number");
                b.Property(u => u.Position).HasMaxLength(100).HasColumnName("position");
            });
        }

        private static void ConfigurePelada(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pelada>(b =>
            {
                b.ToTable("pelada");
                b.HasKey(p => p.Id);
                b.Property(p => p.Id).HasColumnName("id");
                b.Property(p => p.Description).HasColumnName("description").HasMaxLength(50);
                b.Property(p => p.CreatedByUserId).HasColumnName("createdByUserId");
                b.HasOne(p => p.User).WithMany(p => p.Peladas).HasForeignKey(p => p.CreatedByUserId).HasConstraintName("ForeignKey_Pelada_User");
            });
        }
    }
}
