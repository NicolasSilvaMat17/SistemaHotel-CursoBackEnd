using Microsoft.EntityFrameworkCore;
using SistemaHotel.Model.Classes.Entidades;

namespace SistemaHotel.Model.Classes.Contextos
{
    internal class ContextoFuncionario : DbContext
    {
        // Propriedades
        public DbSet<Entidades.Funcionario> Funcionarios { get; set; }


        // Metodo

        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
        {
            string caminho = @"Server=ECFP507D1319387\SQLEXPRESS01;Database=SistemaHotel;Trusted_Connection=True;TrustServerCertificate=True";
            opcoesDeConstrucao.UseSqlServer(caminho);
        }


        protected override void OnModelCreating(ModelBuilder modeloDeConstrucao)
        {
            modeloDeConstrucao.Entity<Funcionario>(entidade =>
            {
                entidade.HasKey(e => e.Id);

                entidade.Property(e => e.Nome);

                entidade.Property(e => e.Telefone);

                entidade.Property(e => e.CPF);

                entidade.Property(e => e.Endereco);

            }

        );
        }
    }
}

    

