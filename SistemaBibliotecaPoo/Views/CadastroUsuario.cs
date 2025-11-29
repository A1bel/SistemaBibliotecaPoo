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
    public partial class CadastroUsuario : Form
    {
        private readonly UsuarioController _usuarioController;
        private Dictionary<string, Label> _errosLabels;

        public CadastroUsuario()
        {
            InitializeComponent();
            _usuarioController = new UsuarioController();


            // Dicionário que liga o nome do campo à label correspondente de erro no formulário
            // Isso evita vários IFs e facilita iterar erros retornados pelo controller
            _errosLabels = new Dictionary<string, Label>
            {
                { "nome", erroNomeLbl },
                { "telefone", erroTelefoneLbl },
                { "email", erroEmailLbl },
                { "senha", erroSenhaLbl },
                { "CSenha", erroCSenhaLbl }
            };
        }

        private void salvarBtn_Click(object sender, EventArgs e)
        {
            // Limpa mensagens de erro visuais antes de processar o cadastro
            foreach (var lbl in _errosLabels.Values)
                lbl.Text = "";

            // Cria o DTO com os valores informados pelo usuário
            UsuarioDto usuario = new UsuarioDto
            {
                Tipo = "leitor",
                Nome = nomeTxt.Text,
                Telefone = telefoneTxt.Text,
                Email = emailTxt.Text,
                Senha = senhaTxt.Text,
                ConfirmarSenha = confimarSenhaTxt.Text,
            };

            // Envia para o controller validar e cadastrar
            ResultadoOperacao result = _usuarioController.CadastrarUsuario(usuario);

            // Caso existam erros, exibe cada um na label correspondente
            if(!result.Success)
            {
                foreach (var erro in result.Erros)
                {
                    if (_errosLabels.ContainsKey(erro.Key))
                    {
                        _errosLabels[erro.Key].Text = erro.Value;
                    }
                }
                return;
            }

            MessageBox.Show(
                "Cadastro realizado com sucesso!",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
            this.Close();
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
