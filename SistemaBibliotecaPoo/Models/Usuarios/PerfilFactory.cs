using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBibliotecaPoo.Models.Usuarios
{
    // Fábrica responsável por criar instâncias de usuários
    // de acordo com o tipo informado.
    public static class PerfilFactory
    {
        public static Usuario CriarUsuario(string tipo, string nome, string telefone, string email, string senha)
        {
            switch(tipo.ToLower())
            {
                case "admin": return new Admin(nome, telefone, email, senha);
                case "leitor": return new Leitor(nome, telefone, email, senha);
                default: throw new ArgumentException("Tipo de usuário inválido");
            }
        }
    }
}
