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
    // Repositório responsável por armazenar, acessar e gerenciar os Emprestimos.
    // É um Singleton, garantindo apenas uma instância centralizada em todo o sistema.
    public class EmprestimoRepositorio
    {
        private static EmprestimoRepositorio _instancia;
        private List<Emprestimo> _emprestimos;
        private readonly string _caminhoArquivo = "emprestimos.json";
        private int _proximoId = 1;

        private EmprestimoRepositorio()
        {
            _emprestimos = Carregar();
            _proximoId = _emprestimos.Count == 0 ? 1 : _emprestimos.Max(u => u.Id) + 1;
        }

        public static EmprestimoRepositorio Instancia
        {
            get
            {
                if( _instancia == null )
                    _instancia = new EmprestimoRepositorio();

                return _instancia;
            }
        }

        // Adiciona um novo emprestimo, atribui um ID sequencial e salva no arquivo.
        public void Adicionar(Emprestimo emprestimo)
        {
            emprestimo.Id = _proximoId++;
            _emprestimos.Add(emprestimo);
            Salvar();
        }

        // Busca um emprestimo pelo ID.
        // Retorna null caso não encontre.
        public Emprestimo Buscar(int id)
        {
            return _emprestimos.Find(u => u.Id == id);
        }

        // Busca um emprestimo pelo ID de um livro.
        // Retorna null caso não encontre.
        public Emprestimo BuscarPorLivro(int livroId)
        {
            return _emprestimos.Find(u => u.LivroId == livroId);
        }

        // Retorna um emprestimo ativo de determinado usuário e de determinado livro,
        // usado para verificar se o usuário já pegou determinado livro emprestado.
        public Emprestimo BuscarEmprestimoAtivo(int usuarioId, int livroId)
        {
            return _emprestimos
                .FirstOrDefault(e =>
                    e.UsuarioId == usuarioId &&
                    e.LivroId == livroId &&
                    e.DataDevolucao == null
                );
        }

        // Retorna uma nova lista com todos os emprestimos cadastrados.
        // (Evita que a lista original seja alterada por fora)
        public List<Emprestimo> BuscarTodos()
        {
            return new List<Emprestimo>(_emprestimos);
        }

        // Retorna uma nova lista com todos os emprestimos ativos de um determinado usuário.
        public List<Emprestimo> ObterEmprestimosAbertosPorUsuario(int usuarioId)
        {
            return BuscarTodos()
                .Where(e => e.UsuarioId == usuarioId && e.DataDevolucao == null)
                .ToList();
        }

        // Retorna uma nova lista com todos os emprestimos ativos de um determinado livro.
        public List<Emprestimo> ObterEmprestimosAbertosPorLivro(int livroId)
        {
            return BuscarTodos()
                .Where(e => e.LivroId == livroId && e.DataDevolucao == null)
                .ToList();
        }

        // Atualiza as informações de um emprestimo já existente.
        // Lança erro caso não seja encontrado.
        public void Atualizar(Emprestimo emprestimoAtualizado)
        {
            var existente = Buscar(emprestimoAtualizado.Id);
            if (existente == null) return;

            int index = _emprestimos.IndexOf(existente);
            _emprestimos[index] = emprestimoAtualizado;
            Salvar();
        }

        // Remove emprestimo pelo ID.
        // Caso não exista, lança exceção
        public void Remover(int id)
        {
            Emprestimo emprestimo = Buscar(id);
            if (emprestimo != null)
            {
                _emprestimos.Remove(emprestimo);
                Salvar();
            }

        }

        // Carrega o arquivo JSON contendo emprestimos salvos.
        // Se não existir, retorna uma lista vazia.
        private List<Emprestimo> Carregar()
        {
            if(!File.Exists(_caminhoArquivo))
                return new List<Emprestimo>();

            var json = File.ReadAllText(_caminhoArquivo);
            return JsonConvert.DeserializeObject<List<Emprestimo>>(json, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All }) ?? new List<Emprestimo>();
        }

        // Salva todos os emprestimos no arquivo JSON
        private void Salvar()
        {
            var json = JsonConvert.SerializeObject(_emprestimos, Formatting.Indented, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All });
            File.WriteAllText(_caminhoArquivo, json);
        }
    }
}
