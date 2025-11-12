using Newtonsoft.Json;
using SistemaBibliotecaPoo.Models.Usuario;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBibliotecaPoo.Repositories
{
    public  class LivroRepositorio
    {
        private static LivroRepositorio _instancia;
        private List<Livro> _livros;
        private readonly string _caminhoArquivo = "livros.json";
        private int _proximoId = 1;

        private LivroRepositorio()
        {
            _livros = Carregar();
            _proximoId = _livros.Count == 0 ? 1 : _livros.Max(u => u.Id) + 1;
        }

        public static LivroRepositorio Instancia
        {
            get
            {
                if( _instancia == null )
                    _instancia = new LivroRepositorio();

                return _instancia;
            }
        }

        public void Adicionar(Livro livro)
        {
            livro.Id = _proximoId++;
            _livros.Add(livro);
            Salvar();
        }

        public Livro Buscar(int id)
        {
            return _livros.Find(u => u.Id == id);
        }

        public List<Livro> BuscarTodos()
        {
            return new List<Livro>(_livros);
        }

        public void Atualizar(Livro livroAtualizado)
        {
            var existente = Buscar(livroAtualizado.Id);
            if (existente == null) return;

            int index = _livros.IndexOf(existente);
            _livros[index] = livroAtualizado;
            Salvar();
        }

        public void Remover(int id)
        {
            Livro livro = Buscar(id);
            if (livro != null)
            {
                _livros.Remove(livro);
                Salvar();
            }

        }
        private List<Livro> Carregar()
        {
            if(!File.Exists(_caminhoArquivo))
                return new List<Livro>();

            var json = File.ReadAllText(_caminhoArquivo);
            return JsonConvert.DeserializeObject<List<Livro>>(json, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All }) ?? new List<Livro>();
        }

        private void Salvar()
        {
            var json = JsonConvert.SerializeObject(_livros, Formatting.Indented, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All });
            File.WriteAllText(_caminhoArquivo, json);
        }
    }
}
