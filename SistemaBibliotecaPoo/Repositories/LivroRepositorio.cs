using Newtonsoft.Json;
using SistemaBibliotecaPoo.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBibliotecaPoo.Repositories
{
    // Repositório responsável por armazenar, acessar e gerenciar os Livros.
    // É um Singleton, garantindo apenas uma instância centralizada em todo o sistema.
    public class LivroRepositorio
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

        // Adiciona um novo livro, atribui um ID sequencial e salva no arquivo.
        public void Adicionar(Livro livro)
        {
            livro.Id = _proximoId++;
            _livros.Add(livro);
            Salvar();
        }

        // Busca um livro pelo ID.
        // Retorna null caso não encontre.
        public Livro Buscar(int id)
        {
            return _livros.Find(l => l.Id == id);
        }

        // Retorna uma nova lista com todos os livros cadastrados.
        // (Evita que a lista original seja alterada por fora)
        public List<Livro> BuscarTodos()
        {
            return new List<Livro>(_livros);
        }

        // Retorna uma nova lista com todos os livros disponíveis.
        public List<Livro> BuscarDisponiveis()
        {
            return new List<Livro>(_livros)
                .Where(l => l.Disponivel && l.Quantidade > 0)
                .ToList();
        }

        // Atualiza as informações de um livro já existente.
        // Lança erro caso não seja encontrado.
        public void Atualizar(Livro livroAtualizado)
        {
            var existente = Buscar(livroAtualizado.Id);
            if (existente == null) return;

            int index = _livros.IndexOf(existente);
            _livros[index] = livroAtualizado;
            Salvar();
        }

        // Remove livro pelo ID.
        // Caso não exista, lança exceção
        public void Remover(int id)
        {
            Livro livro = Buscar(id);
            if (livro == null) throw new ArgumentException("Livro não encontrado");

            _livros.Remove(livro);
            Salvar();
            

        }

        // Carrega o arquivo JSON contendo livros salvos.
        // Se não existir, retorna uma lista vazia.
        private List<Livro> Carregar()
        {
            if(!File.Exists(_caminhoArquivo))
                return new List<Livro>();

            var json = File.ReadAllText(_caminhoArquivo);
            return JsonConvert.DeserializeObject<List<Livro>>(json, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All }) ?? new List<Livro>();
        }

        // Salva todos os livros no arquivo JSON
        private void Salvar()
        {
            var json = JsonConvert.SerializeObject(_livros, Formatting.Indented, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All });
            File.WriteAllText(_caminhoArquivo, json);
        }
    }
}
