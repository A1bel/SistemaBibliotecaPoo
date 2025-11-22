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

        public void Adicionar(Emprestimo emprestimo)
        {
            emprestimo.Id = _proximoId++;
            _emprestimos.Add(emprestimo);
            Salvar();
        }

        public Emprestimo Buscar(int id)
        {
            return _emprestimos.Find(u => u.Id == id);
        }

        public List<Emprestimo> BuscarTodos()
        {
            return new List<Emprestimo>(_emprestimos);
        }

        public void Atualizar(Emprestimo emprestimoAtualizado)
        {
            var existente = Buscar(emprestimoAtualizado.Id);
            if (existente == null) return;

            int index = _emprestimos.IndexOf(existente);
            _emprestimos[index] = emprestimoAtualizado;
            Salvar();
        }

        public void Remover(int id)
        {
            Emprestimo emprestimo = Buscar(id);
            if (emprestimo != null)
            {
                _emprestimos.Remove(emprestimo);
                Salvar();
            }

        }
        private List<Emprestimo> Carregar()
        {
            if(!File.Exists(_caminhoArquivo))
                return new List<Emprestimo>();

            var json = File.ReadAllText(_caminhoArquivo);
            return JsonConvert.DeserializeObject<List<Emprestimo>>(json, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All }) ?? new List<Emprestimo>();
        }

        private void Salvar()
        {
            var json = JsonConvert.SerializeObject(_emprestimos, Formatting.Indented, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All });
            File.WriteAllText(_caminhoArquivo, json);
        }
    }
}
