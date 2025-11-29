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
    public partial class Login : Form
    {
        private readonly UsuarioController _usuarioController;

        // Evento disparado quando o login é bem-sucedido, enviando o usuário para a Home
        public event Action<Usuario> OnLoginSucesso;
        public Login()
        {
            InitializeComponent();
            _usuarioController = new UsuarioController();
        }

        private void entrarBtn_Click(object sender, EventArgs e)
        {
            //Limpa a mensagem de erro
            erroLbl.Text = "";

            // Envia ao controller para validação e verificação de credenciais
            ResultadoOperacao result = _usuarioController.Login(emailTxt.Text, senhaTxt.Text);

            // Se falhou, exibe o erro retornado
            if (!result.Success)
            {
                erroLbl.Text = result.Erros["geral"];
                return;
            }

            OnLoginSucesso?.Invoke(result.UsuarioLogado);
            this.Close();

        }

        // Abre o formulário de cadastro de usuário
        private void contaLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CadastroUsuario frmCadastro = new CadastroUsuario();
            frmCadastro.FormClosed += (s, args) => this.Show();
            frmCadastro.Show();
            this.Hide();
        }
    }
}
