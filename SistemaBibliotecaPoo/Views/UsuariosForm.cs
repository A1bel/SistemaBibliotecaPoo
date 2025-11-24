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

        private void ConfigurarTabela()
        {
            usuariosDgv.AutoGenerateColumns = false;
            usuariosDgv.RowHeadersVisible = false;

            usuariosDgv.Columns.Add(new DataGridViewTextBoxColumn
            { 
                HeaderText = "IdUsuario",
                DataPropertyName = "Id",
                Name = "Id",
                Visible = false
            });

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

            usuariosDgv.Columns.Add(new DataGridViewButtonColumn
            {
                HeaderText = "Ações",
                Name = "btnEditar",
                Text = "Editar",
                UseColumnTextForButtonValue = true,
                Width = 100
            });
        }

        private void CarregarUsuarios()
        {
            List<Usuario> usuarios = _usuarioController.BuscarTodosUsuarios();
            usuariosDgv.DataSource = usuarios;
        }

        private void voltarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
