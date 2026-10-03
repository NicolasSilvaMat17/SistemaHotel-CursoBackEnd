using System;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Model.Classes.Entidades;

namespace Model.Classes.Contextos
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Lê connection string do App.config
                var cs = ConfigurationManager.ConnectionStrings["DefaultConnection"]?.ConnectionString;
                if (string.IsNullOrWhiteSpace(cs))
                {
                    throw new InvalidOperationException("Connection string 'DefaultConnection' não encontrada em App.config.");
                }
                optionsBuilder.UseSqlServer(cs);
            }
        }
    }
}
