using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBibliotecaPoo.Models.Usuarios
{
    public class Leitor : Usuario
    {
        public override string Tipo => "leitor";

        public Leitor(string nome, string telefone, string email, string senha) : base(nome, telefone, email, senha) { }
    }
}
