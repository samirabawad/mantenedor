using Microsoft.EntityFrameworkCore;

namespace Mantenedor_oficial_salaventasOLD.Models
{
    public class SvdDbContext : DbContext
    {
        public SvdDbContext(DbContextOptions<SvdDbContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("USUARIO");
                entity.HasKey(e => e.IdUsuario);
            });
        }
    }
}