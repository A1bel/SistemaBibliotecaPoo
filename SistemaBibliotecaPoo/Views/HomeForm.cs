using SistemaBibliotecaPoo.Controllers;
using SistemaBibliotecaPoo.Models.Usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBibliotecaPoo.Views
{
    public partial class HomeForm : Form
    {
        private readonly LivroController _livroController;
        private bool _primeiraVez = true;
        public HomeForm()
        {
            InitializeComponent();
            _livroController = new LivroController();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            CarregarLivros();

        }

        private void CarregarLivros()
        {
            flowLivrosPanel.Controls.Clear();
            List<Livro> livros = _livroController.BuscarTodosLivros();

            foreach (Livro livro in livros)
            {
                LivroCard card = new LivroCard();
                card.SetData(livro);

                flowLivrosPanel.Controls.Add(card);
            }
        }
        private void CadastrarLivroBtn_Click(object sender, EventArgs e)
        {
            using(CadastroLivros frmCadastro = new CadastroLivros())
            {
                frmCadastro.ShowDialog();
                CarregarLivros();
            }
        }
    }
}
