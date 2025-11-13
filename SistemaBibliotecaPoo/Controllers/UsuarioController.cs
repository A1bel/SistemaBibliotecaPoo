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
        
        public ResultadoValidacao CadastrarUsuario(string tipo, string nome, string telefone, string email, string senha)
        {
            ResultadoValidacao result = ValidarUsuario(nome, email, telefone, senha);
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

        public Usuario BuscarUsuario(int id)
        {
            return _usuarioRepositorio.Buscar(id);
        }

        public List<Usuario> BuscarTodosUsuarios()
        {
            return _usuarioRepositorio.BuscarTodos();
        }

        public ResultadoValidacao AtualizarUsuario(Usuario usuario)
        {
            ResultadoValidacao result = ValidarUsuario(usuario.Nome, usuario.Telefone, usuario.Email, usuario.Senha);
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

        public void RemoverUsuari(int id)
        {
            try
            {

            }catch(Exception ex)
            {

            }
        }

        private ResultadoValidacao ValidarUsuario(string nome, string telefone, string email, string senha)
        {
            ResultadoValidacao result = new ResultadoValidacao { Success = true };

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
