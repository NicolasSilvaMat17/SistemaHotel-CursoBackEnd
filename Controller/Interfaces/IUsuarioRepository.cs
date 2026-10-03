using System.Collections.Generic;
using Model.Classes.Entidades;

namespace Controller.Interfaces
{
    public interface IUsuarioRepository
    {
        List<Usuario> GetAll();
        Usuario GetById(int id);
        void Add(Usuario usuario);
        void Update(Usuario usuario);
        void Delete(int id);
        bool ExistsByUsuarioNome(string usuarioNome);
    }
}
