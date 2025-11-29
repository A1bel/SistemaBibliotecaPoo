using SistemaBibliotecaPoo.Models;
using SistemaBibliotecaPoo.Models.Usuarios;
using SistemaBibliotecaPoo.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Net.Mail;

namespace SistemaBibliotecaPoo.Controllers
{
    public class UsuarioController
    {
        private readonly UsuarioRepositorio _usuarioRepositorio = UsuarioRepositorio.Instancia;

        // Realiza o cadastro de um novo usuário recebendo os dados via DTO.
        public ResultadoOperacao CadastrarUsuario(UsuarioDto usuarioDto)
        {
            //Chama o metodo para validar e se falhar retorna os erros sem cadastrar.
            ResultadoOperacao result = ValidarUsuario(usuarioDto);
            if (!result.Success)
                return result;

            try
            {
                // Criação do perfil dinamicamente conforme o tipo informado no DTO
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

        // Autentica um usuário no sistema comparando email e senha.
        public ResultadoOperacao Login(string email, string senha)
        {
            ResultadoOperacao result = new ResultadoOperacao { Success = true };    

            //Validação básica dos campos
            if(string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
            {
                result.Erros.Add("geral", "Preencha todos os campos");
                result.Success = false;
                return result;
            }

            try
            {
                //busca o usuario por email, verifica se ele já existe e verifica se as credenciais batem.
                Usuario usuario = _usuarioRepositorio.BuscarPorEmail(email);
                if(usuario == null || usuario.Senha != senha)
                {
                    result.Erros.Add("geral", "Email e/ou senha inválidos");
                    result.Success = false;
                    return result;
                }

                result.UsuarioLogado = usuario;
            }
            catch (Exception ex)
            {
                result.Erros.Add("geral", "Ocorreu um erro inesperado ao efetuar login");
                result.Success = false;
            }
            return result;
        }

        // Busca um usuário pelo ID
        public Usuario BuscarUsuario(int id)
        {
            return _usuarioRepositorio.Buscar(id);
        }

        // Retorna todos os usuários cadastrados
        public List<Usuario> BuscarTodosUsuarios()
        {
            return _usuarioRepositorio.BuscarTodos();
        }

        // Atualiza os dados de um usuário existente.
        public ResultadoOperacao AtualizarUsuario(UsuarioDto usuarioDto)
        {
            ResultadoOperacao result = new ResultadoOperacao();

            // Verifica se o usuário com o ID informado existe
            Usuario existente = _usuarioRepositorio.Buscar(usuarioDto.Id);
            if (existente == null)
            {
                result.Erros.Add("geral", "Usuário não encontrado");
                result.Success = false;
                return result;
            }

            // Valida com regras específicas de atualização
            result = ValidarUsuario(usuarioDto, true);
            if (!result.Success)
                return result;

            existente.Nome = usuarioDto.Nome;
            existente.Email = usuarioDto.Email;
            existente.Telefone = usuarioDto.Telefone;

            if (!string.IsNullOrWhiteSpace(usuarioDto.Senha))
                existente.Senha = usuarioDto.Senha;

            // Caso o tipo tenha mudado (Admin <-> Leitor) cria um novo objeto substituindo o antigo
            if (usuarioDto.Tipo != existente.GetType().Name) 
    {
                Usuario novoUsuario;
                if (usuarioDto.Tipo == "Admin")
                    novoUsuario = new Admin(existente.Nome, existente.Telefone, existente.Email, existente.Senha);
                else 
                    novoUsuario = new Leitor(existente.Nome, existente.Telefone, existente.Email, existente.Senha);

                novoUsuario.Id = existente.Id;
                existente = novoUsuario;
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

        // Remove um usuário pelo ID.
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

        // Valida dados do usuário tanto em cadastro quanto edição.
        private ResultadoOperacao ValidarUsuario(UsuarioDto usuarioDto, bool isUpdate = false)
        {
            ResultadoOperacao result = new ResultadoOperacao { Success = true };

            //Valida nome
            if (string.IsNullOrWhiteSpace(usuarioDto.Nome))
            {
                result.Erros.Add("nome", "Nome não informado");
                result.Success = false;
            }

            //Valida email e verifica se ele já existe para evitar duplicação
            if (string.IsNullOrWhiteSpace(usuarioDto.Email))
            {
                result.Erros.Add("email", "Email não informado");
                result.Success = false;
            }
            else if (!EmailValido(usuarioDto.Email))
            {
                result.Erros.Add("email", "Formato de e-mail inválido");
                result.Success = false;
            }
            else
            {
                Usuario existe = _usuarioRepositorio.BuscarPorEmail(usuarioDto.Email);
                if (!isUpdate && existe != null)
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

            //Valida telefone
            if (string.IsNullOrWhiteSpace(usuarioDto.Telefone))
            {
                result.Erros.Add("telefone", "Telefone não informado");
                result.Success = false;

            }else if(!TelefoneValido(usuarioDto.Telefone)){
                result.Success = false;
                result.Erros.Add("telefone", "Use apenas números (11 dígitos).");
            }

            //Verifica se a senha está sendo alterada
            bool alterandoSenha = !string.IsNullOrWhiteSpace(usuarioDto.Senha) || !string.IsNullOrWhiteSpace(usuarioDto.ConfirmarSenha);

            // Caso seja cadastro ou alteração explícita de senha
            if (!isUpdate || alterandoSenha)
            {

                if (string.IsNullOrWhiteSpace(usuarioDto.Senha))
                {
                    result.Erros.Add("senha", "Senha não informada");
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
                    result.Erros.Add("CSenha", "As senhas não coincidem.");
                    result.Success = false;
                }

                // Se está atualizando e alterando senha, validar a senha atual
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

        bool TelefoneValido(string telefone)
        {
            return Regex.IsMatch(telefone, @"^\d{11}$");
        }

        bool EmailValido(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        
    }
}
