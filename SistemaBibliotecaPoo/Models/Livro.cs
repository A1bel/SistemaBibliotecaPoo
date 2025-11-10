using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBibliotecaPoo.Models.Usuario
{
    internal class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Categoria { get; set; }
        public bool Disponivel { get; set; }
    }
}
