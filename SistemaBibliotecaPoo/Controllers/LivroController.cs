using SistemaBibliotecaPoo.Models;
using SistemaBibliotecaPoo.Models.Usuario;
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

        public ResultadoOperacao CadastrarLivro(LivroDto livroDto)
        {
            ResultadoOperacao result = ValidarLivro(livroDto);
            if(!result.Success)
                return result;

            Livro livro = new Livro
            {
                Titulo = livroDto.Titulo,
                Autor = livroDto.Autor,
                Categoria = livroDto.Categoria,
                Preco = Convert.ToDouble(livroDto.Preco),
                Quantidade = Convert.ToInt32(livroDto.Quantidade)
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

        public Livro BuscarLivro(int id)
        {
            return _livroRepositorio.Buscar(id);
        }

        public List<Livro> BuscarTodosLivros()
        {
            return _livroRepositorio.BuscarTodos();
        }

        public ResultadoOperacao AtualizarLivro(LivroDto livroDto)
        {
            ResultadoOperacao result = new ResultadoOperacao();

            Livro existente = _livroRepositorio.Buscar(livroDto.Id);
            if (existente == null)
            {
                result.Erros.Add("geral", "Livro não encontrado");
                result.Success = false;
                return result;
            }

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

        public ResultadoOperacao RemoverLivro(int id)
        {
            ResultadoOperacao result = new ResultadoOperacao { Success = true };
            try
            {
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

        private ResultadoOperacao ValidarLivro(LivroDto livro)
        {
            ResultadoOperacao result = new ResultadoOperacao { Success = true };

            if (string.IsNullOrWhiteSpace(livro.Titulo))
            {
                result.Erros.Add("titulo", "Título não informado");
                result.Success = false;
            }

            if (string.IsNullOrWhiteSpace(livro.Autor))
            {
                result.Erros.Add("autor", "Autor não informado");
                result.Success = false;
            }

            if (string.IsNullOrWhiteSpace(livro.Categoria))
            {
                result.Erros.Add("categoria", "Categoria não informada");
                result.Success = false;
            }

            if(!int.TryParse(livro.Quantidade, out int quantidade))
            {
                result.Erros.Add("quantidade", "Quantidade deve ser um número válido");
                result.Success = false;
            }else if(quantidade < 0)
            {
                result.Erros.Add("quantidade", "Quantidade não pode ser menor que zero");
                result.Success = false;
            }

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
