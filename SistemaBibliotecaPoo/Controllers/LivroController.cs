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
    public class LivroController
    {
        private readonly LivroRepositorio _livroRepositorio = LivroRepositorio.Instancia;
        private readonly EmprestimoRepositorio _emprestimoRepositorio = EmprestimoRepositorio.Instancia;

        // Realiza o cadastro de um novo livro recebendo os dados via DTO.
        public ResultadoOperacao CadastrarLivro(LivroDto livroDto)
        {
            //Chama o metodo para validar e se falhar retorna os erros sem cadastrar.
            ResultadoOperacao result = ValidarLivro(livroDto);
            if(!result.Success)
                return result;

            Livro livro = new Livro
            {
                Titulo = livroDto.Titulo,
                Autor = livroDto.Autor,
                Categoria = livroDto.Categoria,
                Preco = Convert.ToDouble(livroDto.Preco),
                Quantidade = Convert.ToInt32(livroDto.Quantidade),
                Disponivel = true
            };

            try
            {
                _livroRepositorio.Adicionar(livro);
            }
            catch(Exception ex)
            {
                result.Erros.Add("geral", "Ocorreu um erro ao cadastrar o livro");
                result.Success = false;
            }
                return result;
        }

        // Busca um livro pelo ID.
        public Livro BuscarLivro(int id)
        {
            return _livroRepositorio.Buscar(id);
        }

        // Retorna todos os livros cadastrados.
        public List<Livro> BuscarTodosLivros()
        {
            return _livroRepositorio.BuscarTodos();
        }

        // Retorna todos os livros disponíveis.
        public List<Livro> BuscarDisponiveis()
        {
            return _livroRepositorio.BuscarDisponiveis();
        }

        // Atualiza os dados de um livro existente.
        public ResultadoOperacao AtualizarLivro(LivroDto livroDto)
        {
            ResultadoOperacao result = new ResultadoOperacao();

            // Verifica se o livro com o ID informado existe
            Livro existente = _livroRepositorio.Buscar(livroDto.Id);
            if (existente == null)
            {
                result.Erros.Add("geral", "Livro não encontrado");
                result.Success = false;
                return result;
            }

            // Valida
            result = ValidarLivro(livroDto);
            if (!result.Success)
                return result;


            try
            {
                existente.Titulo = livroDto.Titulo;
                existente.Autor = livroDto.Autor;
                existente.Categoria = livroDto.Categoria;
                existente.Preco = Convert.ToDouble(livroDto.Preco);
                existente.Quantidade = Convert.ToInt32(livroDto.Quantidade);
                existente.Disponivel = livroDto.Disponivel;

                _livroRepositorio.Atualizar(existente);

            }
            catch (Exception ex)
            {
                result.Erros.Add("geral", "Ocorreu um erro ao atualizar o livro");
                result.Success = false;
            }
            return result;
        }

        // Remove um livro pelo ID.
        public ResultadoOperacao RemoverLivro(int id)
        {
            ResultadoOperacao result = new ResultadoOperacao { Success = true };
            try
            {
                List<Emprestimo> emprestimosAbertos = _emprestimoRepositorio.ObterEmprestimosAbertosPorLivro(id);
                if(emprestimosAbertos.Any())
                {
                    result.Erros.Add("geral", "Não é possível deletar este livro, pois ele está emprestado.");
                    result.Success = false;
                    return result;
                }

                _livroRepositorio.Remover(id);
            }
            catch(ArgumentException ex)
            {
                result.Erros.Add("geral", ex.Message);
                result.Success = false;
            }
            catch (Exception ex)
            {
                result.Erros.Add("geral", "Ocorreu um erro inesperado ao remover o livro");
                result.Success = false;
            }
            return result;
        }

        // Valida dados do livro tanto em cadastro quanto edição.
        private ResultadoOperacao ValidarLivro(LivroDto livro)
        {
            ResultadoOperacao result = new ResultadoOperacao { Success = true };

            //Valida título
            if (string.IsNullOrWhiteSpace(livro.Titulo))
            {
                result.Erros.Add("titulo", "Título não informado");
                result.Success = false;
            }

            //Valida autor.
            if (string.IsNullOrWhiteSpace(livro.Autor))
            {
                result.Erros.Add("autor", "Autor não informado");
                result.Success = false;
            }

            //Valida categoria.
            if (string.IsNullOrWhiteSpace(livro.Categoria))
            {
                result.Erros.Add("categoria", "Categoria não informada");
                result.Success = false;
            }

            //Valida quantidade.
            if(!int.TryParse(livro.Quantidade, out int quantidade))
            {
                result.Erros.Add("quantidade", "Quantidade deve ser um número válido");
                result.Success = false;
            }else if(quantidade < 0)
            {
                result.Erros.Add("quantidade", "Quantidade não pode ser menor que zero");
                result.Success = false;
            }

            //Valida preço.
            if(!double.TryParse(livro.Preco, out double preco))
            {
                result.Erros.Add("preco", "Preço deve ser um valor válido");
                result.Success = false;
            }else if(preco <= 0)
            {
                result.Erros.Add("preco", "Preço deve ser maior que zero");
                result.Success = false;
            }


            return result;
        }
    }
}
