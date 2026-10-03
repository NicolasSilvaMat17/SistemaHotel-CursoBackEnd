
namespace SistemaHotel.Model.Classes.Entidades
{
    internal class Estoque
    {
        public int Id { get; set; }
        public string Produto { get; set; }
        public string Fornecedor { get; set; }
        public char EstoqueFinal { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }

        //Constructor
        public Estoque(string produto, string fornecedor, char estoque, int quantidade, decimal valor)
        {
            Produto = produto;
            Fornecedor = fornecedor;
            EstoqueFinal = estoque;
            Quantidade = quantidade;
            Valor = valor;
        }
        protected Estoque(string Produto)
        {
            this.Produto = Produto;
        }
    }
}
