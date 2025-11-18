using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBibliotecaPoo.Models
{
    public class ResultadoOperacao
    {
        public bool Success { get; set; }
        public Dictionary<string, string> Erros { get; set; } = new Dictionary<string, string>();

    }
}
