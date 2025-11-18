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
    public class UsuarioController
    {
        private readonly UsuarioRepositorio _usuarioRepositorio = UsuarioRepositorio.Instancia;
        
        public ResultadoOperacao CadastrarUsuario(UsuarioDto usuarioDto)
        {
            ResultadoOperacao result = ValidarUsuario(usuarioDto);
            if (!result.Success)
                return result;

            try
            {
                Usuario usuario = PerfilFactory.CriarUsuario(usuarioDto.Tipo, usuarioDto.Nome, usuarioDto.Telefone, usuarioDto.Email, usuarioDto.Senha);
                _usuarioRepositorio.Adicionar(usuario);
            }
            catch(Exception ex)
            {
                result.Erros.Add("geral", "Ocorreu um erro ao cadastrar usuário");
                result.Success = false;
            }
                return result;
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

        public ResultadoOperacao AtualizarUsuario(UsuarioDto usuarioDto)
        {
            ResultadoOperacao result = new ResultadoOperacao();

            Usuario existente = _usuarioRepositorio.Buscar(usuarioDto.Id);
            if (existente == null)
            {
                result.Erros.Add("geral", "Usuário não encontrado");
                result.Success = false;
                return result;
            }

            result = ValidarUsuario(usuarioDto, true);
            if (!result.Success)
                return result;

            existente.Nome = usuarioDto.Nome;
            existente.Email = usuarioDto.Email;
            existente.Telefone = usuarioDto.Telefone;

            if (!string.IsNullOrWhiteSpace(usuarioDto.Senha))
            {
                existente.Senha = usuarioDto.Senha;
            }

            try
            {
                _usuarioRepositorio.Atualizar(existente);
            }catch (Exception ex)
            {
                result.Erros.Add("geral", "Ocorreu um erro ao atualizar usuário");
                result.Success = false;
            }
                return result;
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

        private ResultadoOperacao ValidarUsuario(UsuarioDto usuarioDto, bool isUpdate = false)
        {
            ResultadoOperacao result = new ResultadoOperacao { Success = true };

            if (string.IsNullOrWhiteSpace(usuarioDto.Nome))
            {
                result.Erros.Add("nome", "Nome não informado");
                result.Success = false;
            }

            if (string.IsNullOrWhiteSpace(usuarioDto.Email))
            {
                result.Erros.Add("email", "Email não informado");
                result.Success = false;
            }
            else
            {
                Usuario existe = _usuarioRepositorio.BuscarPorEmail(usuarioDto.Email);
                if(!isUpdate && existe != null)
                {
                    result.Erros.Add("email", "Já existe um usuário com este email");
                    result.Success = false;
                }
                else if (isUpdate && existe != null && existe.Id != usuarioDto.Id)
                {
                    result.Erros.Add("email", "Já existe um usuário com este email.");
                    result.Success = false;
                }
            }

            if (string.IsNullOrWhiteSpace(usuarioDto.Telefone))
            {
                result.Erros.Add("telefone", "Telefone não informado");
                result.Success = false;
            }

            bool alterandoSenha = !string.IsNullOrWhiteSpace(usuarioDto.Senha) || !string.IsNullOrWhiteSpace(usuarioDto.ConfirmarSenha);
            if (!isUpdate || alterandoSenha)
            {

                if (string.IsNullOrWhiteSpace(usuarioDto.Senha))
                {
                    result.Erros.Add("senha", "Nova senha não informada");
                    result.Success = false;
                }
                else if (usuarioDto.Senha.Length < 8)
                {
                    result.Erros.Add("senha", "Senha deve conter no mínimo 8 caracteres");
                    result.Success = false;
                }

                if (string.IsNullOrWhiteSpace(usuarioDto.ConfirmarSenha))
                {
                    result.Erros.Add("CSenha", "Confirmação de senha não informada");
                    result.Success = false;
                }
                else if (usuarioDto.ConfirmarSenha.Length < 8)
                {
                    result.Erros.Add("CSenha", "Senha deve conter no mínimo 8 caracteres");
                    result.Success = false;
                }

                if (!(string.IsNullOrWhiteSpace(usuarioDto.Senha) || string.IsNullOrWhiteSpace(usuarioDto.ConfirmarSenha))
                    && (usuarioDto.Senha.Length >= 8 && usuarioDto.ConfirmarSenha.Length >= 8) && usuarioDto.Senha != usuarioDto.ConfirmarSenha)
                {
                    result.Erros.Add("senha", "As senhas não coincidem.");
                    result.Success = false;
                }

                if (isUpdate && alterandoSenha && string.IsNullOrWhiteSpace(usuarioDto.SenhaAtual))
                {
                    result.Erros.Add("senhaAtual", "Senha atual não informada.");
                    result.Success = false;
                }else if (isUpdate && alterandoSenha)
                {
                    Usuario existe = _usuarioRepositorio.Buscar(usuarioDto.Id);
                    if(existe.Senha != usuarioDto.SenhaAtual)
                    {
                        result.Erros.Add("senhaAtual", "Senha atual incorreta.");
                        result.Success = false;
                    }
                }
            }


            return result;
        }
        
    }
}
