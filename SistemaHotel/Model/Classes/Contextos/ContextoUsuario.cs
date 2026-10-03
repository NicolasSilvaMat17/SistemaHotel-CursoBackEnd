

using Microsoft.EntityFrameworkCore;
using SistemaHotel.Model.Classes.Entidades;

namespace SistemaHotel.Model.Classes.Contextos
{
    internal class ContextoUsuario : DbContext
    {
        // Propriedades
        public DbSet<Entidades.Usuario> Usuarios { get; set; }

        // Metodo
        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
        {
            string caminho = @"Server=ECFP507D1319387\SQLEXPRESS01;Database=SistemaHotel;Trusted_Connection=True;TrustServerCertificate=True";
            opcoesDeConstrucao.UseSqlServer(caminho);
        }

        protected override void OnModelCreating(ModelBuilder modeloDeConstrucao)
        {
            modeloDeConstrucao.Entity<Usuario>(entidade =>
            {
                entidade.HasKey(e => e.Id);

                entidade.Property(e => e.Nome);

                entidade.Property(e => e.UsuarioE);

                entidade.Property(e => e.Cargo);

                entidade.Property(e => e.Senha);

            }

        );
        }
    }
}
