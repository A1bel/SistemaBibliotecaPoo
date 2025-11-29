using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBibliotecaPoo.Models.Usuarios
{
    // DTO usado para transferência de dados do usuário entre
    // as camadas do sistema (View → Controller → Model/Repository).
    // 
    // Ele existe para receber e transportar informações digitadas
    // no formulário.
    public class UsuarioDto
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string ConfirmarSenha { get; set; }
        public string SenhaAtual { get; set; }
    }
}
