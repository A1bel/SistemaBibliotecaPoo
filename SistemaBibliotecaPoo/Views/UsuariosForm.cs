using SistemaBibliotecaPoo.Controllers;
using SistemaBibliotecaPoo.Models;
using SistemaBibliotecaPoo.Models.Usuarios;
using SistemaBibliotecaPoo.Repositories;
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
    public partial class UsuariosForm : Form
    {
        private readonly UsuarioController _usuarioController;
        public UsuariosForm()
        {
            InitializeComponent();
            _usuarioController = new UsuarioController();

            ConfigurarTabela();
            CarregarUsuarios();
        }

        // Configura colunas da tabela
        private void ConfigurarTabela()
        {
            usuariosDgv.AutoGenerateColumns = false;
            usuariosDgv.RowHeadersVisible = false;

            // Coluna escondida apenas para manter o ID na memória
            usuariosDgv.Columns.Add(new DataGridViewTextBoxColumn
            { 
                HeaderText = "IdUsuario",
                DataPropertyName = "Id",
                Name = "Id",
                Visible = false
            });

            //Demais colunas
            usuariosDgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Nome",
                DataPropertyName = "Nome",
                Width = 200
            });

            usuariosDgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Telefone",
                DataPropertyName = "Telefone",
                Width = 150
            });

            usuariosDgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Email",
                DataPropertyName = "Email",
                Width = 120
            });

            // Coluna com botão para edição
            usuariosDgv.Columns.Add(new DataGridViewButtonColumn
            {
                HeaderText = "Ações",
                Name = "btnEditar",
                Text = "Editar",
                UseColumnTextForButtonValue = true,
                Width = 100
            });
        }

        // Carrega todos os usuários do sistema e exibe no grid.
        private void CarregarUsuarios()
        {
            List<Usuario> usuarios = _usuarioController.BuscarTodosUsuarios();
            usuariosDgv.DataSource = usuarios;
        }

        private void voltarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Evento disparado ao clicar na tabela — aqui tratamos o botão "Editar"
        private void usuariosDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (usuariosDgv.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int usuarioId = (int)usuariosDgv.Rows[e.RowIndex].Cells["Id"].Value;
                using (EditarUsuario frmEdit = new EditarUsuario(usuarioId, podeAlterarTipo: true))
                {
                    var result = frmEdit.ShowDialog();
                    CarregarUsuarios();
                }
            }
        }
    }
}
