using SistemaBibliotecaPoo.Controllers;
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
    public partial class MeusLivros : Form
    {
        private readonly Usuario _usuarioLogado;
        private readonly EmprestimoController _emprestimoController;
        public MeusLivros(Usuario usuario)
        {
            InitializeComponent();
            _usuarioLogado = usuario;
            _emprestimoController = new EmprestimoController(_usuarioLogado);

            ConfigurarTabela();
            CarregarEmprestimos();
        }

        // Configura colunas da tabela
        private void ConfigurarTabela()
        {
            MeusLivrosDgv.AutoGenerateColumns = false;
            MeusLivrosDgv.RowHeadersVisible = false;

            // ID do empréstimo (oculto — usado internamente para devolução)
            MeusLivrosDgv.Columns.Add(new DataGridViewTextBoxColumn
            { 
                HeaderText = "IdEmprestimo",
                DataPropertyName = "Id",
                Name = "Id",
                Visible = false
            });

            // Demais colunas exibidas ao usuário
            MeusLivrosDgv.Columns.Add(new DataGridViewTextBoxColumn
            { 
                HeaderText = "Título",
                DataPropertyName = "Titulo",
                Width = 200
            });

            MeusLivrosDgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Autor",
                DataPropertyName = "Autor",
                Width = 150
            });

            MeusLivrosDgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Data Empréstimo",
                DataPropertyName = "DataEmprestimo",
                Width = 120
            });

            // Botão de ação para devolução
            MeusLivrosDgv.Columns.Add(new DataGridViewButtonColumn
            {
                HeaderText = "Ações",
                Name = "btnDevolver",
                Text = "Devolver",
                UseColumnTextForButtonValue = true,
                Width = 100
            });
        }

        // Carrega todos os empréstimos pertencentes ao usuário logado
        private void CarregarEmprestimos()
        {
            var lista = _emprestimoController.ObterEmprestimosDoUsuario();
            MeusLivrosDgv.DataSource = lista;
        }

        // Evento disparado ao clicar na tabela — aqui tratamos o botão "Devolver"
        private void MeusLivrosDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MeusLivrosDgv.Columns[e.ColumnIndex].Name == "btnDevolver")
            {
                int emprestimoId = (int)MeusLivrosDgv.Rows[e.RowIndex].Cells["Id"].Value;

                var confirmar = MessageBox.Show(
                    "Deseja devolver este livro?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmar == DialogResult.Yes)
                {
                    var emprestimo = _emprestimoController.BuscarEmprestimo(emprestimoId);

                    // Controller faz a devolução e retorna resultado validado
                    var resposta = _emprestimoController.DevolverLivro(emprestimo.LivroId);

                    if (!resposta.Success)
                    {
                        MessageBox.Show(resposta.Erros["geral"], "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    MessageBox.Show("Livro devolvido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarEmprestimos();
                }
            }
        }

        private void voltarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
