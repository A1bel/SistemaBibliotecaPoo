using SistemaBibliotecaPoo.Models.Usuario;
using SistemaBibliotecaPoo.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBibliotecaPoo
{
    public partial class LivroCard : UserControl
    {
        public event Action LivroAtualizado;
        public LivroCard()
        {
            InitializeComponent();
        }

        public void SetData(Livro livro)
        {
            tituloLbl.Text = livro.Titulo;
            precoLbl.Text = livro.Preco.ToString();
            autorLbl.Text = livro.Autor;
            categoriaLbl.Text = livro.Categoria;

            this.Tag = livro.Id;
        }

        private void detalhesBtn_Click(object sender, EventArgs e)
        {

        }

        private void editarLivroBtn_Click(object sender, EventArgs e)
        {
            int livroId = (int)this.Tag;
            using(EdicaoLivros frmEdit = new EdicaoLivros(livroId))
            {
                var result = frmEdit.ShowDialog();
                if (result == DialogResult.OK)
                    LivroAtualizado?.Invoke();
            }
        }
    }
}
