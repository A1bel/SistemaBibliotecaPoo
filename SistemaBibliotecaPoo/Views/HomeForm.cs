using SistemaBibliotecaPoo.Controllers;
using SistemaBibliotecaPoo.Models;
using SistemaBibliotecaPoo.Models.Usuarios;
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
        private Usuario _usuario;
        public event Action OnLogout;
        public HomeForm(Usuario usuario)
        {
            InitializeComponent();
            _livroController = new LivroController();
            _usuario = usuario;
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            CarregarLivros();
            if(_usuario is Admin)
            {
                meusLivrosBtn.Visible = false;
                CadastrarLivroBtn.Visible = true;
                usuariosBtn.Visible = true;
            }
            else if (_usuario is Leitor)
            {
                meusLivrosBtn.Visible = true;
                CadastrarLivroBtn.Visible = false;
                usuariosBtn.Visible = false;
            }
        }

        private void CarregarLivros()
        {
            flowLivrosPanel.Controls.Clear();

            List<Livro> livros;
            if( _usuario is Admin) 
                livros = _livroController.BuscarTodosLivros();
            else
                livros = _livroController.BuscarDisponiveis();

            foreach (Livro livro in livros)
                {
                    LivroCard card = new LivroCard(_usuario);
                    card.SetData(livro, _usuario);

                    card.LivroAtualizado += CarregarLivros;

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

        private void meusLivrosBtn_Click(object sender, EventArgs e)
        {
            MeusLivros meusLivros = new MeusLivros(_usuario);
            this.Hide();
            meusLivros.ShowDialog();
            CarregarLivros();
            this.Show();

        }

        private void sairBtn_Click(object sender, EventArgs e)
        {
            OnLogout?.Invoke();
            this.Close();
        }

        private void usuariosBtn_Click(object sender, EventArgs e)
        {
            UsuariosForm frmUsuarios = new UsuariosForm();
            this.Hide();
            frmUsuarios.ShowDialog();
            CarregarLivros();
            this.Show();
        }

        private void alterarBtn_Click(object sender, EventArgs e)
        {
            using (EditarUsuario frmEdit = new EditarUsuario(_usuario.Id, podeAlterarTipo: _usuario is Admin))
            {
                var result = frmEdit.ShowDialog();
            }
        }
    }
}
