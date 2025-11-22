using SistemaBibliotecaPoo.Controllers;
using SistemaBibliotecaPoo.Models;
using SistemaBibliotecaPoo.Models.Usuario;
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
    public partial class EdicaoLivros : Form
    {
        private readonly LivroController _livroController;
        private Dictionary<string, Label> _errosLabels;
        private int _livroId;
        public EdicaoLivros(int id)
        {
            InitializeComponent();
            _livroController = new LivroController();
            _livroId = id;

            _errosLabels = new Dictionary<string, Label>
            {
                {"titulo", erroTituloLbl },
                {"autor", erroAutorLbl },
                {"categoria", erroCategoriaLbl },
                {"preco", erroPrecoLbl },
                {"quantidade", erroQuantidadeLbl }
            };
        }

        private void EdicaoLivros_Load(object sender, EventArgs e)
        {
            Livro livro = _livroController.BuscarLivro(_livroId);
            if(livro == null)
            {
                MessageBox.Show("Livro não encontrado");
                this.Close();
                return;
            }

            tituloTxt.Text = livro.Titulo;
            autorTxt.Text = livro.Autor;
            categoriaTxt.Text = livro.Categoria;
            precoTxt.Text = livro.Preco.ToString();
            quantidadeTxt.Text = livro.Quantidade.ToString();
            disponivelBox.SelectedItem = livro.Disponivel ? "Disponível" : "Indisponível";
        }

        private void cancelarEditarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salvarEditarBtn_Click(object sender, EventArgs e)
        {
            foreach (var lbl in _errosLabels.Values)
                lbl.Text = "";

            LivroDto livro = new LivroDto
            {
                Id = _livroId,
                Titulo = tituloTxt.Text,
                Autor = autorTxt.Text,
                Categoria = categoriaTxt.Text,
                Preco = precoTxt.Text,
                Quantidade = quantidadeTxt.Text,
                Disponivel = disponivelBox.Text == "Disponível"
            };

            ResultadoOperacao result = _livroController.AtualizarLivro(livro);
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
                "Livro atualizado com sucesso!",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
