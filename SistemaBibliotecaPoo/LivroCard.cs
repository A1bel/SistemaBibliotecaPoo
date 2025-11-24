using SistemaBibliotecaPoo.Controllers;
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
        private readonly EmprestimoController _emprestimoController;
        private readonly LivroController _livroController;
        public LivroCard(Usuario usuario)
        {
            InitializeComponent();
            _emprestimoController = new EmprestimoController(usuario);
            _livroController = new LivroController();
        }

        public void SetData(Livro livro, Usuario usuario)
        {
            if (usuario is Admin)
            {
                editarLivroBtn.Visible = true;
                alugarBtn.Visible = false;

                adminPanel.Visible = true;

                qtdLbl.Text = livro.Quantidade.ToString();
                statusLbl.Text = livro.Disponivel ? "Disponível" : "Indisponível";
            }
            else if (usuario is Leitor)
            {
                editarLivroBtn.Visible = false;
                alugarBtn.Visible = true;

                adminPanel.Visible = false;
            }

            tituloLbl.Text = livro.Titulo;
            tituloLbl.Left = (this.Width - tituloLbl.Width) / 2;
            precoLbl.Text = livro.Preco.ToString("F2");
            autorLbl.Text = livro.Autor;
            categoriaLbl.Text = livro.Categoria;

            this.Tag = livro.Id;
        }

        private void editarLivroBtn_Click(object sender, EventArgs e)
        {
            int livroId = (int)this.Tag;
            using (EdicaoLivros frmEdit = new EdicaoLivros(livroId))
            {
                var result = frmEdit.ShowDialog();
                if (result == DialogResult.OK)
                    LivroAtualizado?.Invoke();
            }
        }

        private void alugarBtn_Click(object sender, EventArgs e)
        {
            var confirmar = MessageBox.Show(
            "Deseja realmente alugar este livro?",
            "Confirmação",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (confirmar == DialogResult.Yes)
            {
                ResultadoOperacao result = _emprestimoController.RealizarEmprestimo((int)this.Tag);

                if (!result.Success)
                {
                    MessageBox.Show(
                    result.Erros["geral"],
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                    return;
                }

                LivroAtualizado?.Invoke();
            }
        }

        private void deletarBtn_Click(object sender, EventArgs e)
        {

            var confirmar = MessageBox.Show(
            "Deseja realmente deletar este livro?",
            "Confirmação",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            
            if(confirmar == DialogResult.Yes)
            {
                ResultadoOperacao result = _livroController.RemoverLivro((int)this.Tag);

                if (!result.Success)
                {
                    MessageBox.Show(
                        result.Erros["geral"],
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                LivroAtualizado?.Invoke();
            }
        }
    }
}
