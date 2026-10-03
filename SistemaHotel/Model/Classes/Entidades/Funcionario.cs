using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaHotel.Model.Classes.Entidades
{
    internal class Funcionario
    {
        // Propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public long CPF { get; set; }
        public int Endereco { get; set; }

        // Construtor
        public Funcionario(string nome, string telefone, long cPF, int endereco)
        {
            Nome = nome;
            Telefone = telefone;
            CPF = cPF;
            Endereco = endereco;
        }

        // Método para exibir informações do funcionário
        public override string ToString()
        {
            return $"Nome: {Nome}, Telefone: {Telefone}, CPF: {CPF}, Endereço: {Endereco}";
        }

    }
}
