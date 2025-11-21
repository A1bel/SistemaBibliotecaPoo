using SistemaBibliotecaPoo.Controllers;
using SistemaBibliotecaPoo.Models;
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
        public Login()
        {
            InitializeComponent();
            _usuarioController = new UsuarioController();
        }

        private void entrarBtn_Click(object sender, EventArgs e)
        {
            erroLbl.Text = "";

            ResultadoOperacao result = _usuarioController.Login(emailTxt.Text, senhaTxt.Text);
            if (!result.Success)
            {
                erroLbl.Text = result.Erros["geral"];
                return;
            }

            HomeForm home = new HomeForm();
            home.FormClosed += (s, args) => this.Close();
            home.Show();
            this.Hide();

        }

        private void contaLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CadastroUsuario frmCadastro = new CadastroUsuario();
            frmCadastro.FormClosed += (s, args) => this.Show();
            frmCadastro.Show();
            this.Hide();
        }
    }
}
