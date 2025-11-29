using SistemaBibliotecaPoo.Models.Usuarios;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace SistemaBibliotecaPoo.Repositories
{
    // Repositório responsável por armazenar, acessar e gerenciar os usuários.
    // É um Singleton, garantindo apenas uma instância centralizada em todo o sistema.
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

        // Verifica se existe algum usuário com perfil administrador.
        // Usado para exigir a criação inicial de um Admin.
        public bool ExisteAdmin()
        {
            return _usuarios.Any(u => u is Admin);
        }

        // Adiciona um novo usuário, atribui um ID sequencial e salva no arquivo.
        public void Adicionar( Usuario usuario)
        {
            usuario.Id = _proximoId++;
            _usuarios.Add(usuario);
            Salvar();
        }

        // Busca um usuário pelo ID.
        // Retorna null caso não encontre.
        public Usuario Buscar(int id)
        {
            return _usuarios.Find(u =>  u.Id == id);
        }

        // Busca usuário pelo e-mail, ignorando diferença entre maiúsculas e minúsculas.
        public Usuario BuscarPorEmail(string email)
        {
            return _usuarios.FirstOrDefault(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
        }

        // Retorna uma nova lista com todos os usuários cadastrados.
        // (Evita que a lista original seja alterada por fora)
        public List<Usuario> BuscarTodos()
        {
            return new List<Usuario>(_usuarios);
        }

        // Atualiza as informações de um usuário já existente.
        // Lança erro caso não seja encontrado.
        public void Atualizar(Usuario usuarioAtualizado)
        {
            var existente = Buscar(usuarioAtualizado.Id);
            if (existente == null) throw new ArgumentException("Usuário não encontrado");

            int index = _usuarios.IndexOf(existente);
            _usuarios[index] = usuarioAtualizado;
            Salvar();
        }

        // Remove usuário pelo ID.
        // Caso não exista, lança exceção.
        public void Remover(int id)
        {
            Usuario usuario = Buscar(id);
            if (usuario == null) throw new ArgumentException("Usuário não encontrado");
                
            _usuarios.Remove(usuario);
            Salvar();
        }

        // Carrega o arquivo JSON contendo usuários salvos.
        // Se não existir, retorna uma lista vazia.
        private List<Usuario> Carregar()
        {
            if (!File.Exists(_caminhoArquivo))
                return new List<Usuario>();

            var json = File.ReadAllText(_caminhoArquivo);
            return JsonConvert.DeserializeObject<List<Usuario>>(json, new JsonSerializerSettings{TypeNameHandling = TypeNameHandling.All}) ?? new List<Usuario>();
        }

        // Salva todos os usuários no arquivo JSON, incluindo seus tipos concretos.
        private void Salvar()
        {
            var json = JsonConvert.SerializeObject(_usuarios, Formatting.Indented, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All });
            File.WriteAllText(_caminhoArquivo, json);
        }

    }
}
