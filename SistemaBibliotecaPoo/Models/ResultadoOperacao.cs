using SistemaBibliotecaPoo.Models.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBibliotecaPoo.Models
{
    // Representa o resultado de uma operação executada na aplicação
    // (como login, atualização de usuário, cadastro de livro, etc.)
    // 
    // É utilizada para retornar sucesso, erros de validação ou
    // um usuário autenticado quando necessário.
    public class ResultadoOperacao
    {
        public bool Success { get; set; }
        public Dictionary<string, string> Erros { get; set; } = new Dictionary<string, string>();
        public Usuario UsuarioLogado { get; set; }

    }
}
