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
    class UsuarioController
    {
        private readonly UsuarioRepositorio _usuarioRepositorio = UsuarioRepositorio.Instancia;
        
        public ResultadoOperacao CadastrarUsuario(string tipo, string nome, string telefone, string email, string senha)
        {
            ResultadoOperacao result = ValidarUsuario(nome, email, telefone, senha);
            if (!result.Success)
                return result;

            try
            {
                Usuario usuario = PerfilFactory.CriarUsuario(tipo, nome, telefone, email, senha);
                _usuarioRepositorio.Adicionar(usuario);
                return result;
            }
            catch(Exception ex)
            {
                result.Erros.Add("geral", "Ocorreu um erro ao cadastrar usuário");
                result.Success = false;
                return result;
            }
        }

        public ResultadoOperacao Login(string email, string senha)
        {
            ResultadoOperacao result = new ResultadoOperacao { Success = true };    

            if(string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
            {
                result.Erros.Add("geral", "Preencha todos os campos");
                result.Success = false;
                return result;
            }

            try
            {
                Usuario usuario = _usuarioRepositorio.BuscarPorEmail(email);
                if(usuario == null || usuario.Senha != senha)
                {
                    result.Erros.Add("geral", "Email e/ou senha inválidos");
                    result.Success = false;
                    return result;
                }
            }
            catch (Exception ex)
            {
                result.Erros.Add("geral", "Ocorreu um erro inesperado ao efetuar login");
                result.Success = false;
            }
            return result;
        }

        public Usuario BuscarUsuario(int id)
        {
            return _usuarioRepositorio.Buscar(id);
        }

        public List<Usuario> BuscarTodosUsuarios()
        {
            return _usuarioRepositorio.BuscarTodos();
        }

        public ResultadoOperacao AtualizarUsuario(Usuario usuario)
        {
            ResultadoOperacao result = ValidarUsuario(usuario.Nome, usuario.Telefone, usuario.Email, usuario.Senha);
            if (!result.Success)
                return result;

            try
            {
                _usuarioRepositorio.Atualizar(usuario);
                return result;
            }catch (Exception ex)
            {
                result.Erros.Add("geral", "Ocorreu um erro ao atualizar usuário");
                result.Success = false;
                return result;
            }
        }

        public ResultadoOperacao RemoverUsuario(int id)
        {
            ResultadoOperacao result = new ResultadoOperacao { Success = true };
            try
            {
                _usuarioRepositorio.Remover(id);
                return result;

            }catch(ArgumentException ex)
            {
                result.Erros.Add("geral", ex.Message);
                result.Success = false;

            }catch(Exception ex)
            {
                result.Erros.Add("geral", "Ocorreu um erro inesperado ao remover usuário");
                result.Success = false; 
            }
            return result;
        }

        private ResultadoOperacao ValidarUsuario(string nome, string telefone, string email, string senha)
        {
            ResultadoOperacao result = new ResultadoOperacao { Success = true };

            if (string.IsNullOrWhiteSpace(nome))
            {
                result.Erros.Add("nome", "Nome não informado");
                result.Success = false;
            }

            if (string.IsNullOrEmpty(email))
            {
                result.Erros.Add("email", "Email nâo informado");
                result.Success = false;
            }

            if (string.IsNullOrEmpty(telefone))
            {
                result.Erros.Add("telefone", "Telefone nâo informado");
                result.Success = false;
            }

            if (string.IsNullOrEmpty(senha))
            {
                result.Erros.Add("senha", "Senha nâo informado");
                result.Success = false;
            }

            return result;
        }
        
    }
}
