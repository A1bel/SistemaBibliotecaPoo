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
    public partial class EditarUsuario : Form
    {
        private readonly UsuarioController _usuarioController;
        private Dictionary<string, Label> _errosLabels;
        private int _usuarioId;
        private bool _podeAlterarTipo;
        public EditarUsuario(int usuarioId, bool podeAlterarTipo = false)
        {
            InitializeComponent();
            _usuarioController = new UsuarioController();
            _usuarioId = usuarioId;
            _podeAlterarTipo= podeAlterarTipo;

            // Dicionário que liga o nome do campo à label correspondente de erro no formulário
            // Isso evita vários IFs e facilita iterar erros retornados pelo controller
            _errosLabels = new Dictionary<string, Label>
            {
                { "nome", erroNomeLbl },
                { "telefone", erroTelefoneLbl },
                { "email", erroEmailLbl },
                { "senha", erroSenhaLbl },
                { "CSenha", erroCSenhaLbl },
                { "senhaAtual", erroSenhaALbl }
            };
        }

        private void EditarUsuario_Load(object sender, EventArgs e)
        {
            //Busca o usuário e verifica se ele existe
            Usuario usuario = _usuarioController.BuscarUsuario(_usuarioId);
            if (usuario == null)
            {
                MessageBox.Show("Usuário não encontrado");
                this.Close();
                return;
            }

            // Preenche os campos com os dados do usuário a ser editado
            nomeTxt.Text = usuario.Nome;
            telefoneTxt.Text = usuario.Telefone;
            emailTxt.Text = usuario.Email;

            //Altera a visibilidade do campo tipo de acordo com o tipo de usuário
            if (_podeAlterarTipo)
            {
                tipoCmb.Visible = true;
                tipoLbl.Visible = true;
                tipoCmb.SelectedItem = usuario is Admin ? "Admin" : "Leitor";
              
            }
            else
            {
                tipoCmb.Visible = false;
                tipoLbl.Visible = false;
            }

        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cadastroBtn_Click(object sender, EventArgs e)
        {
            // Limpa mensagens de erro antes de tentar atualizar
            foreach (var lbl in _errosLabels.Values)
                lbl.Text = "";

            // Captura dados preenchidos no formulário
            UsuarioDto usuarioDto = new UsuarioDto
            {
                Id = _usuarioId,
                Tipo = tipoCmb.SelectedItem != null ? tipoCmb.SelectedItem.ToString() : string.Empty,
                Nome = nomeTxt.Text,
                Telefone = telefoneTxt.Text,
                Email = emailTxt.Text,
                Senha = senhaTxt.Text,
                ConfirmarSenha = confimarSenhaTxt.Text,
                SenhaAtual = senhaAtualTxt.Text
            };

            // Envia ao controller para validação e atualização
            ResultadoOperacao result = _usuarioController.AtualizarUsuario(usuarioDto);
            if (!result.Success)
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
                "Usuário atualizado com sucesso!",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
            this.Close();
        }
    }
}
