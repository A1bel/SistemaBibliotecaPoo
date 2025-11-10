using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBibliotecaPoo.Models.Usuario
{
    public class Admin : Usuario
    {
        public override string Tipo => "admin";

        public Admin(string nome, string telefone, string email, string senha): base(nome, telefone, email, senha) { }
    }
}
