using System;
using System.Collections.Generic;
using System.Linq;
using Model.Classes.Contextos;
using Model.Classes.Entidades;
using Controller.Interfaces;

namespace Controller.Services
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly AppDbContext _context;

        public UsuarioRepository(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public List<Usuario> GetAll()
        {
            return _context.Usuarios.OrderBy(u => u.Id).ToList();
        }

        public Usuario GetById(int id)
        {
            return _context.Usuarios.Find(id);
        }

        public void Add(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public void Update(Usuario usuario)
        {
            _context.Usuarios.Update(usuario);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var u = _context.Usuarios.Find(id);
            if (u != null)
            {
                _context.Usuarios.Remove(u);
                _context.SaveChanges();
            }
        }

        public bool ExistsByUsuarioNome(string usuarioNome)
        {
            return _context.Usuarios.Any(u => u.UsuarioNome == usuarioNome);
        }
    }
}
