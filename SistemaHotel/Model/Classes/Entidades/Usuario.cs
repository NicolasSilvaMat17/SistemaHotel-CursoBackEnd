using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaHotel.Model.Classes.Entidades
{
    internal class Usuario
    {
        // Propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public string UsuarioE { get; set; }
        public string Cargo { get; set; }
        public string Senha { get; set; }

        // Construtor
        public Usuario(string nome, string usuarioE, string cargo, string senha)
        {
            Nome = nome;
            UsuarioE = usuarioE;
            Cargo = cargo;
            Senha = senha;
        }

        
        
    }
}
