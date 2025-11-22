using SistemaBibliotecaPoo.Models;
using SistemaBibliotecaPoo.Models.Usuarios;
using SistemaBibliotecaPoo.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBibliotecaPoo.Controllers
{
    public class EmprestimoController
    {
        private readonly EmprestimoRepositorio _emprestimoRepositorio;
        private readonly LivroRepositorio _livroRepositorio;
        private readonly Usuario _usuarioLogado;

        public EmprestimoController(Usuario usuarioLogado)
        {
            _usuarioLogado = usuarioLogado;
            _emprestimoRepositorio = EmprestimoRepositorio.Instancia;
            _livroRepositorio = LivroRepositorio.Instancia;
        }

        public ResultadoOperacao RealizarEmprestimo(int livroId)
        {
            ResultadoOperacao result = new ResultadoOperacao { Success = true };
            try
            {

                Livro livro = _livroRepositorio.Buscar(livroId);
                if (livro == null)
                {
                    result.Erros.Add("geral", "Livro não encontrado, tente novamente mais tarde");
                    result.Success = false;
                    return result;
                }

                if (!livro.Disponivel)
                {
                    result.Erros.Add("geral", "Este livro não está disponível no momento.");
                    result.Success = false;
                    return result;
                }

                if (livro.Quantidade <= 0)
                {
                    result.Erros.Add("geral", "Este livro não está disponível no momento.");
                    result.Success = false;
                    return result;
                }

                Emprestimo emprestimoAtivo = _emprestimoRepositorio.BuscarEmprestimoAtivo(_usuarioLogado.Id, livroId);
                if (emprestimoAtivo != null)
                {
                    result.Erros.Add("geral", "Você já alugou este livro e ainda não devolveu.");
                    result.Success = false;
                    return result;
                }

                Emprestimo emp = new Emprestimo
                {
                    LivroId = livroId,
                    UsuarioId = _usuarioLogado.Id,
                    DataEmprestimo = DateTime.Now
                };

                _emprestimoRepositorio.Adicionar(emp);
                livro.Quantidade--;
                livro.Disponivel = livro.Quantidade > 0;
                _livroRepositorio.Atualizar(livro);
            }
            catch (Exception ex)
            {
                result.Erros.Add("geral", "Ocorreu um erro inesperado ao realizar o emprestimo.");
                result.Success = false;
            }


            return result;
        }

        public ResultadoOperacao DevolverLivro(int idLivro)
        {
                ResultadoOperacao result = new ResultadoOperacao { Success = true };
            try
            {
                Emprestimo emprestimo = _emprestimoRepositorio.BuscarEmprestimoAtivo(_usuarioLogado.Id, idLivro);

                if (emprestimo == null)
                {
                    result.Erros.Add("geral", "Este livro não está emprestado.");
                    result.Success = false;
                    return result;
                }

                emprestimo.DataDevolucao = DateTime.Now;
                _emprestimoRepositorio.Atualizar(emprestimo);

                Livro livro = _livroRepositorio.Buscar(idLivro);
                livro.Disponivel = true;
                livro.Quantidade++;
                _livroRepositorio.Atualizar(livro);
            }
            catch(Exception ex)
            {
                result.Erros.Add("geral", "Ocorreu um erro inesperado ao devolver livro.");
                result.Success = false;
            }
            

            return result;
        }

        public List<object> ObterEmprestimosDoUsuario()
        {
            List<Emprestimo> emprestimos = _emprestimoRepositorio
                .ObterEmprestimosAbertosPorUsuario(_usuarioLogado.Id);

            var lista = new List<object>();

            foreach (var e in emprestimos)
            {
                var livro = _livroRepositorio.Buscar(e.LivroId);

                lista.Add(new
                {
                    e.Id,
                    Titulo = livro.Titulo,
                    Autor = livro.Autor,
                    DataEmprestimo = e.DataEmprestimo.ToString("dd/MM/yyyy")
                });
            }

            return lista;
        }
    }
}
