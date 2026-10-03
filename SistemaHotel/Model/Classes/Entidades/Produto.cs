

namespace SistemaHotel.Model.Classes.Entidades
{
    internal class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public int Estoque { get; set; }

        //Constructor
        public Produto(string nome, string descricao, decimal valor, int estoque)
        {
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
            Estoque = estoque;
        }
        protected Produto(string Nome)
        {
                this.Nome = Nome;
        }
    }
}
