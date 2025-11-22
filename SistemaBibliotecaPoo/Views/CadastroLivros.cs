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
    public partial class CadastroLivros : Form
    {
        private readonly LivroController _livroController;
        private Dictionary<string, Label> _errosLabels;
        public CadastroLivros()
        {
            InitializeComponent();
            _livroController = new LivroController();

            _errosLabels = new Dictionary<string, Label>
            {
                {"titulo", erroTituloLbl },
                {"autor", erroAutorLbl },
                {"categoria", erroCategoriaLbl },
                {"preco", erroPrecoLbl },
                {"quantidade", erroQuantidadeLbl }
            };
        }

        private void cadastroBtn_Click(object sender, EventArgs e)
        {
            foreach (var lbl in _errosLabels.Values)
                lbl.Text = "";

            LivroDto livro = new LivroDto
            {
                Titulo = tituloTxt.Text,
                Autor = autorTxt.Text,
                Categoria = categoriaTxt.Text,
                Preco = precoTxt.Text,
                Quantidade = quantidadeTxt.Text
            };

            ResultadoOperacao result = _livroController.CadastrarLivro(livro);
            if (!result.Success)
            {
                foreach(var erro in result.Erros)
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
