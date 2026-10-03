

namespace SistemaHotel.Model.Classes.Entidades
{
    internal class Fornecedores
    {
        // Propriedades
        public int Nome { get; set; }
        public int Endereco { get; set; }
        public int Telefone { get; set; }

        // Construtor
        public Fornecedores(int nome, int endereco, int telefone)
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
        }

        
    }
}
