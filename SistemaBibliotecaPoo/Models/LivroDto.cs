using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBibliotecaPoo.Models
{
    // DTO usado para transferência de dados do usuário entre
    // as camadas do sistema (View → Controller → Model/Repository).
    // 
    // Ele existe para receber e transportar informações digitadas
    // no formulário.
    public class LivroDto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Categoria { get; set; }
        public string Preco { get; set; }
        public string Quantidade { get; set; }
        public bool Disponivel { get; set; }
    }
}
