using SistemaBibliotecaPoo.Models.Usuario;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace SistemaBibliotecaPoo.Repositories
{
    public class UsuarioRepositorio
    {
        private static UsuarioRepositorio _instancia;
        private List<Usuario> _usuarios;
        private readonly string _caminhoArquivo = "usuarios.json";
        private int _proximoId = 1;

        private UsuarioRepositorio() { 
            _usuarios = Carregar();

            _proximoId = _usuarios.Count == 0 ? 1 : _usuarios.Max(u => u.Id) + 1;
        }

        public static UsuarioRepositorio Instancia
        {
            get
            {
                if( _instancia == null )
                    _instancia = new UsuarioRepositorio();

                return _instancia;
            }
        }

        public void Adicionar( Usuario usuario)
        {
            usuario.Id = _proximoId++;
            _usuarios.Add(usuario);
            Salvar();
        }

        public Usuario Buscar(int id)
        {
            return _usuarios.Find(u =>  u.Id == id);
        }

        public List<Usuario> BuscarTodos()
        {
            return new List<Usuario>(_usuarios);
        }

        public void Atualizar(Usuario usuarioAtualizado)
        {
            var existente = Buscar(usuarioAtualizado.Id);
            if (existente == null) return;

            int index = _usuarios.IndexOf(existente);
            _usuarios[index] = usuarioAtualizado;
            Salvar();
        }

        public void Remover(int id)
        {
            Usuario usuario = Buscar(id);
            if(usuario != null)
            {
                _usuarios.Remove(usuario);
                Salvar();
            }

        }

        private List<Usuario> Carregar()
        {
            if (!File.Exists(_caminhoArquivo))
                return new List<Usuario>();

            var json = File.ReadAllText(_caminhoArquivo);
            return JsonConvert.DeserializeObject<List<Usuario>>(json, new JsonSerializerSettings{TypeNameHandling = TypeNameHandling.All}) ?? new List<Usuario>();
        }

        private void Salvar()
        {
            var json = JsonConvert.SerializeObject(_usuarios, Formatting.Indented, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All });
            File.WriteAllText(_caminhoArquivo, json);
        }
    }
}
