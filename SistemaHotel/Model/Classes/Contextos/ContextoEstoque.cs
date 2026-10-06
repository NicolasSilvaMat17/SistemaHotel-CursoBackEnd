using Microsoft.EntityFrameworkCore;
using SistemaHotel.Model.Classes.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaHotel.Model.Classes.Contextos
{
    internal class ContextoEstoque : DbContext
    {
        // Propriedades
        public DbSet<Estoque> Estoque { get; set; }

        // Métodos
        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
        {
            string string_de_conexao = Environment.GetEnvironmentVariable("db2");
            opcoesDeConstrucao.UseNpgsql(string_de_conexao);
        }

        protected override void OnModelCreating(ModelBuilder modeloDeConstrucao)
        {
            modeloDeConstrucao.Entity<Estoque>(entidade =>  
            {
                entidade.HasKey(e => e.Id);
                entidade.Property(e => e.Produto);
                entidade.Property(e => e.Fornecedor); 
                entidade.Property(e => e.EstoqueFinal); 
                entidade.Property(e => e.Quantidade); 
                entidade.Property(e => e.Valor); 
                
            });
        }
    }
}
