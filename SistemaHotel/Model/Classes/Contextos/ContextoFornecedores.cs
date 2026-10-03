
using Microsoft.EntityFrameworkCore;

namespace SistemaHotel.Model.Classes.Contextos
{
    internal class ContextoFornecedores : DbContext
    {
        public DbSet<Fornecedores> Fornecedores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
        {
            opcoesDeConstrucao.UseSqlServer(@"Server=ECFP507D1319387\SQLEXPRESS01;Database=SistemaHotel;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
