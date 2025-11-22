using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBibliotecaPoo.Models.Usuarios
{
    public abstract class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public abstract string Tipo {  get; }

        public Usuario(string nome, string telefone, string email, string senha) 
        { 
            Nome = nome;
            Telefone = telefone;
            Email = email;
            Senha = senha;
        }
    }
}
