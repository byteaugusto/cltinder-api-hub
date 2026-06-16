using CltinderApi.Models;

namespace CltinderApi.Services
{
    public class UsuarioService
    {
        private List<Usuario> usuarios = new List<Usuario>();
        private int id = 1;

        public List<Usuario> GetAll() => usuarios;

        public Usuario GetById(int id)
            => usuarios.FirstOrDefault(u => u.Id == id);

        public Usuario Add(Usuario usuario)
        {
            usuario.Id = id++;
            usuarios.Add(usuario);
            return usuario;
        }

        public bool Update(int id, Usuario usuarioAtualizado)
        {
            var usuario = GetById(id);
            if (usuario == null) return false;

            usuario.Nome = usuarioAtualizado.Nome;
            usuario.Email = usuarioAtualizado.Email;
            usuario.Cidade = usuarioAtualizado.Cidade;

            return true;
        }

        public bool Delete(int id)
        {
            var usuario = GetById(id);
            if (usuario == null) return false;

            usuarios.Remove(usuario);
            return true;
        }
    }
}