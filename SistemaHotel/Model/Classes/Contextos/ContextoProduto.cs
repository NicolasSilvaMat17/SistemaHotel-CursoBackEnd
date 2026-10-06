using Microsoft.EntityFrameworkCore;
using SistemaHotel.Model.Classes.Entidades;
using System;

namespace SistemaHotel.Model.Classes.Contextos
{
    internal class ProdutoContext : DbContext
    {
        // Propriedades
        public DbSet<Produto> Produtos { get; set; }

        // Métodos
        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
        {
            string string_de_conexao = Environment.GetEnvironmentVariable("db2");
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


