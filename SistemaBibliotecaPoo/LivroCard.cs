using SistemaBibliotecaPoo.Models;
using SistemaBibliotecaPoo.Models.Usuarios;
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

        public void SetData(Livro livro, Usuario usuario)
        {
            if (usuario is Admin)
            {
                editarLivroBtn.Visible = true;
                alugarBtn.Visible = false;
            }
            else if(usuario is Leitor)
            {
                editarLivroBtn.Visible = false;
                alugarBtn.Visible = true;
            }

                tituloLbl.Text = livro.Titulo;
            precoLbl.Text = livro.Preco.ToString();
            autorLbl.Text = livro.Autor;
            categoriaLbl.Text = livro.Categoria;

            this.Tag = livro.Id;
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

        private void alugarBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
