using Microsoft.EntityFrameworkCore;

namespace ProjetoIntegrador.Models
{
    public class UsuarioContext : DbContext
    {
        public UsuarioContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<PontosColeta> PontosColeta { get; set; }

    }
}
