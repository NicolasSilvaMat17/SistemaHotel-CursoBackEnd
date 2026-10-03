using Microsoft.EntityFrameworkCore;
using SistemaHotel.Model.Classes.Entidades;

namespace SistemaHotel.Model.Classes.Contextos
{
    internal class ProdutoContext : DbContext
    {
        // Propriedades
        public DbSet<Produto> Produtos { get; set; }

        // Métodos
        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
        {
            string hostname = "dpg-daoqgcek1f9s738c5ggg-a.oregon-postgres.render.com";
            string porta = "5432";
            string nome_do_banco_de_dados = "dbdevback";
            string nome_do_usuario = "dbdevback_user";
            string senha = "yr1mCRnEy4ep7pbhsH5KDRTe4EENsvD8";

            string string_de_conexao = $"" +
                $"Host={hostname};" +
                $"Port={porta};" +
                $"Database={nome_do_banco_de_dados};" +
                $"Username={nome_do_usuario};" +
                $"Password={senha};" +
                $"SSL Mode=Require;" +
                $"Trust Server Certificate=true;";

            opcoesDeConstrucao.UseNpgsql(string_de_conexao);
        }

        protected override void OnModelCreating(ModelBuilder modeloDeConstrucao)
        {
            modeloDeConstrucao.Entity<Produto>(entidade =>
            {
                entidade.HasKey(e => e.Id);
                entidade.Property(e => e.Nome);
                entidade.Property(e => e.Descricao);
                entidade.Property(e => e.Valor);
                entidade.Property(e => e.Estoque);
                
            });
        }
    }
}


